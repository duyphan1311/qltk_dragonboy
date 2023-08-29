using LitJson;
using QLTK.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;

namespace QLTK;

public class StateObject
{
    // Size of receive buffer.  
    public const int BufferSize = 2048;

    // Receive buffer.  
    public byte[] buffer = new byte[BufferSize];

    // Client socket.
    public Socket workSocket = null;

    public Account account = null;
}

public static class SocketServer
{
    public static List<Account> waitingAccounts = new List<Account>();

    // Thread signal.  
    public static ManualResetEvent allDone = new ManualResetEvent(false);

    private static void onMessage(JsonData msg, StateObject state)
    {
        string action = (string)msg["action"];
        switch (action)
        {
            case "updateInfo":
                state.account.status = (string)msg["status"];
                state.account.charID = (int)msg["charID"];
                state.account.cName = (string)msg["cName"];
                state.account.cgender = (int)msg["cgender"];
                state.account.mapName = (string)msg["mapName"];
                state.account.mapID = (int)msg["mapID"];
                state.account.zoneID = (int)msg["zoneID"];
                state.account.cx = (int)msg["cx"];
                state.account.cy = (int)msg["cy"];
                state.account.cHP = (int)msg["cHP"];
                state.account.cHPFull = (int)msg["cHPFull"];
                state.account.cMP = (int)msg["cMP"];
                state.account.cMPFull = (int)msg["cMPFull"];
                state.account.cStamina = (int)msg["cStamina"];
                state.account.cMaxStamina = (int)msg["cMaxStamina"];
                state.account.cPower = (long)msg["cPower"];
                state.account.cTiemNang = (long)msg["cTiemNang"];
                state.account.cHPGoc = (int)msg["cHPGoc"];
                state.account.cMPGoc = (int)msg["cMPGoc"];
                state.account.cDefGoc = (int)msg["cDefGoc"];
                state.account.cCriticalGoc = (int)msg["cCriticalGoc"];
                state.account.cDamFull = (int)msg["cDamFull"];
                state.account.cDefull = (int)msg["cDefull"];
                state.account.cCriticalFull = (int)msg["cCriticalFull"];
                state.account.cPetName = (string)msg["cPetName"];
                state.account.cPetGender = (int)msg["cPetGender"];
                state.account.cPetHP = (int)msg["cPetHP"];
                state.account.cPetHPFull = (int)msg["cPetHPFull"];
                state.account.cPetMP = (int)msg["cPetMP"];
                state.account.cPetMPFull = (int)msg["cPetMPFull"];
                state.account.cPetDamFull = (int)msg["cPetDamFull"];
                state.account.cPetDefull = (int)msg["cPetDefull"];
                state.account.cPetCriticalFull = (int)msg["cPetCriticalFull"];
                state.account.cPetStamina = (int)msg["cPetStamina"];
                state.account.cPetMaxStamina = (int)msg["cPetMaxStamina"];
                state.account.cPetPower = (long)msg["cPetPower"];
                state.account.cPetTiemNang = (long)msg["cPetTiemNang"];
                state.account.petStatus = (string)msg["petStatus"];
                state.account.xu = (long)msg["xu"];
                state.account.luong = (int)msg["luong"];
                state.account.luongKhoa = (int)msg["luongKhoa"];
                break;
            case "setStatus":
                string status = (string)msg["status"];
                Utilities.UpdateStatus(state.account, status);
                break;
            case "syncKeyPressed":
            case "syncKeyReleased":
                QLTK.qltk.Invoke(() =>
                {
                    var mainWindow = Utilities.GetMainWindow();
                    mainWindow.GetAccounts().ForEach(a =>
                    {
                        if (a.workSocket?.Connected == true && a != state.account)
                        {
                            sendMessage(a, new
                            {
                                action = (string)msg["action"],
                                keyCode = (int)msg["keyCode"],
                                channelSyncKey = (int)msg["channelSyncKey"]
                            });
                        }
                    });
                });
                break;
            case "connected":
                int id = (int)msg["id"];
                state.account = waitingAccounts.Find(a => a.process.Id == id);
                state.account.workSocket = state.workSocket;

                string[] array = state.account.size.Split('x');

                int width = int.Parse(array[0]);
                int height = int.Parse(array[1]);
                
                Controllers.sizeData = new
                {
                    width,
                    height,
                    graphic = state.account.graphic
                };

                int idx = Controllers.servers.FindIndex(server => server.host.Trim().ToLower() == state.account.host.Trim().ToLower());
                if(idx == -1)
                {
                    MessageBox.Show($"Không tìm thấy server {state.account.host.Trim()}!!!", "Warning", MessageBoxButton.OK);
                    state.account.process.Kill();
                    Utilities.UpdateStatus(state.account, "...");
                    return;
                }
                Host svr = Controllers.servers[idx];

                string serverIndex = svr.listServer.FindIndex(sv => sv.serverName.ToLower() == state.account.server.ToLower()).ToString();
                string host = svr.listServer[int.Parse(serverIndex)].ip;
                string port = svr.listServer[int.Parse(serverIndex)].port;
                string version = state.account.version.ToString();

                sendMessage(state.account, new
                {
                    state.account.username,
                    state.account.password,
                    host,
                    serverIndex,
                    port,
                    Controllers.sizeData,
                    version
                });

                Utilities.UpdateStatus(state.account, "Đã kết nối");
                break;
            default:
                break;
        }
    }

    public static void sendMessage(Account account, object obj)
    {
        Send(account.workSocket, JsonMapper.ToJson(obj));
    }

    public static void StartListening()
    {
        // Data buffer for incoming data.  
        ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[2048]);

        // Establish the local endpoint for the socket.  
        // Dns.GetHostName returns the name of the
        // host running the application.  
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, Controllers.PortListener);

        // Create a TCP/IP socket.  
        Socket listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        // Bind the socket to the local endpoint and
        // listen for incoming connections.  
        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(20);

            while (true)
            {
                // Set the event to nonsignaled state.  
                allDone.Reset();

                // Start an asynchronous socket to listen for connections.  
                //Console.WriteLine("Waiting for a connection...");
                listener.BeginAccept(
                    callback: new AsyncCallback(AcceptCallback),
                    state: listener);

                // Wait until a connection is made before continuing.  
                allDone.WaitOne();
            }

            // Start listening for connections.  

        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }

    public static void AcceptCallback(IAsyncResult ar)
    {
        // Signal the main thread to continue.  
        allDone.Set();

        // Get the socket that handles the client request.  
        Socket listener = (Socket)ar.AsyncState;
        Socket handler = listener.EndAccept(ar);

        // Create the state object.  
        var state = new StateObject
        {
            workSocket = handler,
        };

        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
            new AsyncCallback(ReadCallback), state);
    }

    public static void ReadCallback(IAsyncResult ar)
    {
        string content = string.Empty;

        // Retrieve the state object and the handler socket  
        // from the asynchronous state object.  
        StateObject state = (StateObject)ar.AsyncState;
        Socket handler = state.workSocket;

        int bytesRead = 0;
        try
        {
            bytesRead = handler.EndReceive(ar);
        }
        catch (SocketException)
        {
            Utilities.UpdateStatus(state.account, "...");
        }

        if (bytesRead > 0)
        {
            content = Encoding.ASCII.GetString(
                state.buffer, 0, bytesRead);

            var msg = JsonMapper.ToObject(content);

            string action = (string)msg["action"];
            if (action == "close-socket")
            {
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                Utilities.UpdateStatus(state.account, "...");
                return;
            }

            onMessage(msg, state);

            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }
    }

    private static void SendCallback(IAsyncResult ar)
    {
        try
        {
            // Retrieve the socket from the state object.  
            Socket handler = (Socket)ar.AsyncState;

            // Complete sending the data to the remote device.  
            _ = handler.EndSend(ar);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    private static void Send(Socket handler, string data)
    {
        // Convert the string data to byte data using ASCII encoding.  
        byte[] byteData = Encoding.ASCII.GetBytes(data);

        // Begin sending the data to the remote device.  
        handler.BeginSend(byteData, 0, byteData.Length, 0,
            new AsyncCallback(SendCallback), handler);
    }
}

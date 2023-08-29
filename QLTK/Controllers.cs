using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTK;

internal class Controllers
{
	private static readonly string GamePath = "Game\\";
	private static readonly string DataPath = "Data\\";
	private static readonly string FileTKName = "TK.txt";
	private static readonly string FileListServerName = "DanhSachServer.txt";
	private static readonly string FileErrorName = "log_qltk.txt";
	private static readonly string FileTKPath = DataPath + FileTKName;
	private static readonly string FileListServerPath = DataPath + FileListServerName;
	public static readonly string FileErrorPath = DataPath + "\\err\\" + FileErrorName;
	private static readonly string GameVersion = "GameVersion.txt";
	public static readonly int PortListener = 22325;
	private static readonly int maxWidth = (int)System.Windows.SystemParameters.PrimaryScreenWidth;
	private static readonly int maxHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight;
	public static object sizeData = null;
	public static List<Account> accounts = new();
	public static List<Host> servers = new();
	public static List<string> versions = new();
	public static void LoadListServer()
	{
		try
		{
			servers.Clear();
			string[] textLines = File.ReadAllLines(FileListServerPath);
            for (var i = 0; i < textLines.Length; i++)
            {
				string text = textLines[i].Trim();
                if (!text.StartsWith("#") || text == string.Empty)
					continue;

				List<Server> data = new();
				for(var j = i + 1; j < textLines.Length; j++)
                {
					if (textLines[j].StartsWith("#") || text == string.Empty)
						break;

					string[] array = textLines[j].Trim().Split(':');
					data.Add(new Server() {
						serverName = array[0],
						ip = array[1],
						port = array[2]
					});
                }
				servers.Add(new Host()
				{
					host = text.Replace("#", ""),
					listServer = data
				});
			}
		}
		catch (Exception e)
		{
			writeLog(e.ToString());
		}
	}
	public static void LoadComboboxHost(ComboBox comboBoxHost)
    {
		comboBoxHost.Items.Clear();
		foreach(var server in servers)
        {
			comboBoxHost.Items.Add(server.host);
        }
    }
	public static void writeLog(string log)
	{
		try
		{
			File.AppendAllText(FileErrorPath, $"----------{DateTime.Now.ToString("HH:mm dd/MM/yyyy")}----------\n\n{log}\n\n\n");
		}
		catch { }
	}
	public static void ExistFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
			File.Create(filePath).Close();
        }
    }
	public static List<string> GetGameVersion()
	{
        versions.Clear();
        ExistFile(DataPath + GameVersion);
        string[] array = File.ReadAllLines(DataPath + GameVersion);
        for (int i = 0; i < array.Length; i++)
			versions.Add(array[i]);
        return versions;
    }
	public static void SetGameVersion(ComboBox comboBox)
	{
        comboBox.Items.Clear();
        foreach (var version in versions)
        {
            comboBox.Items.Add(version);
        }
    }
	public static void SaveVersion()
	{
        StreamWriter streamWriter = new StreamWriter(DataPath + GameVersion);
		foreach(var version in versions)
		{
            streamWriter.Write(version.ToString());
            streamWriter.WriteLine("");
        }
        streamWriter.Close();
    }
	public static void DeleteVersion(ComboBox comboBox)
	{
        foreach (var version in versions)
        {
            if(version.ToString() == comboBox.Text)
			{
                versions.Remove(version);
				break;
            }
        }
		SaveVersion();
    }
	public static void SaveServer()
	{
        var delimiter = "\t";
        StreamWriter streamWriter = new StreamWriter(FileListServerPath);
        foreach (var host in servers)
        {
            streamWriter.Write("#" + host.host);
            streamWriter.WriteLine("");
			foreach(var server in host.listServer)
			{
                streamWriter.Write($"{delimiter}{server.serverName}:{server.ip}:{server.port}");
                streamWriter.WriteLine("");
            }
        }
        streamWriter.Close();
    }
	public static void DeleteServer(ComboBox comboBoxHost, ComboBox comboBoxServer)
	{
        string hostSelected = comboBoxHost.Text.Trim().ToLower();
        int indexHost = servers.FindIndex(server => server.host.ToLower() == hostSelected);

        if(indexHost != -1)
		{
            string serverSelected = comboBoxServer.Text.Trim().ToLower();
            int indexServer = servers[indexHost].listServer.FindIndex(server => server.serverName.ToLower() == serverSelected);

			if (indexServer != -1)
			{
                if (MessageBox.Show($"Bạn có chắc muốn xoá server {servers[indexHost].listServer[indexServer].serverName} ?", "Chắc chưa ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                servers[indexHost].listServer.Remove(servers[indexHost].listServer[indexServer]);
            }
			else
			{
                if (MessageBox.Show($"Bạn có chắc muốn xoá host {servers[indexHost].host} ?\n" +
					$"Điều này đồng nghĩa bạn sẽ xoá tất cả server cùng chung host này???", "Chắc chưa ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                servers.Remove(servers[indexHost]);
            }
        }
		else
		{
			MessageBox.Show("Bạn chưa chọn host để xoá!!!", "Error", MessageBoxButtons.OK);
		}
    }
	public static List<Account> LoadFileListAccount()
    {
		try
		{
            accounts.Clear();
            ExistFile(FileTKPath);
            accounts = string.IsNullOrEmpty(File.ReadAllText(FileTKPath)) ? new List<Account>() : LitJson.JsonMapper.ToObject<List<Account>>(
						Utilities.DecryptString(File.ReadAllText(FileTKPath)));
            return accounts;
        }
		catch
		{
            ExportFile(QLTK.dataGridView);
            return accounts =  new List<Account>();
        }
    }
	public static List<Account> RefreshListAccounts(Account account)
    {
		int index = accounts.FindIndex(acc => acc.id == account.id);
		if (index != -1)
			accounts[index] = account;
		return accounts;
    }
	public static List<Account> GetListAccounts()
		=> accounts;
	public static void ExportFile(DataGridView dataGridView)
	{
        try
        {
            if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");
            File.WriteAllText(FileTKPath,
				Utilities.EncryptString(LitJson.JsonMapper.ToJson(dataGridView.DataSource)));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
	public static void LoadAccountToDataGridView(DataGridView dataGridView, BindingSource data)
	{
		try
		{
			dataGridView.Rows.Clear();
			data.Clear();
			foreach (var account in accounts)
				data.Add(account);
        }
		catch (Exception e)
		{
			writeLog(e.ToString());
		}
	}
	public static async void Login()
	{
		try
		{
            var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
            if (accounts.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản");
                return;
			}
			QLTK.qltk.Enabled = false;
			await OpenGamesAsync(accounts);
			QLTK.qltk.Enabled = true;
		}
        catch (Exception e)
		{
			writeLog(e.ToString());
		}
	}
	public static void LoginAll(DataGridView dataGridView)
	{
		dataGridView.SelectAll();
		Login();
	}
	public static void EditAccount(TextBox txtAcc, TextBox txtPass, ComboBox cbbHost, ComboBox cbbServer, ComboBox cbbGraphic, TextBox txtSizeW, TextBox txtSizeH, ComboBox cbbVersion, TextBox txtNote)
    {
		if (Controllers.CheckAdd(txtAcc, txtPass, cbbHost, cbbServer, cbbGraphic, txtSizeW, txtSizeH))
		{
			var account = Utilities.GetMainWindow().GetSelectedAccount();
			if(account != null)
            {
				account.username = txtAcc.Text;
				account.password = txtPass.Text;
				account.host = cbbHost.Text;
				account.server = cbbServer.Text;
				account.graphic = cbbGraphic.Text;
				account.size = txtSizeW.Text + "x" + txtSizeH.Text;
				account.version = int.Parse(cbbVersion.Text);
				account.note = txtNote.Text;
				Utilities.RefreshAccounts(account);
				Controllers.ExportFile(QLTK.dataGridView);
			}
			else 
				MessageBox.Show("Vui lòng chọn tài khoản");
		}
	}
	public static void Delete()
	{
        try
        {
			if (MessageBox.Show($"Bạn có chắc muốn xoá tài khoản ?", "Chắc chưa ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
			if (accounts.Count() == 0)
			{
				MessageBox.Show("Vui lòng chọn tài khoản");
				return;
			}
			foreach (var account in accounts)
				GetListAccounts().Remove(account);
			if(GetListAccounts().Any())
				for (int i = 0; i < GetListAccounts().Count(); i++)
				{
					GetListAccounts()[i].id = i + 1;
					Utilities.GetMainWindow().RefreshAccounts();
				}
            else
                Utilities.GetMainWindow().RefreshAccounts();
            ExportFile(QLTK.dataGridView);
		}
		catch (Exception e)
        {
			writeLog(e.ToString());
		}
    }
	public static bool CheckAdd(TextBox txtAcc, TextBox txtPass, ComboBox cbbHost, ComboBox cbbServer, ComboBox cbbGraphic, TextBox txtSizeW, TextBox txtSizeH)
	{
		if (string.IsNullOrEmpty(txtAcc.Text))
		{
			MessageBox.Show("Chưa nhập tài khoản", "Error", MessageBoxButtons.OK);
			txtAcc.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(txtPass.Text))
		{
			MessageBox.Show("Chưa nhập mật khẩu", "Error", MessageBoxButtons.OK);
			txtPass.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(cbbHost.Text))
		{
			MessageBox.Show("Chưa chọn host", "Error", MessageBoxButtons.OK);
			cbbHost.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(cbbServer.Text))
		{
			MessageBox.Show("Chưa chọn server", "Error", MessageBoxButtons.OK);
			cbbServer.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(cbbGraphic.Text))
		{
			MessageBox.Show("Chưa chọn cấu hình", "Error", MessageBoxButtons.OK);
			cbbGraphic.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(txtSizeW.Text))
		{
			MessageBox.Show("Chưa nhập chiều ngang", "Error", MessageBoxButtons.OK);
			txtSizeW.Focus();
			return false;
		}
		if (string.IsNullOrEmpty(txtSizeH.Text))
		{
			MessageBox.Show("Chưa nhập chiều dọc", "Error", MessageBoxButtons.OK);
			txtSizeH.Focus();
			return false;
		}
		return true;
	}
	public static void CloseAll()
	{
		//if (MessageBox.Show("Muốn chắc chắn muốn thoát tài khoản ?", "Chắc chưa ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
		//{
		//	return;
		//}
		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

		foreach (var account in accounts)
		{
			if (account.process?.HasExited == false)
			{
				account.process.Kill();
			}
		}
	}
	public static void ListServer(ComboBox comboBoxHost, ComboBox comboBoxServer)
    {
		comboBoxServer.Items.Clear();
		string hostSelected = comboBoxHost.Text.Trim().ToLower();
		int index = servers.FindIndex(server => server.host.ToLower() == hostSelected);
		if (index != -1)
			foreach(var server in servers[index].listServer)
            {
				comboBoxServer.Items.Add(server.serverName);
			}
    }
	private static async Task OpenGameAsync(Account account)
	{
		if(!File.Exists($"{GamePath}\\{account.version}\\Dragonboy_vn_v{account.version}.exe"))
		{
			MessageBox.Show("File game không tồn tại!!!", "Warning", MessageBoxButtons.OK);
			return;
		}

		account.status = "Đang khởi động...";

		SocketServer.waitingAccounts.Add(account);

		account.process = Process.Start($"{GamePath}\\{account.version}\\Dragonboy_vn_v{account.version}.exe" ,$"--port {PortListener}");
		Utilities.RefreshAccounts(account);

		while (account.process.MainWindowHandle == IntPtr.Zero)
		{
			await Task.Delay(50);
		}

		Utilities.SetWindowText(
			hWnd: account.process.MainWindowHandle,
			text: $"ID: {account.id}");

		Utilities.GetWindowRect(account.process.MainWindowHandle, out RECT rect);
		int width = rect.right - rect.left;
		int height = rect.bottom - rect.top;
		Utilities.MoveWindow(
			hWnd: account.process.MainWindowHandle,
			x: (int)(maxWidth / 2) - width / 2,
			y: (int)(maxHeight / 2) - height / 2,
			width, height, true
		);
	}
	private static async Task OpenGamesAsync(List<Account> accounts)
	{
		foreach (var account in accounts)
		{
			if (account.process == null || account.process.HasExited)
				await OpenGameAsync(account);
		}
	}
	public static bool ExistedWindow(Account account, out IntPtr hWnd)
	{
		hWnd = IntPtr.Zero;
		if (account.process == null || account.process.HasExited)
		{
			return false;
		}
		hWnd = account.process.MainWindowHandle;
		return hWnd != IntPtr.Zero;
	}
	public static async Task ShowWindowsAsync()
	{
		var accounts = Utilities.GetMainWindow().GetAccounts();
		foreach (var account in accounts)
		{
			if (ExistedWindow(account, out IntPtr hWnd))
			{
				Utilities.ShowWindowAsync(hWnd, 1);
				Utilities.SetForegroundWindow(hWnd);
			}
		}
		await Task.Delay(1000);
	}
	public static void ArrangeWindows()
	{
		var accounts = Utilities.GetMainWindow().GetAccounts();

		int cx = 0, cy = 0;

		for (int i = 0; i < accounts.Count; i++)
		{
			if (!ExistedWindow(accounts[i], out IntPtr hWnd))
				continue;

			if (!Utilities.GetWindowRect(hWnd, out RECT rect))
				continue;

			int width = rect.right - rect.left;
			int height = rect.bottom - rect.top;

			Utilities.MoveWindow(hWnd, cx, cy, width, height, true);

			cx += width / 2;
			if (cx + (width / 2) > maxWidth)
			{
				cx = 0;
				cy += height - 5;
			}
			if (cy + height > maxHeight)
			{
				cy = 0;
			}
		}
	}
	public static void ShowGameWindowOrLogin()
    {
		var account = Utilities.GetMainWindow().GetSelectedAccount();
		if(account == null)
        {
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}
		if (ExistedWindow(account, out IntPtr hWnd))
		{
			// Hiển thị cửa sổ
			Utilities.ShowWindowAsync(hWnd, 1);
			Utilities.SetForegroundWindow(hWnd);
			Thread.Sleep(50);

			Utilities.GetWindowRect(hWnd, out RECT rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            Utilities.MoveWindow(hWnd,
						x: (int)(maxWidth / 2) - width / 2,
						y: (int)(maxHeight / 2) - height / 2,
				width, height, true);
        }
		else
        {
			Login();
		}
	}
	public static int GetKeyCode(Button button)
	{
        var keyCode = button.Name switch
        {
            "BtnSkill1" => 49,
			"BtnSkill2" => 50,
			"BtnSkill3" => 51,
			"BtnSkill4" => 52,
			"BtnSkill5" => 53,
			"BtnSkill6" => 54,
			"BtnSkill7" => 55,
			"BtnSkill8" => 56,
			"BtnLoadLeft" => 106,
			"BtnLoadMid" => 107,
			"BtnLoadRight" => 108,
			_ => ((string)button.Name)[0],
        };
        return keyCode;
	}
	public static int GetKeyCode(KeyEventArgs e)
	{
		int keyCode;
		switch (e.KeyCode)
		{
			case Keys.Up:
				keyCode = -1;
				break;
			case Keys.Down:
				keyCode = -2;
				break;
			case Keys.Left:
				keyCode = -3;
				break;
			case Keys.Right:
				keyCode = -4;
				break;
			case Keys.Enter:
				keyCode = -5;
				break;
			case Keys.F1:
				keyCode = -21;
				break;
			case Keys.F2:
				keyCode = -22;
				break;
			case Keys.Tab:
				keyCode = -26;
				break;
			case Keys.Space:
				keyCode = 32;
				break;
			default:
				keyCode = (int)e.KeyCode;
				if (keyCode >= 65 && keyCode <= 90)
					keyCode += 32;
				break;
		}
		return keyCode;
	}
	public static void SendChat(string content)
    {
		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

		foreach (var account in accounts)
		{
			if (account.workSocket?.Connected == true)
			{
				SocketServer.sendMessage(account, new
				{
					action = "chat",
					text = content
				});
			}
		}
	}
	public static void PreviewMouseLeftDown(Button btn)
	{
		int keyCode = GetKeyCode(btn);

		if (keyCode == 0)
			return;

		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

		foreach (var account in accounts)
		{
			if (account.workSocket?.Connected == true)
			{
				SocketServer.sendMessage(account, new
				{
					action = "keyPress",
					keyCode
				});
			}
		}
	}
	public static void PreviewMouseLeftUp(Button btn)
	{
		int keyCode = GetKeyCode(btn);

		if (keyCode == 0)
			return;

		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

		foreach (var account in accounts)
		{
			if (account.workSocket?.Connected == true)
			{
				SocketServer.sendMessage(account, new
				{
					action = "keyRelease",
					keyCode
				});
			}
		}
	}
	public static void PreviewKeyDown(KeyEventArgs e)
	{
		int keyCode = GetKeyCode(e);
		e.Handled = true;

		if (keyCode == 0)
			return;

		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

        foreach (var account in accounts)
        {
            if (account.workSocket?.Connected == true)
            {
                SocketServer.sendMessage(account, new
                {
                    action = "keyPress",
                    keyCode
                });
            }
        }
    }
	public static void PreviewKeyUp(KeyEventArgs e)
	{
		int keyCode = GetKeyCode(e);
		e.Handled = true;

		if (keyCode == 0)
			return;

		var accounts = Utilities.GetMainWindow().GetSelectedAccounts();
		if (accounts.Count() == 0)
		{
			MessageBox.Show("Vui lòng chọn tài khoản");
			return;
		}

        foreach (var account in accounts)
        {
            if (account.workSocket?.Connected == true)
            {
                SocketServer.sendMessage(account, new
                {
                    action = "keyRelease",
                    keyCode
                });
            }
        }
    }
	public static void ActionButtonClick(Button btn)
    {
        if (btn.Name == "BtnChat")
		{
			SendChat($"/{QLTK.textBoxChat.Text}");

            return;
		}
		if (btn.Name == "BtnChat2")
		{
			SendChat($"/{QLTK.textBoxChat2.Text}");
			return;
		}
		if (btn.Name == "BtnChangeArea")
		{
			SendChat($"/k{QLTK.textBoxKhu.Text}");
			return;
		}
		if (btn.Name.StartsWith("BtnArea"))
		{
			string khu = btn.Name.Replace("BtnArea", "");
            SendChat($"/k{khu}");
			return;
		}
		if (btn.Name == "BtnLoadSkill")
		{
			SendChat($"/8sk");
			return;
		}
        if (btn.Name == "BtnCN")
        {
            SendChat($"/ucn");
            return;
        }
        if (btn.Name == "BtnCN2")
        {
            SendChat($"/ucn2");
            return;
        }
        if (btn.Name == "BtnBH")
		{
			SendChat($"/ubh");
			return;
		}
		if (btn.Name == "BtnBH2")
		{
			SendChat($"/ubh2");
			return;
		}
		if (btn.Name == "BtnMacGLT")
		{
			SendChat($"/macglt");
			return;
		}
		if (btn.Name == "BtnTeleToFocus")
		{
			SendChat($"/tlfocus");
			return;
		}
		if (btn.Name == "BtnThaoGLT")
		{
			SendChat($"/thaoglt");
			return;
		}
		if (btn.Name == "BtnGoHome")
		{
			SendChat($"/home");
			return;
		}
		if (btn.Name == "BtnResetSB")
		{
            ResetFileSB();
			return;
		}
        if (btn.Name == "BtnBanhChung")
        {
            SendChat($"/ubanhchung");
            return;
        }
    }

	private static void ResetFileSB()
	{
        if (File.Exists("Data\\zones"))
            File.Delete("Data\\zones");
        if (File.Exists("Data\\bossZone"))
            File.Delete("Data\\bossZone");
        if (File.Exists("Data\\numCli"))
            File.Delete("Data\\numCli");
    }

    public static string getMoneys(long m)
    {
        string text = string.Empty;
        long num = m / 1000 + 1;
        for (int i = 0; i < num; i++)
        {
            if (m >= 1000)
            {
                long num2 = m % 1000;
                text = ((num2 != 0) ? ((num2 >= 10) ? ((num2 >= 100) ? ("." + num2 + text) : (".0" + num2 + text)) : (".00" + num2 + text)) : (".000" + text));
                m /= 1000;
                continue;
            }
            text = m + text;
            break;
        }
        return text;
    }
}

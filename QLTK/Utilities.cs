using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLTK;

public class Utilities
{
    public static void UpdateStatus(Account account, string status)
    {
        account.status = status;
        RefreshAccounts(account);
    }

    public static void RefreshAccounts(Account account)
    {
        GetMainWindow().Invoke(() =>
        {
            Controllers.RefreshListAccounts(account);
            GetMainWindow().RefreshAccounts();
        });
    }

    public static QLTK GetMainWindow()
    {
        return QLTK.qltk;
    }

    #region winAPI
    [DllImport("user32.dll")]
    public static extern int SetWindowText(IntPtr hWnd, string text);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool bRepaint);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
    #endregion
    #region Encrypt
    public static string EncryptString(string data)
    {
        TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
        {
            KeySize = 128,
            BlockSize = 64,
            Padding = PaddingMode.PKCS7,
            Mode = CipherMode.CBC,
            Key = Key,
            IV = IV
        };
        ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
        byte[] bytes = Encoding.UTF8.GetBytes(data);
        return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
    }

    public static string DecryptString(string data)
    {
        TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
        {
            KeySize = 128,
            BlockSize = 64,
            Padding = PaddingMode.PKCS7,
            Mode = CipherMode.CBC,
            Key = Key,
            IV = IV
        };
        ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor(tripleDESCryptoServiceProvider.Key, tripleDESCryptoServiceProvider.IV);
        byte[] array = Convert.FromBase64String(data);
        return Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
    }

    static byte[] Key
    {
        get
        {
            return new MD5CryptoServiceProvider()
                .ComputeHash(Encoding.UTF8.GetBytes("vkAJK1dLzbXoAo2B48XxPWkI5jeLRNpoSjZ5ywb1OgSZc3/UsN/FBaqJVSUgBngPDUvA="));
        }
    }

    static byte[] IV
    {
        get
        {
            byte[] bytes = new byte[8];
            byte[] bytes1 = new MD5CryptoServiceProvider().ComputeHash(
                Encoding.UTF8.GetBytes("PMgOCGyT8SfxjRJ3r7Ek9W92NVyp00hOwRrr44jmlxwCFupmMBYaw772ETXV0+ONTPE="));
            for (int i = 0; i < bytes1.Length; i++) bytes1[i] ^= 113;
            Random random = new Random(BitConverter.ToInt32(bytes1, 0));
            random.NextBytes(bytes);
            return bytes;
        }
    }
    #endregion
    public static string Base64StringEncode(string originalString)
    {
        var bytes = Encoding.UTF8.GetBytes(originalString);

        var encodedString = Convert.ToBase64String(bytes);

        return encodedString;
    }

    public static string Base64StringDecode(string encodedString)
    {
        var bytes = Convert.FromBase64String(encodedString);

        var decodedString = Encoding.UTF8.GetString(bytes);

        return decodedString;
    }
}

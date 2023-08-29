using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Data;
using System.Windows.Forms;

namespace QLTK;

public partial class InfoChar : Form
{
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;
    public Account accountSelected = QLTK.qltk.GetSelectedAccount();
    public InfoChar()
    {
        InitializeComponent();
        AddEventMouseDownForAllControl();
        LoadInfo();
    }
    private void InfoChar_Load(object sender, EventArgs e)
    {
        //LoadInfo();
    }
    public void LoadInfo()
    {
        RefreshDataBindings();
        BindingData(lbID, "ID:", "charID");
        BindingData(lbTK, "TK:", "username");
        BindingData(lbServer, "Server:", "server");
        BindingData(lbVersion, "Version:", "version");

        BindingData(lbMap, "Map:", "mapName", "mapID", "", false);
        BindingData(lbKhu, "Khu:", "zoneID");
        BindingData(lbToaDo, "Toạ độ:", "cx", "cy", " - ", false);

        BindingData(lbNameSP, "SP:", "cName");
        BindingData(lbPLanetSP, "Hành tinh:", "planet");
        BindingData(lbPowerSP, "Sức mạnh:", "cPower");
        BindingData(lbTNSP, "Tiềm năng:", "cTiemNang");
        BindingData(lbHPSP, "HP:", "cHP", "cHPFull", "/", true);
        BindingData(lbMPSP, "MP:", "cMP", "cMPFull", "/", true);
        BindingData(lbSDSP, "SĐ:", "cDamFull");
        BindingData(lbGiapSP, "Giáp:", "cDefull");
        BindingData(lbCritSP, "CM:", "cCriticalFull");
        BindingData(lbStaminaSP, "TL:", "cStamina", "cMaxStamina", "/", true);

        BindingData(lbNamePet, "ĐT:", "cPetName");
        BindingData(lbPLanetDT, "Hành tinh:", "petPlanet");
        BindingData(lbPowerDT, "Sức mạnh:", "cPetPower");
        BindingData(lbTNDT, "Tiềm năng:", "cPetTiemNang");
        BindingData(lbHPDT, "HP:", "cPetHP", "cPetHPFull", "/", true);
        BindingData(lbMPDT, "MP:", "cPetMP", "cPetMPFull", "/", true);
        BindingData(lbSDDT, "SĐ:", "cPetDamFull");
        BindingData(lbGiapDT, "Giáp:", "cPetDefull");
        BindingData(lbCritDT, "CM:", "cPetCriticalFull");
        BindingData(lbStaminaDT, "TL:", "cPetStamina", "cPetMaxStamina", "/", true);
        BindingData(lbStatusDT, "TT:", "petStatus");

        BindingData(lbXu, "Vàng:", "xu");
        BindingData(lbLuong, "Ngọc xanh:", "luong");
        BindingData(lbLuongKhoa, "Ngọc hồng:", "luongKhoa");
    }
    public void BindingData(Control control, string text, string val)
    {
        control.DataBindings.Add("Text", accountSelected, val);
        control.DataBindings["Text"].Format += (sender, e) =>
        {
            if(long.TryParse(e.Value.ToString(), out long res) && !text.ToLower().Contains("id"))
                e.Value = $"{text} {Controllers.getMoneys(res)}";
            else
                e.Value = $"{text} {e.Value}";
        };
        control.DataBindings["Text"].ReadValue();
    }
    public void BindingData(Control control, string text, string val1, string val2, string delimiter, bool isHavePercent)
    {
        control.DataBindings.Add("Text", accountSelected, val1);
        control.DataBindings["Text"].Format += (sender, e) =>
        {
            var value = accountSelected.GetType().GetProperty(val1).GetValue(accountSelected);
            var value1 = accountSelected.GetType().GetProperty(val2).GetValue(accountSelected);
            if(isHavePercent)
            {
                var percent = Math.Round(float.Parse(value.ToString()) / float.Parse(value1.ToString()) * 100f);
                e.Value = $"{text} {Controllers.getMoneys(int.Parse(value.ToString()))}{delimiter}{Controllers.getMoneys(int.Parse(value1.ToString()))} ({percent}%)";
            }
            else
            {
                if(text.ToLower().Contains("toạ độ"))
                {
                    e.Value = $"{text} X: {value}{delimiter}Y: {value1}";
                }
                if (text.ToLower().Contains("map"))
                {
                    e.Value = $"{text} {value} [{value1}]";
                }
            }
        };
        control.DataBindings["Text"].ReadValue();
    }
    public void RefreshDataBindings()
    {
        foreach (var label in QLTK.qltk.GetAllControlFromType(this, typeof(Label)))
            label.DataBindings.Clear();
    }
    public void SetSelectAccount(Account account)
    {
        accountSelected = account;
    }
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public void AddEventMouseDownForAllControl()
    {
        try
        {
            foreach (Control ctrl in QLTK.qltk.GetAllControl(this))
                if (!QLTK.qltk.HasEventHandler(ctrl, "EventClick"))
                    ctrl.MouseDown += MouseDownEvent;
        }
        catch (Exception ex)
        {
            Controllers.writeLog(ex.ToString());
        }
    }
    private void MouseDownEvent(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
    private void InfoChar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}

public class MyMultiValueConverter : System.Windows.Data.IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        return values != null ? values[0] + "/" + values[1] : "--/--";
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
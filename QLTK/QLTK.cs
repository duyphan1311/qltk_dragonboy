using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace QLTK;

public partial class QLTK : Form
{
    public static QLTK qltk;
    public static DataGridView dataGridView;
    public static TextBox textBoxChat;
    public static TextBox textBoxKhu;
    public static TextBox textBoxChat2;
    public InfoChar infoChar;
    public QLTK()
    {
        InitializeComponent();
        new Thread(() => SocketServer.StartListening())
        {
            IsBackground = true
        }.Start();
        qltk = this;
        dataGridView = DgvAccount;
        textBoxChat = txtChatContent;
        textBoxKhu = txtArea;
        textBoxChat2 = txtChat2;
        Controllers.LoadFileListAccount();
    }
    public void RefreshAccounts()
    {
        int selectedRowCount = DgvAccount.SelectedRows.Count;
        List<int> list = new();
        if (selectedRowCount > 0)
        {
            foreach (DataGridViewRow selectedRow in DgvAccount.SelectedRows)
            {
                list.Add(selectedRow.Index);
            }
        }
        Controllers.LoadAccountToDataGridView(DgvAccount, DataAccount);
        DgvAccount.Rows[0].Selected = false;
        if (selectedRowCount > 0)
        {
            foreach (var idx in list)
            {
                if(DgvAccount.Rows.Count > idx)
                if(DgvAccount.Rows.Count > idx)
                    DgvAccount.Rows[idx].Selected = true;
            }
        }
    }
    public List<Account> GetAccounts()
        => Controllers.GetListAccounts();
    public List<Account> GetSelectedAccounts()
    {
        List<Account> accounts = new();
        for (int i = 0; i < DgvAccount.Rows.GetRowCount(DataGridViewElementStates.Selected); i++)
        {
            var cell = DgvAccount.Rows[DgvAccount.SelectedRows[i].Index].Cells;
            foreach (var account in Controllers.accounts)
            {
                if (account.id == int.Parse(cell[0].Value.ToString()))
                    accounts.Add(account);
            }
        }
        return accounts;
    }
    public Account GetSelectedAccount()
    {
        for (int i = 0; i < DgvAccount.Rows.GetRowCount(DataGridViewElementStates.Selected); i++)
        {
            var cell = DgvAccount.Rows[DgvAccount.SelectedRows[i].Index].Cells;
            foreach (var account in Controllers.accounts)
            {
                if (account.id == int.Parse(cell[0].Value.ToString()))
                    return account;
            }
        }
        return null;
    }
    public Account GetInputAccount() => new Account()
    {
        id = DgvAccount.RowCount + 1,
        username = txtUsername.Text,
        password = txtPass.Text,
        host = CbbHost.Text,
        server = CbbServer.Text,
        graphic = CbbGraphic.Text,
        size = txtW.Text + "x" + txtH.Text,
        version = int.Parse(cbbVerSel.Text),
        note = textBox1.Text
    };
    private void QLTK_Load(object sender, System.EventArgs e)
    {
        Controllers.LoadFileListAccount();
        Controllers.LoadListServer();
        Controllers.GetGameVersion();
        Controllers.ExistFile(Controllers.FileErrorPath);
        Controllers.LoadAccountToDataGridView(DgvAccount, DataAccount);
        Controllers.LoadComboboxHost(CbbHost);
        Controllers.LoadComboboxHost(cbbHostSel);
        Controllers.LoadComboboxHost(cbbHostDel);
        Controllers.SetGameVersion(cbbVerDel);
        Controllers.SetGameVersion(cbbVerSel);
        checkBoxHide.Checked = true;
        KeyPreview = true;
        CbbHost.SelectedItem = null;
        CbbHost.SelectedText = "-- Select --";
        CbbGraphic.SelectedItem = null;
        CbbGraphic.SelectedText = "-- Select --";
        CbbServer.SelectedItem = null;
        CbbServer.SelectedText = "-- Select --";
        cbbVerSel.SelectedItem = null;
        cbbVerSel.SelectedText = "-- Select --";
        txtW.Text = "1024";
        txtH.Text = "600";
        AddEventForButton();
        foreach (Control ctrl in GetAllControl(this))
            ctrl.TabStop = false;
    }
    private void AddEventForButton()
    {
        try
        {
            foreach (var button in GetAllControlFromType(this, typeof(Button)))
                if (!HasEventHandler(button, "EventClick"))
                {
                    if (button.Name.StartsWith("BtnSkill")
                        || button.Name == "BtnLoadLeft"
                        || button.Name == "BtnLoadMid"
                        || button.Name == "BtnLoadRight"
                    )
                    {
                        button.MouseDown += Button_MouseDown;
                        button.MouseUp += Button_MouseUp;
                    }
                    else
                    {
                        button.Click += Button_Click;
                    }
                }
        }
        catch (Exception ex)
        {
            Controllers.writeLog(ex.ToString());
        }
    }
    public IEnumerable<Control> GetAllControlFromType(Control control, Type type)
    {
        var controls = control.Controls.Cast<Control>();
        return controls.SelectMany(ctrl => GetAllControlFromType(ctrl, type))
                                  .Concat(controls)
                                  .Where(c => c.GetType() == type);
    }
    public IEnumerable<Control> GetAllControl(Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls.SelectMany(ctrl => GetAllControl(ctrl))
                                  .Concat(controls);
    }
    private void Button_Click(object sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        Controllers.ActionButtonClick(button);
        DgvAccount.Focus();
    }
    private void Button_MouseDown(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;

        if (e.Button == MouseButtons.Left)
            Controllers.PreviewMouseLeftDown(button);

        DgvAccount.Focus();
    }
    private void Button_MouseUp(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;

        if (e.Button == MouseButtons.Left)
            Controllers.PreviewMouseLeftUp(button);

        DgvAccount.Focus();
    }
    public bool HasEventHandler(Control control, string eventName)
    {
        EventHandlerList events =
            (EventHandlerList)
            typeof(Component)
             .GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance)
             .GetValue(control, null);

        object key = typeof(Control)
            .GetField(eventName, BindingFlags.NonPublic | BindingFlags.Static)
            .GetValue(null);

        Delegate handlers = events[key];

        return handlers != null && handlers.GetInvocationList().Any();
    }
    private void DgvAccount_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.R)
        {
            txtChatContent.Focus();
            txtChatContent.SelectAll();
            return;
        }
        Controllers.PreviewKeyDown(e);
    }
    private void DgvAccount_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.R)
        {
            txtChatContent.Focus();
            txtChatContent.SelectAll();
            return;
        }
        Controllers.PreviewKeyUp(e);
    }
    private void BtnAsync_Click(object sender, System.EventArgs e)
    {

        Invoke(() => Controllers.LoadListServer());
        Controllers.LoadComboboxHost(CbbHost);
    }
    private void TsmiSelectAll_Click(object sender, System.EventArgs e)
    {
        DgvAccount.SelectAll();
    }
    private void TsmiLogin_Click(object sender, System.EventArgs e)
    {
        try
        {
            Controllers.Login();
        }
        catch
        {
            MessageBox.Show($"Vui lòng chon tài khoản!", "Lỗi");
        }
    }
    private async void TsmiSort_Click(object sender, System.EventArgs e)
    {
        await Controllers.ShowWindowsAsync();
        Controllers.ArrangeWindows();
    }
    private void TsmiClose_Click(object sender, System.EventArgs e)
    {
        Controllers.CloseAll();
    }
    private void checkBoxHide_CheckedChanged(object sender, System.EventArgs e)
    {
        if (checkBoxHide.Checked)
        {
            txtPass.PasswordChar = '*';
        }
        else
        {
            txtPass.PasswordChar = '\0';
        }
    }
    private void CbbHost_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        Controllers.ListServer(CbbHost, CbbServer);
        CbbServer.SelectedIndex = 0;
    }
    private void BtnAdd_Click(object sender, System.EventArgs e)
    {
        try
        {
            if (Controllers.CheckAdd(txtUsername, txtPass, CbbHost, CbbServer, CbbGraphic, txtW, txtH))
            {
                Controllers.accounts.Add(GetInputAccount());
                DataAccount.Add(GetInputAccount());
                Controllers.ExportFile(DgvAccount);
            }
        }
        catch (Exception ex)
        {
            Controllers.writeLog(ex.ToString());
        }
    }
    private void BtnEdit_Click(object sender, System.EventArgs e)
    {
        Controllers.EditAccount(txtUsername, txtPass, CbbHost, CbbServer, CbbGraphic, txtW, txtH, cbbVerSel, textBox1);
    }
    private void BtnDelete_Click(object sender, System.EventArgs e)
    {
        if (DgvAccount.CurrentRow.Index >= 0)
            Controllers.Delete();
        else
            MessageBox.Show($"Chưa có tài khoản! Vui lòng chọn tài khoản và thử lại!", "Lỗi", MessageBoxButtons.OK);
    }
    private void DgvAccount_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
            DgvAccount.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 234, 255);
    }
    private void DgvAccount_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
            DgvAccount.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
    }
    private void DgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int index = DgvAccount.CurrentRow.Index;
        txtUsername.Text = DgvAccount.Rows[index].Cells[1].Value.ToString();
        txtPass.Text = DgvAccount.Rows[index].Cells[2].Value.ToString();
        CbbHost.Text = DgvAccount.Rows[index].Cells[3].Value.ToString();
        CbbServer.Text = DgvAccount.Rows[index].Cells[4].Value.ToString();
        CbbGraphic.Text = DgvAccount.Rows[index].Cells[5].Value.ToString();
        string[] size = DgvAccount.Rows[index].Cells[6].Value.ToString().Split('x');
        cbbVerSel.Text = DgvAccount.Rows[index].Cells[7].Value.ToString();
        textBox1.Text = DgvAccount.Rows[index].Cells[8].Value.ToString();
        txtW.Text = size[0].ToString();
        txtH.Text = size[1].ToString();
        if(checkBox1.Checked)
        {
            if (Application.OpenForms.OfType<InfoChar>().Any())
            {
                Application.OpenForms.OfType<InfoChar>().First().BringToFront();
                Application.OpenForms.OfType<InfoChar>().First().Refresh();
                Application.OpenForms.OfType<InfoChar>().First().SetSelectAccount(GetSelectedAccount());
                Application.OpenForms.OfType<InfoChar>().First().LoadInfo();
            }
            else
            {
                InfoChar f = new();
                f.SetSelectAccount(GetSelectedAccount());
                f.Location = new Point(this.Left - f.Width + 7, this.Top);
                f.Show();
            }
        }
    }
    private void DgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            Controllers.ShowGameWindowOrLogin();
        }
        catch
        {
            MessageBox.Show($"Vui lòng chon tài khoản!", "Lỗi");
        }
    }
    private void Timer_Tick(object sender, System.EventArgs e)
    {

    }
    private void QLTK_FormClosing(object sender, FormClosingEventArgs e)
    {
        int flag = 0;
        foreach (var account in Controllers.accounts)
        {
            if (account.process?.HasExited == false)
            {
                flag++;
            }
        }
        Controllers.ExportFile(DgvAccount);
        if (flag > 0)
        {
            if (MessageBox.Show("Điều này đồng nghĩa với việc tất cả tab game đang hoạt động cũng sẽ bị đóng!", "Bạn có chắc chắn muốn đóng QLTK?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            foreach (var account in Controllers.accounts)
            {
                if (account.process?.HasExited == false)
                {
                    account.process.Kill();
                }
            }
        }
    }
    private void txtUsername_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
        {
            txtPass.Focus();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    private void txtPass_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
        {
            CbbHost.Focus();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    private void CbbHost_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            CbbServer.Focus();
    }
    private void CbbServer_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            txtW.Focus();
    }
    private void txtW_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
        {
            txtH.Focus();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    private void txtH_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
        {
            CbbGraphic.Focus();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    private void CbbGraphic_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            BtnAdd.Focus();
    }
    private void txtArea_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            BtnChangeArea.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
            DgvAccount.Focus();
        }
        if (e.KeyCode == Keys.ControlKey)
            DgvAccount.Focus();
    }
    private void txtTeleID_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            BtnChat2.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
            DgvAccount.Focus();
        }
        if (e.KeyCode == Keys.ControlKey)
            DgvAccount.Focus();
    }
    private void txtChatContent_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            BtnChat.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
            DgvAccount.Focus();
        }
        if (e.KeyCode == Keys.ControlKey)
            DgvAccount.Focus();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(checkBox1.Checked)
        {
            if (!Application.OpenForms.OfType<InfoChar>().Any())
            {
                InfoChar f = new();
                f.SetSelectAccount(GetSelectedAccount());
                f.Location = new Point(this.Left - f.Width + 7, this.Top);
                f.Show();
            }
        }
        else
        {
            if (Application.OpenForms.OfType<InfoChar>().Any())
            {
                Application.OpenForms.OfType<InfoChar>().First().Close();
            }
        }
    }

    private void btnHostAdd_Click(object sender, EventArgs e)
    {
        if (txtHostAdd.Text != string.Empty)
        {
            List<Server> data = new();
            Controllers.servers.Add(new Host
            {
                host = txtHostAdd.Text.Trim(),
                listServer = data
            });
            Controllers.SaveServer();
            Controllers.LoadListServer();
            Controllers.LoadComboboxHost(CbbHost);
            Controllers.LoadComboboxHost(cbbHostDel);
            Controllers.LoadComboboxHost(cbbHostSel);
            Controllers.ListServer(cbbHostDel, cbbSerDel);
            Controllers.ListServer(CbbHost, CbbServer);
        }
        else
        {
            MessageBox.Show("Bạn chưa nhập host!!!", "Error", MessageBoxButtons.OK);
        }
    }

    private void btnIPSerAdd_Click(object sender, EventArgs e)
    {
        if (txtIPSerAdd.Text != string.Empty)
        {
            string hostSelected = cbbHostSel.Text.Trim().ToLower();
            int indexHost = Controllers.servers.FindIndex(server => server.host.ToLower() == hostSelected);

            if (indexHost != -1)
            {
                string[] array = txtIPSerAdd.Text.Trim().Split(':');
                Controllers.servers[indexHost].listServer.Add(new Server
                {
                    serverName = array[0].Trim(),
                    ip = array[1].Trim(),
                    port = array[2].Trim()
                });
                Controllers.SaveServer();
                Controllers.LoadListServer();
                Controllers.LoadComboboxHost(CbbHost);
                Controllers.LoadComboboxHost(cbbHostDel);
                Controllers.LoadComboboxHost(cbbHostSel);
                Controllers.ListServer(cbbHostDel, cbbSerDel);
                Controllers.ListServer(CbbHost, CbbServer);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn host để xoá!!!", "Error", MessageBoxButtons.OK);
            }
        }
        else
        {
            MessageBox.Show("Bạn chưa nhập host!!!", "Error", MessageBoxButtons.OK);
        }
    }

    private void btnVerDel_Click(object sender, EventArgs e)
    {
        Controllers.DeleteVersion(cbbVerDel);
        Controllers.GetGameVersion();
        Controllers.SetGameVersion(cbbVerSel);
        Controllers.SetGameVersion(cbbVerDel);
        cbbVerDel.SelectedIndex = 0;
    }

    private void btnAddVer_Click(object sender, EventArgs e)
    {
        if(txtVerAdd.Text != string.Empty)
        {
            if (int.TryParse(txtVerAdd.Text, out int res))
            {
                Controllers.versions.Add(txtVerAdd.Text);
                Controllers.SaveVersion();
                Controllers.GetGameVersion();
                Controllers.SetGameVersion(cbbVerSel);
                Controllers.SetGameVersion(cbbVerDel);
            }
            else
            {
                MessageBox.Show("Version game phải là số nguyên!!!", "Error", MessageBoxButtons.OK);
            }
        }
        else
        {
            MessageBox.Show("Bạn chưa nhập version của game!!!", "Error", MessageBoxButtons.OK);
        }
    }

    private void btnSerDel_Click(object sender, EventArgs e)
    {
        Controllers.DeleteServer(cbbHostDel, cbbSerDel);
        Controllers.SaveServer();
        Controllers.LoadListServer();
        Controllers.LoadComboboxHost(CbbHost);
        Controllers.LoadComboboxHost(cbbHostDel);
        Controllers.LoadComboboxHost(cbbHostSel);
        Controllers.ListServer(cbbHostDel, cbbSerDel);
        Controllers.ListServer(CbbHost, CbbServer);
    }

    private void cbbHostDel_SelectedIndexChanged(object sender, EventArgs e)
    {
        Controllers.ListServer(cbbHostDel, cbbSerDel);
    }

    private void btnDelData_Click(object sender, EventArgs e)
    {
        var account = GetSelectedAccount();

        int idx = Controllers.servers.FindIndex(server => server.host.Trim().ToLower() == account.host.Trim().ToLower());
        Host svr = Controllers.servers[idx];

        int serverIndex = svr.listServer.FindIndex(sv => sv.serverName.ToLower() == account.server.ToLower());

        if (MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {svr.listServer[serverIndex].serverName} ?", "Chắc chưa ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            return;

        string ip = svr.listServer[serverIndex].ip;
        string port = svr.listServer[serverIndex].port;
        int zoomLevel = account.graphic.ToString().ToLower() == "cao" ? 2 : 1;

        string path = $"{Path.GetTempPath()}\\DragonboyByDuyPhan\\{account.version}\\" +
            $"{ip}_{port}_x{zoomLevel}\\";
        if (!Directory.Exists(path))
        {
            MessageBox.Show($"Không tồn tại đường dẫn {path}!!!", "Warnning", MessageBoxButtons.OK);
            return;
        }

        FileInfo[] files = new DirectoryInfo(path + "/").GetFiles();
        foreach (FileInfo fileInfo in files)
            if (fileInfo.Name != "isPlaySound")
                fileInfo.Delete();

    }
}

using System.ComponentModel;
using System.Windows.Forms;

namespace QLTK;

partial class QLTK
{
    public static string key;
    private TabControl TabControlMain;
    private TabPage TabPageAccount;
    private Label LbUsername;
    private TextBox txtUsername;
    private Label LbPass;
    private CheckBox checkBoxHide;
    private ComboBox CbbServer;
    private Label LbServer;
    private Button BtnAdd;
    private Button BtnEdit;
    private Button BtnDelete;
    private TabPage TabPageSettings;
    private IContainer components;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTK));
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageAccount = new System.Windows.Forms.TabPage();
            this.PnlDGV = new System.Windows.Forms.Panel();
            this.DgvAccount = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHPFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaxStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTiemNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHPGocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPGocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDefGocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCriticalGocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDamFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDefullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCriticalFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetHPFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetMPFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetDamFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetDefullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetCriticalFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetMaxStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPetTiemNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAccount = new System.Windows.Forms.BindingSource(this.components);
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.GrboxInfo = new System.Windows.Forms.GroupBox();
            this.TpnlInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbInfoCharShow = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbVerSel = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.LbGraphic = new System.Windows.Forms.Label();
            this.LbSize = new System.Windows.Forms.Label();
            this.LbHost = new System.Windows.Forms.Label();
            this.CbbServer = new System.Windows.Forms.ComboBox();
            this.LbServer = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbPass = new System.Windows.Forms.Label();
            this.TpnlBtnInfo = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelData = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TpnlPass = new System.Windows.Forms.TableLayoutPanel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.TpnlSize = new System.Windows.Forms.TableLayoutPanel();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.LbX = new System.Windows.Forms.Label();
            this.CbbHost = new System.Windows.Forms.ComboBox();
            this.CbbGraphic = new System.Windows.Forms.ComboBox();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.GrboxControl = new System.Windows.Forms.GroupBox();
            this.TpnlControl = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMacGLT = new System.Windows.Forms.Button();
            this.BtnGoHome = new System.Windows.Forms.Button();
            this.BtnResetSB = new System.Windows.Forms.Button();
            this.BtnThaoGLT = new System.Windows.Forms.Button();
            this.BtnBanhChung = new System.Windows.Forms.Button();
            this.BtnBH2 = new System.Windows.Forms.Button();
            this.BtnBH = new System.Windows.Forms.Button();
            this.BtnCN2 = new System.Windows.Forms.Button();
            this.BtnCN = new System.Windows.Forms.Button();
            this.GrboxArea = new System.Windows.Forms.GroupBox();
            this.TpnlArea = new System.Windows.Forms.TableLayoutPanel();
            this.BtnArea5 = new System.Windows.Forms.Button();
            this.BtnArea4 = new System.Windows.Forms.Button();
            this.BtnArea3 = new System.Windows.Forms.Button();
            this.BtnArea2 = new System.Windows.Forms.Button();
            this.BtnArea1 = new System.Windows.Forms.Button();
            this.BtnArea0 = new System.Windows.Forms.Button();
            this.TpnlSubArea = new System.Windows.Forms.TableLayoutPanel();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.BtnChangeArea = new System.Windows.Forms.Button();
            this.GrbDieuKhien = new System.Windows.Forms.GroupBox();
            this.TpnlDieuKhien = new System.Windows.Forms.TableLayoutPanel();
            this.txtChat2 = new System.Windows.Forms.TextBox();
            this.txtChatContent = new System.Windows.Forms.TextBox();
            this.BtnChat2 = new System.Windows.Forms.Button();
            this.BtnChat = new System.Windows.Forms.Button();
            this.TpnlSubDieuKhien = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLoadRight = new System.Windows.Forms.Button();
            this.BtnLoadMid = new System.Windows.Forms.Button();
            this.BtnLoadLeft = new System.Windows.Forms.Button();
            this.TabPageSettings = new System.Windows.Forms.TabPage();
            this.PnlSetting = new System.Windows.Forms.Panel();
            this.TpnlSetting = new System.Windows.Forms.TableLayoutPanel();
            this.GrboxChucNang = new System.Windows.Forms.GroupBox();
            this.GrboxTDLT = new System.Windows.Forms.GroupBox();
            this.GrboxCoDinh = new System.Windows.Forms.GroupBox();
            this.TpnlCoDinh = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIPSerAdd = new System.Windows.Forms.Button();
            this.txtIPSerAdd = new System.Windows.Forms.TextBox();
            this.lbSerAdd = new System.Windows.Forms.Label();
            this.cbbHostSel = new System.Windows.Forms.ComboBox();
            this.lbHostSel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSerDel = new System.Windows.Forms.Button();
            this.lbSerDel = new System.Windows.Forms.Label();
            this.cbbSerDel = new System.Windows.Forms.ComboBox();
            this.cbbHostDel = new System.Windows.Forms.ComboBox();
            this.lbHostDel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHostAdd = new System.Windows.Forms.TextBox();
            this.btnHostAdd = new System.Windows.Forms.Button();
            this.lbHostAdd = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtVerAdd = new System.Windows.Forms.TextBox();
            this.btnAddVer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerDel = new System.Windows.Forms.Button();
            this.cbbVerDel = new System.Windows.Forms.ComboBox();
            this.lbVerDel = new System.Windows.Forms.Label();
            this.GrboxItem = new System.Windows.Forms.GroupBox();
            this.TsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSort = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TabControlMain.SuspendLayout();
            this.TabPageAccount.SuspendLayout();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAccount)).BeginInit();
            this.PnlInfo.SuspendLayout();
            this.GrboxInfo.SuspendLayout();
            this.TpnlInfo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TpnlBtnInfo.SuspendLayout();
            this.TpnlPass.SuspendLayout();
            this.TpnlSize.SuspendLayout();
            this.PnlControl.SuspendLayout();
            this.GrboxControl.SuspendLayout();
            this.TpnlControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.GrboxArea.SuspendLayout();
            this.TpnlArea.SuspendLayout();
            this.TpnlSubArea.SuspendLayout();
            this.GrbDieuKhien.SuspendLayout();
            this.TpnlDieuKhien.SuspendLayout();
            this.TpnlSubDieuKhien.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            this.PnlSetting.SuspendLayout();
            this.TpnlSetting.SuspendLayout();
            this.GrboxCoDinh.SuspendLayout();
            this.TpnlCoDinh.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageAccount);
            this.TabControlMain.Controls.Add(this.TabPageSettings);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.Padding = new System.Drawing.Point(20, 6);
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(884, 561);
            this.TabControlMain.TabIndex = 2;
            // 
            // TabPageAccount
            // 
            this.TabPageAccount.Controls.Add(this.PnlDGV);
            this.TabPageAccount.Controls.Add(this.PnlInfo);
            this.TabPageAccount.Controls.Add(this.PnlControl);
            this.TabPageAccount.Location = new System.Drawing.Point(4, 31);
            this.TabPageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageAccount.Name = "TabPageAccount";
            this.TabPageAccount.Padding = new System.Windows.Forms.Padding(5);
            this.TabPageAccount.Size = new System.Drawing.Size(876, 526);
            this.TabPageAccount.TabIndex = 0;
            this.TabPageAccount.Text = "Account";
            this.TabPageAccount.UseVisualStyleBackColor = true;
            // 
            // PnlDGV
            // 
            this.PnlDGV.Controls.Add(this.DgvAccount);
            this.PnlDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDGV.Location = new System.Drawing.Point(5, 5);
            this.PnlDGV.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PnlDGV.Size = new System.Drawing.Size(646, 316);
            this.PnlDGV.TabIndex = 20;
            // 
            // DgvAccount
            // 
            this.DgvAccount.AllowUserToAddRows = false;
            this.DgvAccount.AllowUserToDeleteRows = false;
            this.DgvAccount.AllowUserToResizeColumns = false;
            this.DgvAccount.AllowUserToResizeRows = false;
            this.DgvAccount.AutoGenerateColumns = false;
            this.DgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.DgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAccount.ColumnHeadersHeight = 25;
            this.DgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.serverDataGridViewTextBoxColumn,
            this.graphicDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.charIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cgenderDataGridViewTextBoxColumn,
            this.mapNameDataGridViewTextBoxColumn,
            this.mapIDDataGridViewTextBoxColumn,
            this.zoneIDDataGridViewTextBoxColumn,
            this.cxDataGridViewTextBoxColumn,
            this.cyDataGridViewTextBoxColumn,
            this.cHPDataGridViewTextBoxColumn,
            this.cHPFullDataGridViewTextBoxColumn,
            this.cMPDataGridViewTextBoxColumn,
            this.cMPFullDataGridViewTextBoxColumn,
            this.cStaminaDataGridViewTextBoxColumn,
            this.cMaxStaminaDataGridViewTextBoxColumn,
            this.cPowerDataGridViewTextBoxColumn,
            this.cTiemNangDataGridViewTextBoxColumn,
            this.cHPGocDataGridViewTextBoxColumn,
            this.cMPGocDataGridViewTextBoxColumn,
            this.cDefGocDataGridViewTextBoxColumn,
            this.cCriticalGocDataGridViewTextBoxColumn,
            this.cDamFullDataGridViewTextBoxColumn,
            this.cDefullDataGridViewTextBoxColumn,
            this.cCriticalFullDataGridViewTextBoxColumn,
            this.cPetHPDataGridViewTextBoxColumn,
            this.cPetHPFullDataGridViewTextBoxColumn,
            this.cPetMPDataGridViewTextBoxColumn,
            this.cPetMPFullDataGridViewTextBoxColumn,
            this.cPetDamFullDataGridViewTextBoxColumn,
            this.cPetDefullDataGridViewTextBoxColumn,
            this.cPetCriticalFullDataGridViewTextBoxColumn,
            this.cPetStaminaDataGridViewTextBoxColumn,
            this.cPetMaxStaminaDataGridViewTextBoxColumn,
            this.cPetPowerDataGridViewTextBoxColumn,
            this.cPetTiemNangDataGridViewTextBoxColumn,
            this.petStatusDataGridViewTextBoxColumn,
            this.xuDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.luongKhoaDataGridViewTextBoxColumn,
            this.planetDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.DgvAccount.DataSource = this.DataAccount;
            this.DgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAccount.EnableHeadersVisualStyles = false;
            this.DgvAccount.GridColor = System.Drawing.Color.White;
            this.DgvAccount.Location = new System.Drawing.Point(0, 0);
            this.DgvAccount.Margin = new System.Windows.Forms.Padding(0);
            this.DgvAccount.Name = "DgvAccount";
            this.DgvAccount.ReadOnly = true;
            this.DgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvAccount.RowHeadersVisible = false;
            this.DgvAccount.RowHeadersWidth = 30;
            this.DgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAccount.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvAccount.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvAccount.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAccount.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DgvAccount.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.DgvAccount.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DgvAccount.RowTemplate.Height = 30;
            this.DgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccount.Size = new System.Drawing.Size(641, 316);
            this.DgvAccount.TabIndex = 0;
            this.DgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccount_CellClick);
            this.DgvAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccount_CellDoubleClick);
            this.DgvAccount.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccount_CellMouseLeave);
            this.DgvAccount.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAccount_CellMouseMove);
            this.DgvAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvAccount_KeyDown);
            this.DgvAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvAccount_KeyUp);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 85;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostDataGridViewTextBoxColumn.Visible = false;
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "server";
            this.serverDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            this.serverDataGridViewTextBoxColumn.ReadOnly = true;
            this.serverDataGridViewTextBoxColumn.Width = 75;
            // 
            // graphicDataGridViewTextBoxColumn
            // 
            this.graphicDataGridViewTextBoxColumn.DataPropertyName = "graphic";
            this.graphicDataGridViewTextBoxColumn.HeaderText = "Cấu hình";
            this.graphicDataGridViewTextBoxColumn.Name = "graphicDataGridViewTextBoxColumn";
            this.graphicDataGridViewTextBoxColumn.ReadOnly = true;
            this.graphicDataGridViewTextBoxColumn.Width = 75;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 75;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionDataGridViewTextBoxColumn.Width = 75;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 115;
            // 
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "charID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "charID";
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            this.charIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.charIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "cName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cgenderDataGridViewTextBoxColumn
            // 
            this.cgenderDataGridViewTextBoxColumn.DataPropertyName = "cgender";
            this.cgenderDataGridViewTextBoxColumn.HeaderText = "cgender";
            this.cgenderDataGridViewTextBoxColumn.Name = "cgenderDataGridViewTextBoxColumn";
            this.cgenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.cgenderDataGridViewTextBoxColumn.Visible = false;
            // 
            // mapNameDataGridViewTextBoxColumn
            // 
            this.mapNameDataGridViewTextBoxColumn.DataPropertyName = "mapName";
            this.mapNameDataGridViewTextBoxColumn.HeaderText = "mapName";
            this.mapNameDataGridViewTextBoxColumn.Name = "mapNameDataGridViewTextBoxColumn";
            this.mapNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mapNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // mapIDDataGridViewTextBoxColumn
            // 
            this.mapIDDataGridViewTextBoxColumn.DataPropertyName = "mapID";
            this.mapIDDataGridViewTextBoxColumn.HeaderText = "mapID";
            this.mapIDDataGridViewTextBoxColumn.Name = "mapIDDataGridViewTextBoxColumn";
            this.mapIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mapIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // zoneIDDataGridViewTextBoxColumn
            // 
            this.zoneIDDataGridViewTextBoxColumn.DataPropertyName = "zoneID";
            this.zoneIDDataGridViewTextBoxColumn.HeaderText = "zoneID";
            this.zoneIDDataGridViewTextBoxColumn.Name = "zoneIDDataGridViewTextBoxColumn";
            this.zoneIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cxDataGridViewTextBoxColumn
            // 
            this.cxDataGridViewTextBoxColumn.DataPropertyName = "cx";
            this.cxDataGridViewTextBoxColumn.HeaderText = "cx";
            this.cxDataGridViewTextBoxColumn.Name = "cxDataGridViewTextBoxColumn";
            this.cxDataGridViewTextBoxColumn.ReadOnly = true;
            this.cxDataGridViewTextBoxColumn.Visible = false;
            // 
            // cyDataGridViewTextBoxColumn
            // 
            this.cyDataGridViewTextBoxColumn.DataPropertyName = "cy";
            this.cyDataGridViewTextBoxColumn.HeaderText = "cy";
            this.cyDataGridViewTextBoxColumn.Name = "cyDataGridViewTextBoxColumn";
            this.cyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cyDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHPDataGridViewTextBoxColumn
            // 
            this.cHPDataGridViewTextBoxColumn.DataPropertyName = "cHP";
            this.cHPDataGridViewTextBoxColumn.HeaderText = "cHP";
            this.cHPDataGridViewTextBoxColumn.Name = "cHPDataGridViewTextBoxColumn";
            this.cHPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHPFullDataGridViewTextBoxColumn
            // 
            this.cHPFullDataGridViewTextBoxColumn.DataPropertyName = "cHPFull";
            this.cHPFullDataGridViewTextBoxColumn.HeaderText = "cHPFull";
            this.cHPFullDataGridViewTextBoxColumn.Name = "cHPFullDataGridViewTextBoxColumn";
            this.cHPFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHPFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPDataGridViewTextBoxColumn
            // 
            this.cMPDataGridViewTextBoxColumn.DataPropertyName = "cMP";
            this.cMPDataGridViewTextBoxColumn.HeaderText = "cMP";
            this.cMPDataGridViewTextBoxColumn.Name = "cMPDataGridViewTextBoxColumn";
            this.cMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPFullDataGridViewTextBoxColumn
            // 
            this.cMPFullDataGridViewTextBoxColumn.DataPropertyName = "cMPFull";
            this.cMPFullDataGridViewTextBoxColumn.HeaderText = "cMPFull";
            this.cMPFullDataGridViewTextBoxColumn.Name = "cMPFullDataGridViewTextBoxColumn";
            this.cMPFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMPFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cStaminaDataGridViewTextBoxColumn
            // 
            this.cStaminaDataGridViewTextBoxColumn.DataPropertyName = "cStamina";
            this.cStaminaDataGridViewTextBoxColumn.HeaderText = "cStamina";
            this.cStaminaDataGridViewTextBoxColumn.Name = "cStaminaDataGridViewTextBoxColumn";
            this.cStaminaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cStaminaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMaxStaminaDataGridViewTextBoxColumn
            // 
            this.cMaxStaminaDataGridViewTextBoxColumn.DataPropertyName = "cMaxStamina";
            this.cMaxStaminaDataGridViewTextBoxColumn.HeaderText = "cMaxStamina";
            this.cMaxStaminaDataGridViewTextBoxColumn.Name = "cMaxStaminaDataGridViewTextBoxColumn";
            this.cMaxStaminaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMaxStaminaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPowerDataGridViewTextBoxColumn
            // 
            this.cPowerDataGridViewTextBoxColumn.DataPropertyName = "cPower";
            this.cPowerDataGridViewTextBoxColumn.HeaderText = "cPower";
            this.cPowerDataGridViewTextBoxColumn.Name = "cPowerDataGridViewTextBoxColumn";
            this.cPowerDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPowerDataGridViewTextBoxColumn.Visible = false;
            // 
            // cTiemNangDataGridViewTextBoxColumn
            // 
            this.cTiemNangDataGridViewTextBoxColumn.DataPropertyName = "cTiemNang";
            this.cTiemNangDataGridViewTextBoxColumn.HeaderText = "cTiemNang";
            this.cTiemNangDataGridViewTextBoxColumn.Name = "cTiemNangDataGridViewTextBoxColumn";
            this.cTiemNangDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTiemNangDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHPGocDataGridViewTextBoxColumn
            // 
            this.cHPGocDataGridViewTextBoxColumn.DataPropertyName = "cHPGoc";
            this.cHPGocDataGridViewTextBoxColumn.HeaderText = "cHPGoc";
            this.cHPGocDataGridViewTextBoxColumn.Name = "cHPGocDataGridViewTextBoxColumn";
            this.cHPGocDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHPGocDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPGocDataGridViewTextBoxColumn
            // 
            this.cMPGocDataGridViewTextBoxColumn.DataPropertyName = "cMPGoc";
            this.cMPGocDataGridViewTextBoxColumn.HeaderText = "cMPGoc";
            this.cMPGocDataGridViewTextBoxColumn.Name = "cMPGocDataGridViewTextBoxColumn";
            this.cMPGocDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMPGocDataGridViewTextBoxColumn.Visible = false;
            // 
            // cDefGocDataGridViewTextBoxColumn
            // 
            this.cDefGocDataGridViewTextBoxColumn.DataPropertyName = "cDefGoc";
            this.cDefGocDataGridViewTextBoxColumn.HeaderText = "cDefGoc";
            this.cDefGocDataGridViewTextBoxColumn.Name = "cDefGocDataGridViewTextBoxColumn";
            this.cDefGocDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDefGocDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCriticalGocDataGridViewTextBoxColumn
            // 
            this.cCriticalGocDataGridViewTextBoxColumn.DataPropertyName = "cCriticalGoc";
            this.cCriticalGocDataGridViewTextBoxColumn.HeaderText = "cCriticalGoc";
            this.cCriticalGocDataGridViewTextBoxColumn.Name = "cCriticalGocDataGridViewTextBoxColumn";
            this.cCriticalGocDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCriticalGocDataGridViewTextBoxColumn.Visible = false;
            // 
            // cDamFullDataGridViewTextBoxColumn
            // 
            this.cDamFullDataGridViewTextBoxColumn.DataPropertyName = "cDamFull";
            this.cDamFullDataGridViewTextBoxColumn.HeaderText = "cDamFull";
            this.cDamFullDataGridViewTextBoxColumn.Name = "cDamFullDataGridViewTextBoxColumn";
            this.cDamFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDamFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cDefullDataGridViewTextBoxColumn
            // 
            this.cDefullDataGridViewTextBoxColumn.DataPropertyName = "cDefull";
            this.cDefullDataGridViewTextBoxColumn.HeaderText = "cDefull";
            this.cDefullDataGridViewTextBoxColumn.Name = "cDefullDataGridViewTextBoxColumn";
            this.cDefullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDefullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCriticalFullDataGridViewTextBoxColumn
            // 
            this.cCriticalFullDataGridViewTextBoxColumn.DataPropertyName = "cCriticalFull";
            this.cCriticalFullDataGridViewTextBoxColumn.HeaderText = "cCriticalFull";
            this.cCriticalFullDataGridViewTextBoxColumn.Name = "cCriticalFullDataGridViewTextBoxColumn";
            this.cCriticalFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCriticalFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetHPDataGridViewTextBoxColumn
            // 
            this.cPetHPDataGridViewTextBoxColumn.DataPropertyName = "cPetHP";
            this.cPetHPDataGridViewTextBoxColumn.HeaderText = "cPetHP";
            this.cPetHPDataGridViewTextBoxColumn.Name = "cPetHPDataGridViewTextBoxColumn";
            this.cPetHPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetHPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetHPFullDataGridViewTextBoxColumn
            // 
            this.cPetHPFullDataGridViewTextBoxColumn.DataPropertyName = "cPetHPFull";
            this.cPetHPFullDataGridViewTextBoxColumn.HeaderText = "cPetHPFull";
            this.cPetHPFullDataGridViewTextBoxColumn.Name = "cPetHPFullDataGridViewTextBoxColumn";
            this.cPetHPFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetHPFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetMPDataGridViewTextBoxColumn
            // 
            this.cPetMPDataGridViewTextBoxColumn.DataPropertyName = "cPetMP";
            this.cPetMPDataGridViewTextBoxColumn.HeaderText = "cPetMP";
            this.cPetMPDataGridViewTextBoxColumn.Name = "cPetMPDataGridViewTextBoxColumn";
            this.cPetMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetMPFullDataGridViewTextBoxColumn
            // 
            this.cPetMPFullDataGridViewTextBoxColumn.DataPropertyName = "cPetMPFull";
            this.cPetMPFullDataGridViewTextBoxColumn.HeaderText = "cPetMPFull";
            this.cPetMPFullDataGridViewTextBoxColumn.Name = "cPetMPFullDataGridViewTextBoxColumn";
            this.cPetMPFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetMPFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetDamFullDataGridViewTextBoxColumn
            // 
            this.cPetDamFullDataGridViewTextBoxColumn.DataPropertyName = "cPetDamFull";
            this.cPetDamFullDataGridViewTextBoxColumn.HeaderText = "cPetDamFull";
            this.cPetDamFullDataGridViewTextBoxColumn.Name = "cPetDamFullDataGridViewTextBoxColumn";
            this.cPetDamFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetDamFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetDefullDataGridViewTextBoxColumn
            // 
            this.cPetDefullDataGridViewTextBoxColumn.DataPropertyName = "cPetDefull";
            this.cPetDefullDataGridViewTextBoxColumn.HeaderText = "cPetDefull";
            this.cPetDefullDataGridViewTextBoxColumn.Name = "cPetDefullDataGridViewTextBoxColumn";
            this.cPetDefullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetDefullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetCriticalFullDataGridViewTextBoxColumn
            // 
            this.cPetCriticalFullDataGridViewTextBoxColumn.DataPropertyName = "cPetCriticalFull";
            this.cPetCriticalFullDataGridViewTextBoxColumn.HeaderText = "cPetCriticalFull";
            this.cPetCriticalFullDataGridViewTextBoxColumn.Name = "cPetCriticalFullDataGridViewTextBoxColumn";
            this.cPetCriticalFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetCriticalFullDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetStaminaDataGridViewTextBoxColumn
            // 
            this.cPetStaminaDataGridViewTextBoxColumn.DataPropertyName = "cPetStamina";
            this.cPetStaminaDataGridViewTextBoxColumn.HeaderText = "cPetStamina";
            this.cPetStaminaDataGridViewTextBoxColumn.Name = "cPetStaminaDataGridViewTextBoxColumn";
            this.cPetStaminaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetStaminaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetMaxStaminaDataGridViewTextBoxColumn
            // 
            this.cPetMaxStaminaDataGridViewTextBoxColumn.DataPropertyName = "cPetMaxStamina";
            this.cPetMaxStaminaDataGridViewTextBoxColumn.HeaderText = "cPetMaxStamina";
            this.cPetMaxStaminaDataGridViewTextBoxColumn.Name = "cPetMaxStaminaDataGridViewTextBoxColumn";
            this.cPetMaxStaminaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetMaxStaminaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetPowerDataGridViewTextBoxColumn
            // 
            this.cPetPowerDataGridViewTextBoxColumn.DataPropertyName = "cPetPower";
            this.cPetPowerDataGridViewTextBoxColumn.HeaderText = "cPetPower";
            this.cPetPowerDataGridViewTextBoxColumn.Name = "cPetPowerDataGridViewTextBoxColumn";
            this.cPetPowerDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetPowerDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPetTiemNangDataGridViewTextBoxColumn
            // 
            this.cPetTiemNangDataGridViewTextBoxColumn.DataPropertyName = "cPetTiemNang";
            this.cPetTiemNangDataGridViewTextBoxColumn.HeaderText = "cPetTiemNang";
            this.cPetTiemNangDataGridViewTextBoxColumn.Name = "cPetTiemNangDataGridViewTextBoxColumn";
            this.cPetTiemNangDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPetTiemNangDataGridViewTextBoxColumn.Visible = false;
            // 
            // petStatusDataGridViewTextBoxColumn
            // 
            this.petStatusDataGridViewTextBoxColumn.DataPropertyName = "petStatus";
            this.petStatusDataGridViewTextBoxColumn.HeaderText = "petStatus";
            this.petStatusDataGridViewTextBoxColumn.Name = "petStatusDataGridViewTextBoxColumn";
            this.petStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.petStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // xuDataGridViewTextBoxColumn
            // 
            this.xuDataGridViewTextBoxColumn.DataPropertyName = "xu";
            this.xuDataGridViewTextBoxColumn.HeaderText = "xu";
            this.xuDataGridViewTextBoxColumn.Name = "xuDataGridViewTextBoxColumn";
            this.xuDataGridViewTextBoxColumn.ReadOnly = true;
            this.xuDataGridViewTextBoxColumn.Visible = false;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "luong";
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongDataGridViewTextBoxColumn.Visible = false;
            // 
            // luongKhoaDataGridViewTextBoxColumn
            // 
            this.luongKhoaDataGridViewTextBoxColumn.DataPropertyName = "luongKhoa";
            this.luongKhoaDataGridViewTextBoxColumn.HeaderText = "luongKhoa";
            this.luongKhoaDataGridViewTextBoxColumn.Name = "luongKhoaDataGridViewTextBoxColumn";
            this.luongKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongKhoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // planetDataGridViewTextBoxColumn
            // 
            this.planetDataGridViewTextBoxColumn.DataPropertyName = "planet";
            this.planetDataGridViewTextBoxColumn.HeaderText = "planet";
            this.planetDataGridViewTextBoxColumn.Name = "planetDataGridViewTextBoxColumn";
            this.planetDataGridViewTextBoxColumn.ReadOnly = true;
            this.planetDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataAccount
            // 
            this.DataAccount.DataSource = typeof(Account);
            // 
            // PnlInfo
            // 
            this.PnlInfo.Controls.Add(this.GrboxInfo);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlInfo.Location = new System.Drawing.Point(651, 5);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Size = new System.Drawing.Size(220, 516);
            this.PnlInfo.TabIndex = 19;
            // 
            // GrboxInfo
            // 
            this.GrboxInfo.Controls.Add(this.TpnlInfo);
            this.GrboxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxInfo.Location = new System.Drawing.Point(0, 0);
            this.GrboxInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GrboxInfo.Name = "GrboxInfo";
            this.GrboxInfo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxInfo.Size = new System.Drawing.Size(220, 516);
            this.GrboxInfo.TabIndex = 0;
            this.GrboxInfo.TabStop = false;
            this.GrboxInfo.Text = "Thông tin";
            // 
            // TpnlInfo
            // 
            this.TpnlInfo.ColumnCount = 2;
            this.TpnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TpnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TpnlInfo.Controls.Add(this.tableLayoutPanel3, 1, 8);
            this.TpnlInfo.Controls.Add(this.textBox1, 0, 11);
            this.TpnlInfo.Controls.Add(this.cbbVerSel, 0, 9);
            this.TpnlInfo.Controls.Add(this.txtNote, 0, 10);
            this.TpnlInfo.Controls.Add(this.txtVersion, 0, 8);
            this.TpnlInfo.Controls.Add(this.LbGraphic, 1, 6);
            this.TpnlInfo.Controls.Add(this.LbSize, 0, 6);
            this.TpnlInfo.Controls.Add(this.LbHost, 0, 4);
            this.TpnlInfo.Controls.Add(this.CbbServer, 1, 5);
            this.TpnlInfo.Controls.Add(this.LbServer, 1, 4);
            this.TpnlInfo.Controls.Add(this.txtUsername, 0, 1);
            this.TpnlInfo.Controls.Add(this.LbUsername, 0, 0);
            this.TpnlInfo.Controls.Add(this.LbPass, 0, 2);
            this.TpnlInfo.Controls.Add(this.TpnlBtnInfo, 0, 13);
            this.TpnlInfo.Controls.Add(this.TpnlPass, 0, 3);
            this.TpnlInfo.Controls.Add(this.TpnlSize, 0, 7);
            this.TpnlInfo.Controls.Add(this.CbbHost, 0, 5);
            this.TpnlInfo.Controls.Add(this.CbbGraphic, 1, 7);
            this.TpnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlInfo.Location = new System.Drawing.Point(5, 15);
            this.TpnlInfo.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlInfo.Name = "TpnlInfo";
            this.TpnlInfo.RowCount = 15;
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667225F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664559F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66456F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664179F));
            this.TpnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlInfo.Size = new System.Drawing.Size(210, 496);
            this.TpnlInfo.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbInfoCharShow, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(105, 264);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(105, 33);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(84, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbInfoCharShow
            // 
            this.lbInfoCharShow.AutoSize = true;
            this.lbInfoCharShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInfoCharShow.Location = new System.Drawing.Point(5, 5);
            this.lbInfoCharShow.Margin = new System.Windows.Forms.Padding(5);
            this.lbInfoCharShow.Name = "lbInfoCharShow";
            this.lbInfoCharShow.Size = new System.Drawing.Size(68, 23);
            this.lbInfoCharShow.TabIndex = 14;
            this.lbInfoCharShow.Text = "Show info";
            this.lbInfoCharShow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            this.TpnlInfo.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(5, 363);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.TpnlInfo.SetRowSpan(this.textBox1, 2);
            this.textBox1.Size = new System.Drawing.Size(200, 61);
            this.textBox1.TabIndex = 16;
            // 
            // cbbVerSel
            // 
            this.cbbVerSel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbVerSel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbVerSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbVerSel.FormattingEnabled = true;
            this.cbbVerSel.Location = new System.Drawing.Point(5, 297);
            this.cbbVerSel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbbVerSel.Name = "cbbVerSel";
            this.cbbVerSel.Size = new System.Drawing.Size(95, 23);
            this.cbbVerSel.TabIndex = 15;
            // 
            // txtNote
            // 
            this.txtNote.AutoSize = true;
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(5, 335);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(95, 23);
            this.txtNote.TabIndex = 14;
            this.txtNote.Text = "Ghi chú";
            this.txtNote.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(5, 269);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(5);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(95, 23);
            this.txtVersion.TabIndex = 13;
            this.txtVersion.Text = "Version";
            this.txtVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbGraphic
            // 
            this.LbGraphic.AutoSize = true;
            this.LbGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbGraphic.Location = new System.Drawing.Point(110, 203);
            this.LbGraphic.Margin = new System.Windows.Forms.Padding(5);
            this.LbGraphic.Name = "LbGraphic";
            this.LbGraphic.Size = new System.Drawing.Size(95, 23);
            this.LbGraphic.TabIndex = 10;
            this.LbGraphic.Text = "Cấu hình";
            this.LbGraphic.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbSize
            // 
            this.LbSize.AutoSize = true;
            this.LbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSize.Location = new System.Drawing.Point(5, 203);
            this.LbSize.Margin = new System.Windows.Forms.Padding(5);
            this.LbSize.Name = "LbSize";
            this.LbSize.Size = new System.Drawing.Size(95, 23);
            this.LbSize.TabIndex = 9;
            this.LbSize.Text = "Size";
            this.LbSize.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbHost
            // 
            this.LbHost.AutoSize = true;
            this.LbHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbHost.Location = new System.Drawing.Point(5, 137);
            this.LbHost.Margin = new System.Windows.Forms.Padding(5);
            this.LbHost.Name = "LbHost";
            this.LbHost.Size = new System.Drawing.Size(95, 23);
            this.LbHost.TabIndex = 8;
            this.LbHost.Text = "Host";
            this.LbHost.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CbbServer
            // 
            this.CbbServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbbServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbServer.FormattingEnabled = true;
            this.CbbServer.Location = new System.Drawing.Point(110, 165);
            this.CbbServer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CbbServer.MaxDropDownItems = 15;
            this.CbbServer.Name = "CbbServer";
            this.CbbServer.Size = new System.Drawing.Size(95, 23);
            this.CbbServer.TabIndex = 3;
            this.CbbServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbbServer_KeyDown);
            // 
            // LbServer
            // 
            this.LbServer.AutoSize = true;
            this.LbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbServer.Location = new System.Drawing.Point(110, 137);
            this.LbServer.Margin = new System.Windows.Forms.Padding(5);
            this.LbServer.Name = "LbServer";
            this.LbServer.Size = new System.Drawing.Size(95, 23);
            this.LbServer.TabIndex = 1;
            this.LbServer.Text = "Sever";
            this.LbServer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsername
            // 
            this.TpnlInfo.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(5, 33);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbUsername.Location = new System.Drawing.Point(5, 5);
            this.LbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(95, 23);
            this.LbUsername.TabIndex = 1;
            this.LbUsername.Text = "Tài khoản";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPass.Location = new System.Drawing.Point(5, 71);
            this.LbPass.Margin = new System.Windows.Forms.Padding(5);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(95, 23);
            this.LbPass.TabIndex = 1;
            this.LbPass.Text = "Mật khẩu";
            this.LbPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TpnlBtnInfo
            // 
            this.TpnlBtnInfo.ColumnCount = 4;
            this.TpnlInfo.SetColumnSpan(this.TpnlBtnInfo, 2);
            this.TpnlBtnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlBtnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlBtnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlBtnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlBtnInfo.Controls.Add(this.btnDelData, 3, 0);
            this.TpnlBtnInfo.Controls.Add(this.BtnAdd, 0, 0);
            this.TpnlBtnInfo.Controls.Add(this.BtnEdit, 1, 0);
            this.TpnlBtnInfo.Controls.Add(this.BtnDelete, 2, 0);
            this.TpnlBtnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlBtnInfo.Location = new System.Drawing.Point(0, 429);
            this.TpnlBtnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlBtnInfo.Name = "TpnlBtnInfo";
            this.TpnlBtnInfo.RowCount = 1;
            this.TpnlInfo.SetRowSpan(this.TpnlBtnInfo, 2);
            this.TpnlBtnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlBtnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlBtnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlBtnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlBtnInfo.Size = new System.Drawing.Size(210, 67);
            this.TpnlBtnInfo.TabIndex = 5;
            // 
            // btnDelData
            // 
            this.btnDelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelData.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelData.Location = new System.Drawing.Point(156, 0);
            this.btnDelData.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelData.Name = "btnDelData";
            this.btnDelData.Size = new System.Drawing.Size(54, 67);
            this.btnDelData.TabIndex = 6;
            this.btnDelData.Text = "Xoá dữ liệu";
            this.btnDelData.UseVisualStyleBackColor = true;
            this.btnDelData.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 0);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(52, 67);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(52, 0);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnEdit.Size = new System.Drawing.Size(52, 67);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(104, 0);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(52, 67);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Xoá";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TpnlPass
            // 
            this.TpnlPass.ColumnCount = 2;
            this.TpnlInfo.SetColumnSpan(this.TpnlPass, 2);
            this.TpnlPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TpnlPass.Controls.Add(this.txtPass, 0, 0);
            this.TpnlPass.Controls.Add(this.checkBoxHide, 1, 0);
            this.TpnlPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlPass.Location = new System.Drawing.Point(0, 99);
            this.TpnlPass.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlPass.Name = "TpnlPass";
            this.TpnlPass.RowCount = 1;
            this.TpnlPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlPass.Size = new System.Drawing.Size(210, 33);
            this.TpnlPass.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Location = new System.Drawing.Point(5, 0);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(170, 22);
            this.txtPass.TabIndex = 11;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(187, 8);
            this.checkBoxHide.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHide.TabIndex = 4;
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // TpnlSize
            // 
            this.TpnlSize.ColumnCount = 3;
            this.TpnlSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TpnlSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TpnlSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TpnlSize.Controls.Add(this.txtH, 2, 0);
            this.TpnlSize.Controls.Add(this.txtW, 0, 0);
            this.TpnlSize.Controls.Add(this.LbX, 1, 0);
            this.TpnlSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlSize.Location = new System.Drawing.Point(0, 231);
            this.TpnlSize.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlSize.Name = "TpnlSize";
            this.TpnlSize.RowCount = 1;
            this.TpnlSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlSize.Size = new System.Drawing.Size(105, 33);
            this.TpnlSize.TabIndex = 7;
            // 
            // txtH
            // 
            this.txtH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtH.Location = new System.Drawing.Point(65, 0);
            this.txtH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(35, 22);
            this.txtH.TabIndex = 13;
            this.txtH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtH_KeyDown);
            // 
            // txtW
            // 
            this.txtW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtW.Location = new System.Drawing.Point(5, 0);
            this.txtW.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(35, 22);
            this.txtW.TabIndex = 12;
            this.txtW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtW_KeyDown);
            // 
            // LbX
            // 
            this.LbX.AutoSize = true;
            this.LbX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbX.Location = new System.Drawing.Point(46, 0);
            this.LbX.Margin = new System.Windows.Forms.Padding(1, 0, 0, 5);
            this.LbX.Name = "LbX";
            this.LbX.Size = new System.Drawing.Size(14, 28);
            this.LbX.TabIndex = 9;
            this.LbX.Text = "X";
            this.LbX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbbHost
            // 
            this.CbbHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbbHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbbHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbHost.FormattingEnabled = true;
            this.CbbHost.Location = new System.Drawing.Point(5, 165);
            this.CbbHost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CbbHost.Name = "CbbHost";
            this.CbbHost.Size = new System.Drawing.Size(95, 23);
            this.CbbHost.TabIndex = 11;
            this.CbbHost.SelectedIndexChanged += new System.EventHandler(this.CbbHost_SelectedIndexChanged);
            this.CbbHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbbHost_KeyDown);
            // 
            // CbbGraphic
            // 
            this.CbbGraphic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbbGraphic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbbGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbGraphic.FormattingEnabled = true;
            this.CbbGraphic.Items.AddRange(new object[] {
            "Cao",
            "Thấp"});
            this.CbbGraphic.Location = new System.Drawing.Point(110, 231);
            this.CbbGraphic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CbbGraphic.MaxDropDownItems = 2;
            this.CbbGraphic.Name = "CbbGraphic";
            this.CbbGraphic.Size = new System.Drawing.Size(95, 23);
            this.CbbGraphic.TabIndex = 12;
            this.CbbGraphic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbbGraphic_KeyDown);
            // 
            // PnlControl
            // 
            this.PnlControl.Controls.Add(this.GrboxControl);
            this.PnlControl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlControl.Location = new System.Drawing.Point(5, 321);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(641, 200);
            this.PnlControl.TabIndex = 18;
            // 
            // GrboxControl
            // 
            this.GrboxControl.Controls.Add(this.TpnlControl);
            this.GrboxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxControl.Location = new System.Drawing.Point(0, 0);
            this.GrboxControl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GrboxControl.Name = "GrboxControl";
            this.GrboxControl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxControl.Size = new System.Drawing.Size(641, 200);
            this.GrboxControl.TabIndex = 0;
            this.GrboxControl.TabStop = false;
            this.GrboxControl.Text = "Controls";
            // 
            // TpnlControl
            // 
            this.TpnlControl.ColumnCount = 3;
            this.TpnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlControl.Controls.Add(this.groupBox1, 2, 0);
            this.TpnlControl.Controls.Add(this.GrboxArea, 0, 0);
            this.TpnlControl.Controls.Add(this.GrbDieuKhien, 1, 0);
            this.TpnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlControl.Location = new System.Drawing.Point(5, 15);
            this.TpnlControl.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlControl.Name = "TpnlControl";
            this.TpnlControl.RowCount = 1;
            this.TpnlControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlControl.Size = new System.Drawing.Size(631, 180);
            this.TpnlControl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(425, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(201, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.BtnMacGLT, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.BtnGoHome, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.BtnResetSB, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.BtnThaoGLT, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.BtnBanhChung, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.BtnBH2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.BtnBH, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.BtnCN2, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.BtnCN, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 15);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(191, 160);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // BtnMacGLT
            // 
            this.BtnMacGLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMacGLT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMacGLT.Location = new System.Drawing.Point(5, 108);
            this.BtnMacGLT.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.BtnMacGLT.Name = "BtnMacGLT";
            this.BtnMacGLT.Size = new System.Drawing.Size(56, 47);
            this.BtnMacGLT.TabIndex = 16;
            this.BtnMacGLT.Text = "Mặc GLT";
            this.BtnMacGLT.UseVisualStyleBackColor = true;
            // 
            // BtnGoHome
            // 
            this.BtnGoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGoHome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoHome.Location = new System.Drawing.Point(65, 108);
            this.BtnGoHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.BtnGoHome.Name = "BtnGoHome";
            this.BtnGoHome.Size = new System.Drawing.Size(59, 47);
            this.BtnGoHome.TabIndex = 15;
            this.BtnGoHome.Text = "Về nhà";
            this.BtnGoHome.UseVisualStyleBackColor = true;
            // 
            // BtnResetSB
            // 
            this.BtnResetSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnResetSB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetSB.Location = new System.Drawing.Point(128, 108);
            this.BtnResetSB.Margin = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.BtnResetSB.Name = "BtnResetSB";
            this.BtnResetSB.Size = new System.Drawing.Size(58, 47);
            this.BtnResetSB.TabIndex = 14;
            this.BtnResetSB.Text = "Reset SB";
            this.BtnResetSB.UseVisualStyleBackColor = true;
            // 
            // BtnThaoGLT
            // 
            this.BtnThaoGLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnThaoGLT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThaoGLT.Location = new System.Drawing.Point(128, 55);
            this.BtnThaoGLT.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.BtnThaoGLT.Name = "BtnThaoGLT";
            this.BtnThaoGLT.Size = new System.Drawing.Size(58, 49);
            this.BtnThaoGLT.TabIndex = 13;
            this.BtnThaoGLT.Text = "Tháo GLT";
            this.BtnThaoGLT.UseVisualStyleBackColor = true;
            // 
            // BtnBanhChung
            // 
            this.BtnBanhChung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBanhChung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBanhChung.Location = new System.Drawing.Point(65, 55);
            this.BtnBanhChung.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBanhChung.Name = "BtnBanhChung";
            this.BtnBanhChung.Size = new System.Drawing.Size(59, 49);
            this.BtnBanhChung.TabIndex = 12;
            this.BtnBanhChung.Text = "Bánh chưng";
            this.BtnBanhChung.UseVisualStyleBackColor = true;
            // 
            // BtnBH2
            // 
            this.BtnBH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBH2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBH2.Location = new System.Drawing.Point(5, 55);
            this.BtnBH2.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.BtnBH2.Name = "BtnBH2";
            this.BtnBH2.Size = new System.Drawing.Size(56, 49);
            this.BtnBH2.TabIndex = 11;
            this.BtnBH2.Text = "Bổ huyết 2";
            this.BtnBH2.UseVisualStyleBackColor = true;
            // 
            // BtnBH
            // 
            this.BtnBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBH.Location = new System.Drawing.Point(128, 5);
            this.BtnBH.Margin = new System.Windows.Forms.Padding(2, 5, 5, 2);
            this.BtnBH.Name = "BtnBH";
            this.BtnBH.Size = new System.Drawing.Size(58, 46);
            this.BtnBH.TabIndex = 10;
            this.BtnBH.Text = "Bổ huyết";
            this.BtnBH.UseVisualStyleBackColor = true;
            // 
            // BtnCN2
            // 
            this.BtnCN2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCN2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCN2.Location = new System.Drawing.Point(65, 5);
            this.BtnCN2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.BtnCN2.Name = "BtnCN2";
            this.BtnCN2.Size = new System.Drawing.Size(59, 46);
            this.BtnCN2.TabIndex = 9;
            this.BtnCN2.Text = "Cuồng nộ 2";
            this.BtnCN2.UseVisualStyleBackColor = true;
            // 
            // BtnCN
            // 
            this.BtnCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCN.Location = new System.Drawing.Point(5, 5);
            this.BtnCN.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.BtnCN.Name = "BtnCN";
            this.BtnCN.Size = new System.Drawing.Size(56, 46);
            this.BtnCN.TabIndex = 7;
            this.BtnCN.Text = "Cuồng nộ";
            this.BtnCN.UseVisualStyleBackColor = true;
            // 
            // GrboxArea
            // 
            this.GrboxArea.Controls.Add(this.TpnlArea);
            this.GrboxArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxArea.Location = new System.Drawing.Point(5, 0);
            this.GrboxArea.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GrboxArea.Name = "GrboxArea";
            this.GrboxArea.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxArea.Size = new System.Drawing.Size(200, 180);
            this.GrboxArea.TabIndex = 1;
            this.GrboxArea.TabStop = false;
            this.GrboxArea.Text = "Khu vực";
            // 
            // TpnlArea
            // 
            this.TpnlArea.ColumnCount = 3;
            this.TpnlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.Controls.Add(this.BtnArea5, 2, 1);
            this.TpnlArea.Controls.Add(this.BtnArea4, 1, 1);
            this.TpnlArea.Controls.Add(this.BtnArea3, 0, 1);
            this.TpnlArea.Controls.Add(this.BtnArea2, 2, 0);
            this.TpnlArea.Controls.Add(this.BtnArea1, 1, 0);
            this.TpnlArea.Controls.Add(this.BtnArea0, 0, 0);
            this.TpnlArea.Controls.Add(this.TpnlSubArea, 0, 2);
            this.TpnlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlArea.Location = new System.Drawing.Point(5, 15);
            this.TpnlArea.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlArea.Name = "TpnlArea";
            this.TpnlArea.RowCount = 3;
            this.TpnlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlArea.Size = new System.Drawing.Size(190, 160);
            this.TpnlArea.TabIndex = 0;
            // 
            // BtnArea5
            // 
            this.BtnArea5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea5.Location = new System.Drawing.Point(128, 55);
            this.BtnArea5.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.BtnArea5.Name = "BtnArea5";
            this.BtnArea5.Size = new System.Drawing.Size(57, 49);
            this.BtnArea5.TabIndex = 13;
            this.BtnArea5.Text = "Khu 5";
            this.BtnArea5.UseVisualStyleBackColor = true;
            // 
            // BtnArea4
            // 
            this.BtnArea4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea4.Location = new System.Drawing.Point(65, 55);
            this.BtnArea4.Margin = new System.Windows.Forms.Padding(2);
            this.BtnArea4.Name = "BtnArea4";
            this.BtnArea4.Size = new System.Drawing.Size(59, 49);
            this.BtnArea4.TabIndex = 12;
            this.BtnArea4.Text = "Khu 4";
            this.BtnArea4.UseVisualStyleBackColor = true;
            // 
            // BtnArea3
            // 
            this.BtnArea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea3.Location = new System.Drawing.Point(5, 55);
            this.BtnArea3.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.BtnArea3.Name = "BtnArea3";
            this.BtnArea3.Size = new System.Drawing.Size(56, 49);
            this.BtnArea3.TabIndex = 11;
            this.BtnArea3.Text = "Khu 3";
            this.BtnArea3.UseVisualStyleBackColor = true;
            // 
            // BtnArea2
            // 
            this.BtnArea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea2.Location = new System.Drawing.Point(128, 5);
            this.BtnArea2.Margin = new System.Windows.Forms.Padding(2, 5, 5, 2);
            this.BtnArea2.Name = "BtnArea2";
            this.BtnArea2.Size = new System.Drawing.Size(57, 46);
            this.BtnArea2.TabIndex = 10;
            this.BtnArea2.Text = "Khu 2";
            this.BtnArea2.UseVisualStyleBackColor = true;
            // 
            // BtnArea1
            // 
            this.BtnArea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea1.Location = new System.Drawing.Point(65, 5);
            this.BtnArea1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.BtnArea1.Name = "BtnArea1";
            this.BtnArea1.Size = new System.Drawing.Size(59, 46);
            this.BtnArea1.TabIndex = 9;
            this.BtnArea1.Text = "Khu 1";
            this.BtnArea1.UseVisualStyleBackColor = true;
            // 
            // BtnArea0
            // 
            this.BtnArea0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArea0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea0.Location = new System.Drawing.Point(5, 5);
            this.BtnArea0.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.BtnArea0.Name = "BtnArea0";
            this.BtnArea0.Size = new System.Drawing.Size(56, 46);
            this.BtnArea0.TabIndex = 7;
            this.BtnArea0.Text = "Khu 0";
            this.BtnArea0.UseVisualStyleBackColor = true;
            // 
            // TpnlSubArea
            // 
            this.TpnlSubArea.ColumnCount = 2;
            this.TpnlArea.SetColumnSpan(this.TpnlSubArea, 3);
            this.TpnlSubArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TpnlSubArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlSubArea.Controls.Add(this.txtArea, 0, 0);
            this.TpnlSubArea.Controls.Add(this.BtnChangeArea, 1, 0);
            this.TpnlSubArea.Location = new System.Drawing.Point(0, 106);
            this.TpnlSubArea.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlSubArea.Name = "TpnlSubArea";
            this.TpnlSubArea.RowCount = 1;
            this.TpnlSubArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlSubArea.Size = new System.Drawing.Size(190, 52);
            this.TpnlSubArea.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(5, 15);
            this.txtArea.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(135, 22);
            this.txtArea.TabIndex = 13;
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            // 
            // BtnChangeArea
            // 
            this.BtnChangeArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChangeArea.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeArea.Location = new System.Drawing.Point(144, 14);
            this.BtnChangeArea.Margin = new System.Windows.Forms.Padding(2, 14, 5, 14);
            this.BtnChangeArea.Name = "BtnChangeArea";
            this.BtnChangeArea.Size = new System.Drawing.Size(41, 24);
            this.BtnChangeArea.TabIndex = 13;
            this.BtnChangeArea.Text = "Đổi";
            this.BtnChangeArea.UseVisualStyleBackColor = true;
            // 
            // GrbDieuKhien
            // 
            this.GrbDieuKhien.Controls.Add(this.TpnlDieuKhien);
            this.GrbDieuKhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbDieuKhien.Location = new System.Drawing.Point(215, 0);
            this.GrbDieuKhien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GrbDieuKhien.Name = "GrbDieuKhien";
            this.GrbDieuKhien.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrbDieuKhien.Size = new System.Drawing.Size(200, 180);
            this.GrbDieuKhien.TabIndex = 2;
            this.GrbDieuKhien.TabStop = false;
            this.GrbDieuKhien.Text = "Điều khiển";
            // 
            // TpnlDieuKhien
            // 
            this.TpnlDieuKhien.ColumnCount = 2;
            this.TpnlDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TpnlDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlDieuKhien.Controls.Add(this.txtChat2, 0, 1);
            this.TpnlDieuKhien.Controls.Add(this.txtChatContent, 0, 0);
            this.TpnlDieuKhien.Controls.Add(this.BtnChat2, 1, 1);
            this.TpnlDieuKhien.Controls.Add(this.BtnChat, 1, 0);
            this.TpnlDieuKhien.Controls.Add(this.TpnlSubDieuKhien, 0, 2);
            this.TpnlDieuKhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlDieuKhien.Location = new System.Drawing.Point(5, 15);
            this.TpnlDieuKhien.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlDieuKhien.Name = "TpnlDieuKhien";
            this.TpnlDieuKhien.RowCount = 3;
            this.TpnlDieuKhien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlDieuKhien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlDieuKhien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlDieuKhien.Size = new System.Drawing.Size(190, 160);
            this.TpnlDieuKhien.TabIndex = 0;
            // 
            // txtChat2
            // 
            this.txtChat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat2.Location = new System.Drawing.Point(5, 68);
            this.txtChat2.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.txtChat2.Name = "txtChat2";
            this.txtChat2.Size = new System.Drawing.Size(135, 22);
            this.txtChat2.TabIndex = 16;
            this.txtChat2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeleID_KeyDown);
            // 
            // txtChatContent
            // 
            this.txtChatContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatContent.Location = new System.Drawing.Point(5, 15);
            this.txtChatContent.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.txtChatContent.Name = "txtChatContent";
            this.txtChatContent.Size = new System.Drawing.Size(135, 22);
            this.txtChatContent.TabIndex = 15;
            this.txtChatContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChatContent_KeyDown);
            // 
            // BtnChat2
            // 
            this.BtnChat2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChat2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChat2.Location = new System.Drawing.Point(144, 67);
            this.BtnChat2.Margin = new System.Windows.Forms.Padding(2, 14, 5, 14);
            this.BtnChat2.Name = "BtnChat2";
            this.BtnChat2.Size = new System.Drawing.Size(41, 25);
            this.BtnChat2.TabIndex = 14;
            this.BtnChat2.Text = "Chat";
            this.BtnChat2.UseVisualStyleBackColor = true;
            // 
            // BtnChat
            // 
            this.BtnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChat.Location = new System.Drawing.Point(144, 14);
            this.BtnChat.Margin = new System.Windows.Forms.Padding(2, 14, 5, 14);
            this.BtnChat.Name = "BtnChat";
            this.BtnChat.Size = new System.Drawing.Size(41, 25);
            this.BtnChat.TabIndex = 11;
            this.BtnChat.Text = "Chat";
            this.BtnChat.UseVisualStyleBackColor = true;
            // 
            // TpnlSubDieuKhien
            // 
            this.TpnlSubDieuKhien.ColumnCount = 3;
            this.TpnlDieuKhien.SetColumnSpan(this.TpnlSubDieuKhien, 2);
            this.TpnlSubDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlSubDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlSubDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlSubDieuKhien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlSubDieuKhien.Controls.Add(this.BtnLoadRight, 0, 0);
            this.TpnlSubDieuKhien.Controls.Add(this.BtnLoadMid, 0, 0);
            this.TpnlSubDieuKhien.Controls.Add(this.BtnLoadLeft, 0, 0);
            this.TpnlSubDieuKhien.Location = new System.Drawing.Point(0, 106);
            this.TpnlSubDieuKhien.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlSubDieuKhien.Name = "TpnlSubDieuKhien";
            this.TpnlSubDieuKhien.RowCount = 1;
            this.TpnlSubDieuKhien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlSubDieuKhien.Size = new System.Drawing.Size(190, 52);
            this.TpnlSubDieuKhien.TabIndex = 0;
            // 
            // BtnLoadRight
            // 
            this.BtnLoadRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoadRight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadRight.Location = new System.Drawing.Point(128, 2);
            this.BtnLoadRight.Margin = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.BtnLoadRight.Name = "BtnLoadRight";
            this.BtnLoadRight.Size = new System.Drawing.Size(57, 45);
            this.BtnLoadRight.TabIndex = 17;
            this.BtnLoadRight.Text = "Load phải";
            this.BtnLoadRight.UseVisualStyleBackColor = true;
            // 
            // BtnLoadMid
            // 
            this.BtnLoadMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoadMid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadMid.Location = new System.Drawing.Point(65, 2);
            this.BtnLoadMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.BtnLoadMid.Name = "BtnLoadMid";
            this.BtnLoadMid.Size = new System.Drawing.Size(59, 45);
            this.BtnLoadMid.TabIndex = 16;
            this.BtnLoadMid.Text = "Load giữa";
            this.BtnLoadMid.UseVisualStyleBackColor = true;
            // 
            // BtnLoadLeft
            // 
            this.BtnLoadLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoadLeft.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadLeft.Location = new System.Drawing.Point(5, 2);
            this.BtnLoadLeft.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.BtnLoadLeft.Name = "BtnLoadLeft";
            this.BtnLoadLeft.Size = new System.Drawing.Size(56, 45);
            this.BtnLoadLeft.TabIndex = 15;
            this.BtnLoadLeft.Text = "Load trái";
            this.BtnLoadLeft.UseVisualStyleBackColor = true;
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.Controls.Add(this.PnlSetting);
            this.TabPageSettings.Location = new System.Drawing.Point(4, 31);
            this.TabPageSettings.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Padding = new System.Windows.Forms.Padding(5);
            this.TabPageSettings.Size = new System.Drawing.Size(876, 526);
            this.TabPageSettings.TabIndex = 1;
            this.TabPageSettings.Text = "Settings";
            this.TabPageSettings.UseVisualStyleBackColor = true;
            // 
            // PnlSetting
            // 
            this.PnlSetting.Controls.Add(this.TpnlSetting);
            this.PnlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSetting.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlSetting.Location = new System.Drawing.Point(5, 5);
            this.PnlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSetting.Name = "PnlSetting";
            this.PnlSetting.Size = new System.Drawing.Size(866, 516);
            this.PnlSetting.TabIndex = 0;
            // 
            // TpnlSetting
            // 
            this.TpnlSetting.ColumnCount = 1;
            this.TpnlSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlSetting.Controls.Add(this.GrboxChucNang, 0, 0);
            this.TpnlSetting.Controls.Add(this.GrboxTDLT, 0, 1);
            this.TpnlSetting.Controls.Add(this.GrboxCoDinh, 0, 3);
            this.TpnlSetting.Controls.Add(this.GrboxItem, 0, 2);
            this.TpnlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlSetting.Location = new System.Drawing.Point(0, 0);
            this.TpnlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlSetting.Name = "TpnlSetting";
            this.TpnlSetting.RowCount = 4;
            this.TpnlSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TpnlSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlSetting.Size = new System.Drawing.Size(866, 516);
            this.TpnlSetting.TabIndex = 0;
            // 
            // GrboxChucNang
            // 
            this.GrboxChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxChucNang.Location = new System.Drawing.Point(5, 0);
            this.GrboxChucNang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxChucNang.Name = "GrboxChucNang";
            this.GrboxChucNang.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxChucNang.Size = new System.Drawing.Size(856, 124);
            this.GrboxChucNang.TabIndex = 0;
            this.GrboxChucNang.TabStop = false;
            this.GrboxChucNang.Text = "Chức năng";
            // 
            // GrboxTDLT
            // 
            this.GrboxTDLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxTDLT.Location = new System.Drawing.Point(5, 129);
            this.GrboxTDLT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxTDLT.Name = "GrboxTDLT";
            this.GrboxTDLT.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxTDLT.Size = new System.Drawing.Size(856, 124);
            this.GrboxTDLT.TabIndex = 1;
            this.GrboxTDLT.TabStop = false;
            this.GrboxTDLT.Text = "Tự động luyện tập";
            // 
            // GrboxCoDinh
            // 
            this.GrboxCoDinh.Controls.Add(this.TpnlCoDinh);
            this.GrboxCoDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxCoDinh.Location = new System.Drawing.Point(5, 387);
            this.GrboxCoDinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxCoDinh.Name = "GrboxCoDinh";
            this.GrboxCoDinh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxCoDinh.Size = new System.Drawing.Size(856, 124);
            this.GrboxCoDinh.TabIndex = 2;
            this.GrboxCoDinh.TabStop = false;
            this.GrboxCoDinh.Text = "Optimize";
            // 
            // TpnlCoDinh
            // 
            this.TpnlCoDinh.ColumnCount = 6;
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TpnlCoDinh.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.TpnlCoDinh.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.TpnlCoDinh.Controls.Add(this.tableLayoutPanel4, 4, 1);
            this.TpnlCoDinh.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.TpnlCoDinh.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TpnlCoDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpnlCoDinh.Location = new System.Drawing.Point(5, 15);
            this.TpnlCoDinh.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlCoDinh.Name = "TpnlCoDinh";
            this.TpnlCoDinh.RowCount = 3;
            this.TpnlCoDinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlCoDinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlCoDinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TpnlCoDinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TpnlCoDinh.Size = new System.Drawing.Size(846, 104);
            this.TpnlCoDinh.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.TpnlCoDinh.SetColumnSpan(this.tableLayoutPanel5, 6);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12601F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.48794F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12601F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26005F));
            this.tableLayoutPanel5.Controls.Add(this.btnIPSerAdd, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtIPSerAdd, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbSerAdd, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbbHostSel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbHostSel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(846, 36);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // btnIPSerAdd
            // 
            this.btnIPSerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIPSerAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPSerAdd.Location = new System.Drawing.Point(754, 5);
            this.btnIPSerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnIPSerAdd.Name = "btnIPSerAdd";
            this.btnIPSerAdd.Size = new System.Drawing.Size(87, 26);
            this.btnIPSerAdd.TabIndex = 24;
            this.btnIPSerAdd.Text = "Thêm";
            this.btnIPSerAdd.UseVisualStyleBackColor = true;
            this.btnIPSerAdd.Click += new System.EventHandler(this.btnIPSerAdd_Click);
            // 
            // txtIPSerAdd
            // 
            this.txtIPSerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIPSerAdd.Location = new System.Drawing.Point(332, 5);
            this.txtIPSerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.txtIPSerAdd.Name = "txtIPSerAdd";
            this.txtIPSerAdd.Size = new System.Drawing.Size(412, 22);
            this.txtIPSerAdd.TabIndex = 19;
            // 
            // lbSerAdd
            // 
            this.lbSerAdd.AutoSize = true;
            this.lbSerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerAdd.Location = new System.Drawing.Point(238, 5);
            this.lbSerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.lbSerAdd.Name = "lbSerAdd";
            this.lbSerAdd.Size = new System.Drawing.Size(84, 26);
            this.lbSerAdd.TabIndex = 16;
            this.lbSerAdd.Text = "IP Server";
            this.lbSerAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbHostSel
            // 
            this.cbbHostSel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbHostSel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbHostSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbHostSel.FormattingEnabled = true;
            this.cbbHostSel.Location = new System.Drawing.Point(99, 5);
            this.cbbHostSel.Margin = new System.Windows.Forms.Padding(5);
            this.cbbHostSel.Name = "cbbHostSel";
            this.cbbHostSel.Size = new System.Drawing.Size(129, 23);
            this.cbbHostSel.TabIndex = 15;
            // 
            // lbHostSel
            // 
            this.lbHostSel.AutoSize = true;
            this.lbHostSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHostSel.Location = new System.Drawing.Point(5, 5);
            this.lbHostSel.Margin = new System.Windows.Forms.Padding(5);
            this.lbHostSel.Name = "lbHostSel";
            this.lbHostSel.Size = new System.Drawing.Size(84, 26);
            this.lbHostSel.TabIndex = 14;
            this.lbHostSel.Text = "Host";
            this.lbHostSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.TpnlCoDinh.SetColumnSpan(this.tableLayoutPanel6, 4);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77012F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.84606F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77012F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.84358F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77012F));
            this.tableLayoutPanel6.Controls.Add(this.btnSerDel, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbSerDel, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbbSerDel, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbbHostDel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbHostDel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(564, 34);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // btnSerDel
            // 
            this.btnSerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSerDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerDel.Location = new System.Drawing.Point(473, 5);
            this.btnSerDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnSerDel.Name = "btnSerDel";
            this.btnSerDel.Size = new System.Drawing.Size(86, 24);
            this.btnSerDel.TabIndex = 23;
            this.btnSerDel.Text = "Xoá";
            this.btnSerDel.UseVisualStyleBackColor = true;
            this.btnSerDel.Click += new System.EventHandler(this.btnSerDel_Click);
            // 
            // lbSerDel
            // 
            this.lbSerDel.AutoSize = true;
            this.lbSerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerDel.Location = new System.Drawing.Point(239, 5);
            this.lbSerDel.Margin = new System.Windows.Forms.Padding(5);
            this.lbSerDel.Name = "lbSerDel";
            this.lbSerDel.Size = new System.Drawing.Size(84, 24);
            this.lbSerDel.TabIndex = 22;
            this.lbSerDel.Text = "Server";
            this.lbSerDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSerDel
            // 
            this.cbbSerDel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSerDel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbSerDel.FormattingEnabled = true;
            this.cbbSerDel.Location = new System.Drawing.Point(333, 5);
            this.cbbSerDel.Margin = new System.Windows.Forms.Padding(5);
            this.cbbSerDel.Name = "cbbSerDel";
            this.cbbSerDel.Size = new System.Drawing.Size(130, 23);
            this.cbbSerDel.TabIndex = 21;
            // 
            // cbbHostDel
            // 
            this.cbbHostDel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbHostDel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbHostDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbHostDel.FormattingEnabled = true;
            this.cbbHostDel.Location = new System.Drawing.Point(99, 5);
            this.cbbHostDel.Margin = new System.Windows.Forms.Padding(5);
            this.cbbHostDel.Name = "cbbHostDel";
            this.cbbHostDel.Size = new System.Drawing.Size(130, 23);
            this.cbbHostDel.TabIndex = 20;
            this.cbbHostDel.SelectedIndexChanged += new System.EventHandler(this.cbbHostDel_SelectedIndexChanged);
            // 
            // lbHostDel
            // 
            this.lbHostDel.AutoSize = true;
            this.lbHostDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHostDel.Location = new System.Drawing.Point(5, 5);
            this.lbHostDel.Margin = new System.Windows.Forms.Padding(5);
            this.lbHostDel.Name = "lbHostDel";
            this.lbHostDel.Size = new System.Drawing.Size(84, 24);
            this.lbHostDel.TabIndex = 14;
            this.lbHostDel.Text = "Host";
            this.lbHostDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.TpnlCoDinh.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.txtHostAdd, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnHostAdd, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbHostAdd, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(564, 34);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // txtHostAdd
            // 
            this.txtHostAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHostAdd.Location = new System.Drawing.Point(99, 5);
            this.txtHostAdd.Margin = new System.Windows.Forms.Padding(5);
            this.txtHostAdd.Name = "txtHostAdd";
            this.txtHostAdd.Size = new System.Drawing.Size(84, 22);
            this.txtHostAdd.TabIndex = 18;
            // 
            // btnHostAdd
            // 
            this.btnHostAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHostAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostAdd.Location = new System.Drawing.Point(193, 5);
            this.btnHostAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnHostAdd.Name = "btnHostAdd";
            this.btnHostAdd.Size = new System.Drawing.Size(84, 24);
            this.btnHostAdd.TabIndex = 16;
            this.btnHostAdd.Text = "Thêm";
            this.btnHostAdd.UseVisualStyleBackColor = true;
            this.btnHostAdd.Click += new System.EventHandler(this.btnHostAdd_Click);
            // 
            // lbHostAdd
            // 
            this.lbHostAdd.AutoSize = true;
            this.lbHostAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHostAdd.Location = new System.Drawing.Point(5, 5);
            this.lbHostAdd.Margin = new System.Windows.Forms.Padding(5);
            this.lbHostAdd.Name = "lbHostAdd";
            this.lbHostAdd.Size = new System.Drawing.Size(84, 24);
            this.lbHostAdd.TabIndex = 14;
            this.lbHostAdd.Text = "Host Name";
            this.lbHostAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.TpnlCoDinh.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.txtVerAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddVer, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(282, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // txtVerAdd
            // 
            this.txtVerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVerAdd.Location = new System.Drawing.Point(5, 5);
            this.txtVerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.txtVerAdd.Name = "txtVerAdd";
            this.txtVerAdd.Size = new System.Drawing.Size(84, 22);
            this.txtVerAdd.TabIndex = 17;
            // 
            // btnAddVer
            // 
            this.btnAddVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddVer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVer.Location = new System.Drawing.Point(99, 5);
            this.btnAddVer.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddVer.Name = "btnAddVer";
            this.btnAddVer.Size = new System.Drawing.Size(84, 24);
            this.btnAddVer.TabIndex = 16;
            this.btnAddVer.Text = "Thêm";
            this.btnAddVer.UseVisualStyleBackColor = true;
            this.btnAddVer.Click += new System.EventHandler(this.btnAddVer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.TpnlCoDinh.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnVerDel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbVerDel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbVerDel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnVerDel
            // 
            this.btnVerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDel.Location = new System.Drawing.Point(193, 5);
            this.btnVerDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerDel.Name = "btnVerDel";
            this.btnVerDel.Size = new System.Drawing.Size(84, 24);
            this.btnVerDel.TabIndex = 16;
            this.btnVerDel.Text = "Xoá";
            this.btnVerDel.UseVisualStyleBackColor = true;
            this.btnVerDel.Click += new System.EventHandler(this.btnVerDel_Click);
            // 
            // cbbVerDel
            // 
            this.cbbVerDel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbVerDel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbVerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbVerDel.FormattingEnabled = true;
            this.cbbVerDel.Location = new System.Drawing.Point(99, 5);
            this.cbbVerDel.Margin = new System.Windows.Forms.Padding(5);
            this.cbbVerDel.Name = "cbbVerDel";
            this.cbbVerDel.Size = new System.Drawing.Size(84, 23);
            this.cbbVerDel.TabIndex = 15;
            // 
            // lbVerDel
            // 
            this.lbVerDel.AutoSize = true;
            this.lbVerDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVerDel.Location = new System.Drawing.Point(5, 5);
            this.lbVerDel.Margin = new System.Windows.Forms.Padding(5);
            this.lbVerDel.Name = "lbVerDel";
            this.lbVerDel.Size = new System.Drawing.Size(84, 24);
            this.lbVerDel.TabIndex = 14;
            this.lbVerDel.Text = "Version";
            this.lbVerDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrboxItem
            // 
            this.GrboxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrboxItem.Location = new System.Drawing.Point(5, 258);
            this.GrboxItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxItem.Name = "GrboxItem";
            this.GrboxItem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GrboxItem.Size = new System.Drawing.Size(856, 124);
            this.GrboxItem.TabIndex = 3;
            this.GrboxItem.TabStop = false;
            this.GrboxItem.Text = "Auto item";
            // 
            // TsmiSelectAll
            // 
            this.TsmiSelectAll.Name = "TsmiSelectAll";
            this.TsmiSelectAll.Padding = new System.Windows.Forms.Padding(0);
            this.TsmiSelectAll.Size = new System.Drawing.Size(110, 20);
            this.TsmiSelectAll.Text = "Chọn tất cả";
            this.TsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // TsmiLogin
            // 
            this.TsmiLogin.Name = "TsmiLogin";
            this.TsmiLogin.Padding = new System.Windows.Forms.Padding(0);
            this.TsmiLogin.Size = new System.Drawing.Size(110, 20);
            this.TsmiLogin.Text = "Đăng nhập";
            this.TsmiLogin.Click += new System.EventHandler(this.TsmiLogin_Click);
            // 
            // TsmiSort
            // 
            this.TsmiSort.Name = "TsmiSort";
            this.TsmiSort.Padding = new System.Windows.Forms.Padding(0);
            this.TsmiSort.Size = new System.Drawing.Size(110, 20);
            this.TsmiSort.Text = "Sắp xếp";
            this.TsmiSort.Click += new System.EventHandler(this.TsmiSort_Click);
            // 
            // TsmiClose
            // 
            this.TsmiClose.Name = "TsmiClose";
            this.TsmiClose.Padding = new System.Windows.Forms.Padding(0);
            this.TsmiClose.Size = new System.Drawing.Size(110, 20);
            this.TsmiClose.Text = "Thoát";
            this.TsmiClose.Click += new System.EventHandler(this.TsmiClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSelectAll,
            this.TsmiLogin,
            this.TsmiSort,
            this.TsmiClose});
            this.contextMenuStrip1.Name = "ContextMenuStrip";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 84);
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // QLTK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.TabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "QLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLTK_FormClosing);
            this.Load += new System.EventHandler(this.QLTK_Load);
            this.TabControlMain.ResumeLayout(false);
            this.TabPageAccount.ResumeLayout(false);
            this.PnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAccount)).EndInit();
            this.PnlInfo.ResumeLayout(false);
            this.GrboxInfo.ResumeLayout(false);
            this.TpnlInfo.ResumeLayout(false);
            this.TpnlInfo.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.TpnlBtnInfo.ResumeLayout(false);
            this.TpnlPass.ResumeLayout(false);
            this.TpnlPass.PerformLayout();
            this.TpnlSize.ResumeLayout(false);
            this.TpnlSize.PerformLayout();
            this.PnlControl.ResumeLayout(false);
            this.GrboxControl.ResumeLayout(false);
            this.TpnlControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.GrboxArea.ResumeLayout(false);
            this.TpnlArea.ResumeLayout(false);
            this.TpnlSubArea.ResumeLayout(false);
            this.TpnlSubArea.PerformLayout();
            this.GrbDieuKhien.ResumeLayout(false);
            this.TpnlDieuKhien.ResumeLayout(false);
            this.TpnlDieuKhien.PerformLayout();
            this.TpnlSubDieuKhien.ResumeLayout(false);
            this.TabPageSettings.ResumeLayout(false);
            this.PnlSetting.ResumeLayout(false);
            this.TpnlSetting.ResumeLayout(false);
            this.GrboxCoDinh.ResumeLayout(false);
            this.TpnlCoDinh.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private Panel PnlDGV;
    private Panel PnlInfo;
    private GroupBox GrboxInfo;
    private TableLayoutPanel TpnlInfo;
    private TableLayoutPanel TpnlBtnInfo;
    private Panel PnlControl;
    private ContextMenuStrip CMenuStrip;
    private ToolStripMenuItem TsmiSelectAll;
    private ToolStripMenuItem TsmiLogin;
    private ToolStripMenuItem TsmiSort;
    private ToolStripMenuItem TsmiClose;
    private TableLayoutPanel TpnlPass;
    private TableLayoutPanel TpnlSize;
    private Label LbHost;
    private Label LbGraphic;
    private Label LbSize;
    private Label LbX;
    private TextBox txtPass;
    private TextBox txtH;
    private TextBox txtW;
    private ComboBox CbbHost;
    private ComboBox CbbGraphic;
    private GroupBox GrboxControl;
    private TableLayoutPanel TpnlControl;
    private GroupBox GrboxArea;
    private TableLayoutPanel TpnlArea;
    private TableLayoutPanel TpnlSubArea;
    private GroupBox GrbDieuKhien;
    private TableLayoutPanel TpnlDieuKhien;
    private TableLayoutPanel TpnlSubDieuKhien;
    private Button BtnArea5;
    private Button BtnArea4;
    private Button BtnArea3;
    private Button BtnArea2;
    private Button BtnArea1;
    private Button BtnArea0;
    private Button BtnChangeArea;
    private Button BtnChat2;
    private Button BtnChat;
    private Button BtnLoadRight;
    private Button BtnLoadMid;
    private Button BtnLoadLeft;
    private TextBox txtArea;
    private TextBox txtChat2;
    private TextBox txtChatContent;
    private Panel PnlSetting;
    private TableLayoutPanel TpnlSetting;
    private GroupBox GrboxChucNang;
    private GroupBox GrboxTDLT;
    private GroupBox GrboxCoDinh;
    private GroupBox GrboxItem;
    private TableLayoutPanel TpnlCoDinh;
    private ContextMenuStrip contextMenuStrip1;
    private Timer Timer;
    private TextBox textBox1;
    private ComboBox cbbVerSel;
    private Label txtNote;
    private Label txtVersion;
    private TableLayoutPanel tableLayoutPanel6;
    private Label lbHostDel;
    private TableLayoutPanel tableLayoutPanel4;
    private Button btnHostAdd;
    private Label lbHostAdd;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox txtVerAdd;
    private Button btnAddVer;
    private TableLayoutPanel tableLayoutPanel1;
    private Button btnVerDel;
    private ComboBox cbbVerDel;
    private Label lbVerDel;
    private Button btnSerDel;
    private Label lbSerDel;
    private ComboBox cbbSerDel;
    private ComboBox cbbHostDel;
    private TextBox txtHostAdd;
    private TableLayoutPanel tableLayoutPanel5;
    private Button btnIPSerAdd;
    private TextBox txtIPSerAdd;
    private Label lbSerAdd;
    private ComboBox cbbHostSel;
    private Label lbHostSel;
    private DataGridView DgvAccount;
    private TableLayoutPanel tableLayoutPanel3;
    private CheckBox checkBox1;
    private Label lbInfoCharShow;
    private BindingSource DataAccount;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn graphicDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cgenderDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mapNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mapIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn zoneIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cxDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cyDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cHPDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cHPFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cMPDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cMPFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cStaminaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cMaxStaminaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPowerDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cTiemNangDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cHPGocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cMPGocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cDefGocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cCriticalGocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cDamFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cDefullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cCriticalFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetHPDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetHPFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetMPDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetMPFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetDamFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetDefullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetCriticalFullDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetStaminaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetMaxStaminaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetPowerDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cPetTiemNangDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn petStatusDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn xuDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn luongKhoaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn planetDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    private GroupBox groupBox1;
    private TableLayoutPanel tableLayoutPanel7;
    private Button BtnThaoGLT;
    private Button BtnBanhChung;
    private Button BtnBH2;
    private Button BtnBH;
    private Button BtnCN2;
    private Button BtnCN;
    private Button BtnMacGLT;
    private Button BtnGoHome;
    private Button BtnResetSB;
    private Button btnDelData;
}

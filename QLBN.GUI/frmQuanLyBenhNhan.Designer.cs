namespace QLBN.GUI
{
    partial class frmQuanLyBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBenhNhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyTinhTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTruyVet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiemBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxThongTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.lblLayNhiemTu = new System.Windows.Forms.Label();
            this.cbxLayNhiem = new System.Windows.Forms.ComboBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.btnMaBNCanXoa = new System.Windows.Forms.Button();
            this.lblMaBNCanXoa = new System.Windows.Forms.Label();
            this.txtMaBNCanXoa = new System.Windows.Forms.TextBox();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBNTXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDanhSachBenhNhan = new System.Windows.Forms.GroupBox();
            this.toolSearch = new System.Windows.Forms.ToolStrip();
            this.txtTenBenhNhanCanTim = new System.Windows.Forms.ToolStripTextBox();
            this.lblTimTenBenhNhan = new System.Windows.Forms.ToolStripLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxXoaMaBN = new System.Windows.Forms.GroupBox();
            this.lblQuanLyBenhNhan = new System.Windows.Forms.Label();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.btnQuanLyTinhTrang = new System.Windows.Forms.ToolStripButton();
            this.lblQuanLyTinhTrang = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTimKiemBenhNhan = new System.Windows.Forms.ToolStripButton();
            this.lblTimKiemBenhNhan = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTruyVet = new System.Windows.Forms.ToolStripButton();
            this.lblTruyVet = new System.Windows.Forms.ToolStripLabel();
            this.menuMain.SuspendLayout();
            this.gbxThongTinBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.gbxDanhSachBenhNhan.SuspendLayout();
            this.toolSearch.SuspendLayout();
            this.gbxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.gbxXoaMaBN.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucNang});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1344, 27);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "Quản lý chức năng";
            // 
            // menuChucNang
            // 
            this.menuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyTinhTrang,
            this.menuTruyVet,
            this.menuTimKiemBenhNhan,
            this.toolStripSeparator1,
            this.menuThoat});
            this.menuChucNang.Image = ((System.Drawing.Image)(resources.GetObject("menuChucNang.Image")));
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(108, 23);
            this.menuChucNang.Text = "Chức năng";
            // 
            // menuQuanLyTinhTrang
            // 
            this.menuQuanLyTinhTrang.Image = ((System.Drawing.Image)(resources.GetObject("menuQuanLyTinhTrang.Image")));
            this.menuQuanLyTinhTrang.Name = "menuQuanLyTinhTrang";
            this.menuQuanLyTinhTrang.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuQuanLyTinhTrang.Size = new System.Drawing.Size(269, 24);
            this.menuQuanLyTinhTrang.Text = "Quản lý tình trạng";
            this.menuQuanLyTinhTrang.Click += new System.EventHandler(this.btnQuanLyTinhTrang_Click);
            // 
            // menuTruyVet
            // 
            this.menuTruyVet.Image = ((System.Drawing.Image)(resources.GetObject("menuTruyVet.Image")));
            this.menuTruyVet.Name = "menuTruyVet";
            this.menuTruyVet.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuTruyVet.Size = new System.Drawing.Size(269, 24);
            this.menuTruyVet.Text = "Truy vết";
            this.menuTruyVet.Click += new System.EventHandler(this.btnTruyVet_Click);
            // 
            // menuTimKiemBenhNhan
            // 
            this.menuTimKiemBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("menuTimKiemBenhNhan.Image")));
            this.menuTimKiemBenhNhan.Name = "menuTimKiemBenhNhan";
            this.menuTimKiemBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuTimKiemBenhNhan.Size = new System.Drawing.Size(269, 24);
            this.menuTimKiemBenhNhan.Text = "Tìm kiếm bệnh nhân";
            this.menuTimKiemBenhNhan.Click += new System.EventHandler(this.btnTimKiemBenhNhan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(266, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = ((System.Drawing.Image)(resources.GetObject("menuThoat.Image")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(269, 24);
            this.menuThoat.Text = "Thoát";
            // 
            // gbxThongTinBenhNhan
            // 
            this.gbxThongTinBenhNhan.Controls.Add(this.lblLayNhiemTu);
            this.gbxThongTinBenhNhan.Controls.Add(this.cbxLayNhiem);
            this.gbxThongTinBenhNhan.Controls.Add(this.rtbGhiChu);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblGhiChu);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblTinhTrang);
            this.gbxThongTinBenhNhan.Controls.Add(this.cbxTinhTrang);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtTenBenhNhan);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblTenBenhNhan);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblMaBenhNhan);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtMaBenhNhan);
            this.gbxThongTinBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinBenhNhan.Location = new System.Drawing.Point(10, 110);
            this.gbxThongTinBenhNhan.Name = "gbxThongTinBenhNhan";
            this.gbxThongTinBenhNhan.Size = new System.Drawing.Size(457, 360);
            this.gbxThongTinBenhNhan.TabIndex = 71;
            this.gbxThongTinBenhNhan.TabStop = false;
            this.gbxThongTinBenhNhan.Text = "Thông Tin Bệnh Nhân";
            // 
            // lblLayNhiemTu
            // 
            this.lblLayNhiemTu.AutoSize = true;
            this.lblLayNhiemTu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayNhiemTu.Location = new System.Drawing.Point(42, 317);
            this.lblLayNhiemTu.Name = "lblLayNhiemTu";
            this.lblLayNhiemTu.Size = new System.Drawing.Size(119, 19);
            this.lblLayNhiemTu.TabIndex = 15;
            this.lblLayNhiemTu.Text = "Lây Nhiễm Từ:";
            // 
            // cbxLayNhiem
            // 
            this.cbxLayNhiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLayNhiem.FormattingEnabled = true;
            this.cbxLayNhiem.ItemHeight = 19;
            this.cbxLayNhiem.Location = new System.Drawing.Point(188, 313);
            this.cbxLayNhiem.Name = "cbxLayNhiem";
            this.cbxLayNhiem.Size = new System.Drawing.Size(221, 27);
            this.cbxLayNhiem.TabIndex = 14;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGhiChu.Location = new System.Drawing.Point(188, 182);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(221, 105);
            this.rtbGhiChu.TabIndex = 13;
            this.rtbGhiChu.Text = "";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(42, 185);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(78, 19);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(42, 134);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(96, 19);
            this.lblTinhTrang.TabIndex = 11;
            this.lblTinhTrang.Text = "Tình Trạng:";
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.ItemHeight = 19;
            this.cbxTinhTrang.Location = new System.Drawing.Point(188, 131);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(221, 27);
            this.cbxTinhTrang.TabIndex = 6;
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(188, 85);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(221, 26);
            this.txtTenBenhNhan.TabIndex = 2;
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBenhNhan.Location = new System.Drawing.Point(41, 90);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(126, 19);
            this.lblTenBenhNhan.TabIndex = 3;
            this.lblTenBenhNhan.Text = "Tên Bệnh Nhân:";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.Location = new System.Drawing.Point(42, 42);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(123, 19);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã Bênh Nhân:";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(188, 38);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(221, 26);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // btnMaBNCanXoa
            // 
            this.btnMaBNCanXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaBNCanXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaBNCanXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaBNCanXoa.Location = new System.Drawing.Point(352, 32);
            this.btnMaBNCanXoa.Name = "btnMaBNCanXoa";
            this.btnMaBNCanXoa.Size = new System.Drawing.Size(178, 46);
            this.btnMaBNCanXoa.TabIndex = 9;
            this.btnMaBNCanXoa.Text = "Nhập mã cần xoá";
            this.btnMaBNCanXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaBNCanXoa.UseVisualStyleBackColor = true;
            this.btnMaBNCanXoa.Click += new System.EventHandler(this.btnMaBNCanXoa_Click);
            // 
            // lblMaBNCanXoa
            // 
            this.lblMaBNCanXoa.AutoSize = true;
            this.lblMaBNCanXoa.Location = new System.Drawing.Point(6, 46);
            this.lblMaBNCanXoa.Name = "lblMaBNCanXoa";
            this.lblMaBNCanXoa.Size = new System.Drawing.Size(127, 19);
            this.lblMaBNCanXoa.TabIndex = 13;
            this.lblMaBNCanXoa.Text = "Mã BN Cần Xoá";
            // 
            // txtMaBNCanXoa
            // 
            this.txtMaBNCanXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBNCanXoa.Location = new System.Drawing.Point(144, 43);
            this.txtMaBNCanXoa.Name = "txtMaBNCanXoa";
            this.txtMaBNCanXoa.Size = new System.Drawing.Size(196, 27);
            this.txtMaBNCanXoa.TabIndex = 12;
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AllowUserToAddRows = false;
            this.dgvDanhSachBenhNhan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaBN,
            this.colTenBN,
            this.colTinhTrang,
            this.colGhiChu,
            this.colBNTXG});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBenhNhan.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhSachBenhNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(3, 55);
            this.dgvDanhSachBenhNhan.MultiSelect = false;
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDanhSachBenhNhan.RowHeadersVisible = false;
            this.dgvDanhSachBenhNhan.RowHeadersWidth = 45;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachBenhNhan.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(856, 447);
            this.dgvDanhSachBenhNhan.TabIndex = 60;
            this.dgvDanhSachBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBenhNhan_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaBN
            // 
            this.colMaBN.HeaderText = "Mã Bệnh Nhân";
            this.colMaBN.Name = "colMaBN";
            this.colMaBN.ReadOnly = true;
            // 
            // colTenBN
            // 
            this.colTenBN.HeaderText = "Tên Bệnh Nhân";
            this.colTenBN.Name = "colTenBN";
            this.colTenBN.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colBNTXG
            // 
            this.colBNTXG.HeaderText = "BNTXG";
            this.colBNTXG.Name = "colBNTXG";
            this.colBNTXG.ReadOnly = true;
            // 
            // gbxDanhSachBenhNhan
            // 
            this.gbxDanhSachBenhNhan.Controls.Add(this.toolSearch);
            this.gbxDanhSachBenhNhan.Controls.Add(this.dgvDanhSachBenhNhan);
            this.gbxDanhSachBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhSachBenhNhan.Location = new System.Drawing.Point(473, 65);
            this.gbxDanhSachBenhNhan.Name = "gbxDanhSachBenhNhan";
            this.gbxDanhSachBenhNhan.Size = new System.Drawing.Size(862, 505);
            this.gbxDanhSachBenhNhan.TabIndex = 74;
            this.gbxDanhSachBenhNhan.TabStop = false;
            this.gbxDanhSachBenhNhan.Text = "Danh Sách Thông Tin Bệnh Nhân";
            // 
            // toolSearch
            // 
            this.toolSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtTenBenhNhanCanTim,
            this.lblTimTenBenhNhan});
            this.toolSearch.Location = new System.Drawing.Point(3, 23);
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(856, 27);
            this.toolSearch.TabIndex = 61;
            this.toolSearch.Text = "Tìm kiếm thông tin";
            // 
            // txtTenBenhNhanCanTim
            // 
            this.txtTenBenhNhanCanTim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhanCanTim.Name = "txtTenBenhNhanCanTim";
            this.txtTenBenhNhanCanTim.Size = new System.Drawing.Size(200, 27);
            this.txtTenBenhNhanCanTim.TextChanged += new System.EventHandler(this.txtTenBenhNhanCanTim_TextChanged);
            // 
            // lblTimTenBenhNhan
            // 
            this.lblTimTenBenhNhan.Name = "lblTimTenBenhNhan";
            this.lblTimTenBenhNhan.Size = new System.Drawing.Size(159, 24);
            this.lblTimTenBenhNhan.Text = "Tên bệnh nhân cần tìm";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(13, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm/Sửa";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.Image")));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(233, 35);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(102, 42);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(122, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 42);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(345, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnAdd);
            this.gbxChucNang.Controls.Add(this.btnHuyBo);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChucNang.Location = new System.Drawing.Point(10, 476);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(457, 94);
            this.gbxChucNang.TabIndex = 73;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức Năng";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // gbxXoaMaBN
            // 
            this.gbxXoaMaBN.Controls.Add(this.btnMaBNCanXoa);
            this.gbxXoaMaBN.Controls.Add(this.lblMaBNCanXoa);
            this.gbxXoaMaBN.Controls.Add(this.txtMaBNCanXoa);
            this.gbxXoaMaBN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxXoaMaBN.Location = new System.Drawing.Point(473, 582);
            this.gbxXoaMaBN.Name = "gbxXoaMaBN";
            this.gbxXoaMaBN.Size = new System.Drawing.Size(536, 94);
            this.gbxXoaMaBN.TabIndex = 72;
            this.gbxXoaMaBN.TabStop = false;
            this.gbxXoaMaBN.Text = "Xoá Thông Tin Theo Mã Bệnh Nhân";
            // 
            // lblQuanLyBenhNhan
            // 
            this.lblQuanLyBenhNhan.AutoSize = true;
            this.lblQuanLyBenhNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyBenhNhan.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuanLyBenhNhan.Location = new System.Drawing.Point(12, 81);
            this.lblQuanLyBenhNhan.Name = "lblQuanLyBenhNhan";
            this.lblQuanLyBenhNhan.Size = new System.Drawing.Size(447, 22);
            this.lblQuanLyBenhNhan.TabIndex = 70;
            this.lblQuanLyBenhNhan.Text = "QUẢN LÝ BỆNH NHÂN COVID-19 TẠI VIỆT NAM";
            // 
            // toolMain
            // 
            this.toolMain.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLyTinhTrang,
            this.lblQuanLyTinhTrang,
            this.toolStripSeparator3,
            this.btnTimKiemBenhNhan,
            this.lblTimKiemBenhNhan,
            this.toolStripSeparator2,
            this.btnTruyVet,
            this.lblTruyVet});
            this.toolMain.Location = new System.Drawing.Point(0, 27);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1344, 25);
            this.toolMain.TabIndex = 69;
            this.toolMain.Text = "Quản lý thanh công cụ";
            // 
            // btnQuanLyTinhTrang
            // 
            this.btnQuanLyTinhTrang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuanLyTinhTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTinhTrang.Image")));
            this.btnQuanLyTinhTrang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuanLyTinhTrang.Name = "btnQuanLyTinhTrang";
            this.btnQuanLyTinhTrang.Size = new System.Drawing.Size(23, 22);
            this.btnQuanLyTinhTrang.Text = "Quản lý tình trạng";
            this.btnQuanLyTinhTrang.Click += new System.EventHandler(this.btnQuanLyTinhTrang_Click);
            // 
            // lblQuanLyTinhTrang
            // 
            this.lblQuanLyTinhTrang.Name = "lblQuanLyTinhTrang";
            this.lblQuanLyTinhTrang.Size = new System.Drawing.Size(136, 22);
            this.lblQuanLyTinhTrang.Text = "Quản lý Tình Trạng";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTimKiemBenhNhan
            // 
            this.btnTimKiemBenhNhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTimKiemBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemBenhNhan.Image")));
            this.btnTimKiemBenhNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiemBenhNhan.Name = "btnTimKiemBenhNhan";
            this.btnTimKiemBenhNhan.Size = new System.Drawing.Size(23, 22);
            this.btnTimKiemBenhNhan.Text = "Tìm kiếm bệnh nhân";
            this.btnTimKiemBenhNhan.Click += new System.EventHandler(this.btnTimKiemBenhNhan_Click);
            // 
            // lblTimKiemBenhNhan
            // 
            this.lblTimKiemBenhNhan.Name = "lblTimKiemBenhNhan";
            this.lblTimKiemBenhNhan.Size = new System.Drawing.Size(145, 22);
            this.lblTimKiemBenhNhan.Text = "Tìm kiếm bệnh nhân";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTruyVet
            // 
            this.btnTruyVet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTruyVet.Image = ((System.Drawing.Image)(resources.GetObject("btnTruyVet.Image")));
            this.btnTruyVet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruyVet.Name = "btnTruyVet";
            this.btnTruyVet.Size = new System.Drawing.Size(23, 22);
            this.btnTruyVet.Text = "Truy vết";
            this.btnTruyVet.Click += new System.EventHandler(this.btnTruyVet_Click);
            // 
            // lblTruyVet
            // 
            this.lblTruyVet.Name = "lblTruyVet";
            this.lblTruyVet.Size = new System.Drawing.Size(63, 22);
            this.lblTruyVet.Text = "Truy vết";
            // 
            // frmQuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 679);
            this.Controls.Add(this.gbxThongTinBenhNhan);
            this.Controls.Add(this.gbxDanhSachBenhNhan);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxXoaMaBN);
            this.Controls.Add(this.lblQuanLyBenhNhan);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmQuanLyBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bệnh Nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyBenhNhan_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyBenhNhan_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuanLyBenhNhan_Paint);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.gbxThongTinBenhNhan.ResumeLayout(false);
            this.gbxThongTinBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.gbxDanhSachBenhNhan.ResumeLayout(false);
            this.gbxDanhSachBenhNhan.PerformLayout();
            this.toolSearch.ResumeLayout(false);
            this.toolSearch.PerformLayout();
            this.gbxChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.gbxXoaMaBN.ResumeLayout(false);
            this.gbxXoaMaBN.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyTinhTrang;
        private System.Windows.Forms.ToolStripMenuItem menuTruyVet;
        private System.Windows.Forms.ToolStripMenuItem menuTimKiemBenhNhan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.GroupBox gbxThongTinBenhNhan;
        private System.Windows.Forms.Label lblLayNhiemTu;
        private System.Windows.Forms.ComboBox cbxLayNhiem;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Button btnMaBNCanXoa;
        private System.Windows.Forms.Label lblMaBNCanXoa;
        private System.Windows.Forms.TextBox txtMaBNCanXoa;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBNTXG;
        private System.Windows.Forms.GroupBox gbxDanhSachBenhNhan;
        private System.Windows.Forms.ToolStrip toolSearch;
        private System.Windows.Forms.ToolStripTextBox txtTenBenhNhanCanTim;
        private System.Windows.Forms.ToolStripLabel lblTimTenBenhNhan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.GroupBox gbxXoaMaBN;
        private System.Windows.Forms.Label lblQuanLyBenhNhan;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton btnQuanLyTinhTrang;
        private System.Windows.Forms.ToolStripLabel lblQuanLyTinhTrang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTimKiemBenhNhan;
        private System.Windows.Forms.ToolStripLabel lblTimKiemBenhNhan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTruyVet;
        private System.Windows.Forms.ToolStripLabel lblTruyVet;
    }
}


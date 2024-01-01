namespace QLBN.GUI
{
    partial class frmQuanLyTinhTrang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTinhTrang));
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTenTinhTrang = new System.Windows.Forms.TextBox();
            this.lblTenTinhTrang = new System.Windows.Forms.Label();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.txtTenTinhTrangCanTim = new System.Windows.Forms.ToolStripTextBox();
            this.lblTenTinhTrangCanTim = new System.Windows.Forms.ToolStripLabel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoatKhoa = new System.Windows.Forms.Button();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.gbxThongTinTinhTrang = new System.Windows.Forms.GroupBox();
            this.lblQuanLyTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.gbxDanhSach.SuspendLayout();
            this.toolMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbxChucNang.SuspendLayout();
            this.gbxThongTinTinhTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtTenTinhTrang
            // 
            this.txtTenTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTinhTrang.Location = new System.Drawing.Point(164, 82);
            this.txtTenTinhTrang.Name = "txtTenTinhTrang";
            this.txtTenTinhTrang.Size = new System.Drawing.Size(223, 27);
            this.txtTenTinhTrang.TabIndex = 1;
            // 
            // lblTenTinhTrang
            // 
            this.lblTenTinhTrang.AutoSize = true;
            this.lblTenTinhTrang.Location = new System.Drawing.Point(31, 85);
            this.lblTenTinhTrang.Name = "lblTenTinhTrang";
            this.lblTenTinhTrang.Size = new System.Drawing.Size(127, 19);
            this.lblTenTinhTrang.TabIndex = 3;
            this.lblTenTinhTrang.Text = "Tên Tình Trạng:";
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.toolMain);
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhSach.Location = new System.Drawing.Point(440, 8);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(750, 409);
            this.gbxDanhSach.TabIndex = 68;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh Sách Thông Tin";
            // 
            // toolMain
            // 
            this.toolMain.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtTenTinhTrangCanTim,
            this.lblTenTinhTrangCanTim});
            this.toolMain.Location = new System.Drawing.Point(3, 23);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(744, 25);
            this.toolMain.TabIndex = 59;
            this.toolMain.Text = "Quản Lý Loại Sách";
            // 
            // txtTenTinhTrangCanTim
            // 
            this.txtTenTinhTrangCanTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTinhTrangCanTim.Name = "txtTenTinhTrangCanTim";
            this.txtTenTinhTrangCanTim.Size = new System.Drawing.Size(200, 25);
            this.txtTenTinhTrangCanTim.TextChanged += new System.EventHandler(this.txtTenTinhTrangCanTim_TextChanged);
            // 
            // lblTenTinhTrangCanTim
            // 
            this.lblTenTinhTrangCanTim.Name = "lblTenTinhTrangCanTim";
            this.lblTenTinhTrangCanTim.Size = new System.Drawing.Size(167, 22);
            this.lblTenTinhTrangCanTim.Text = "Tìm kiếm tên tình trạng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaTT,
            this.colTenTinhTrang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 50);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(738, 353);
            this.dgvDanhSach.TabIndex = 58;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaTT
            // 
            this.colMaTT.HeaderText = "Mã Tình Trạng";
            this.colMaTT.Name = "colMaTT";
            this.colMaTT.ReadOnly = true;
            // 
            // colTenTinhTrang
            // 
            this.colTenTinhTrang.HeaderText = "Tên Tình Trạng";
            this.colTenTinhTrang.Name = "colTenTinhTrang";
            this.colTenTinhTrang.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm/Sửa";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Image = global::QLBN.GUI.Properties.Resources._3;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(205, 36);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(102, 42);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QLBN.GUI.Properties.Resources._13;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(105, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoatKhoa
            // 
            this.btnThoatKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatKhoa.Image = global::QLBN.GUI.Properties.Resources._14;
            this.btnThoatKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatKhoa.Location = new System.Drawing.Point(310, 36);
            this.btnThoatKhoa.Name = "btnThoatKhoa";
            this.btnThoatKhoa.Size = new System.Drawing.Size(96, 42);
            this.btnThoatKhoa.TabIndex = 5;
            this.btnThoatKhoa.Text = "Trở lại";
            this.btnThoatKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatKhoa.UseVisualStyleBackColor = true;
            this.btnThoatKhoa.Click += new System.EventHandler(this.btnThoatKhoa_Click);
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnAdd);
            this.gbxChucNang.Controls.Add(this.btnHuyBo);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoatKhoa);
            this.gbxChucNang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChucNang.Location = new System.Drawing.Point(11, 260);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(412, 98);
            this.gbxChucNang.TabIndex = 67;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức Năng";
            // 
            // gbxThongTinTinhTrang
            // 
            this.gbxThongTinTinhTrang.Controls.Add(this.txtTenTinhTrang);
            this.gbxThongTinTinhTrang.Controls.Add(this.lblTenTinhTrang);
            this.gbxThongTinTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinTinhTrang.Location = new System.Drawing.Point(11, 64);
            this.gbxThongTinTinhTrang.Name = "gbxThongTinTinhTrang";
            this.gbxThongTinTinhTrang.Size = new System.Drawing.Size(412, 178);
            this.gbxThongTinTinhTrang.TabIndex = 66;
            this.gbxThongTinTinhTrang.TabStop = false;
            this.gbxThongTinTinhTrang.Text = "Thông tin tình trạng bệnh nhân";
            // 
            // lblQuanLyTinhTrang
            // 
            this.lblQuanLyTinhTrang.AutoSize = true;
            this.lblQuanLyTinhTrang.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyTinhTrang.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuanLyTinhTrang.Location = new System.Drawing.Point(63, 12);
            this.lblQuanLyTinhTrang.Name = "lblQuanLyTinhTrang";
            this.lblQuanLyTinhTrang.Size = new System.Drawing.Size(320, 31);
            this.lblQuanLyTinhTrang.TabIndex = 65;
            this.lblQuanLyTinhTrang.Text = "QUẢN LÝ TÌNH TRẠNG";
            // 
            // frmQuanLyTinhTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 425);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxThongTinTinhTrang);
            this.Controls.Add(this.lblQuanLyTinhTrang);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyTinhTrang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tình Trạng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyTinhTrang_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyTinhTrang_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuanLyTinhTrang_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.gbxDanhSach.ResumeLayout(false);
            this.gbxDanhSach.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbxChucNang.ResumeLayout(false);
            this.gbxThongTinTinhTrang.ResumeLayout(false);
            this.gbxThongTinTinhTrang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripTextBox txtTenTinhTrangCanTim;
        private System.Windows.Forms.ToolStripLabel lblTenTinhTrangCanTim;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTinhTrang;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoatKhoa;
        private System.Windows.Forms.GroupBox gbxThongTinTinhTrang;
        private System.Windows.Forms.TextBox txtTenTinhTrang;
        private System.Windows.Forms.Label lblTenTinhTrang;
        private System.Windows.Forms.Label lblQuanLyTinhTrang;
    }
}
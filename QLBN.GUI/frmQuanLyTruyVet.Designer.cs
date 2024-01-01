namespace QLBN.GUI
{
    partial class frmQuanLyTruyVet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTruyVet));
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBNTXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDanhSachBenhNhan = new System.Windows.Forms.GroupBox();
            this.gbxTruyVet = new System.Windows.Forms.GroupBox();
            this.cbxLayNhiem = new System.Windows.Forms.ComboBox();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.btnThoatKhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.gbxDanhSachBenhNhan.SuspendLayout();
            this.gbxTruyVet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AllowUserToAddRows = false;
            this.dgvDanhSachBenhNhan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaBN,
            this.colTenBN,
            this.colTinhTrang,
            this.colGhiChu,
            this.colBNTXG});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBenhNhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(3, 23);
            this.dgvDanhSachBenhNhan.MultiSelect = false;
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachBenhNhan.RowHeadersVisible = false;
            this.dgvDanhSachBenhNhan.RowHeadersWidth = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachBenhNhan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(856, 479);
            this.dgvDanhSachBenhNhan.TabIndex = 60;
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
            this.gbxDanhSachBenhNhan.Controls.Add(this.dgvDanhSachBenhNhan);
            this.gbxDanhSachBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhSachBenhNhan.Location = new System.Drawing.Point(10, 133);
            this.gbxDanhSachBenhNhan.Name = "gbxDanhSachBenhNhan";
            this.gbxDanhSachBenhNhan.Size = new System.Drawing.Size(862, 505);
            this.gbxDanhSachBenhNhan.TabIndex = 72;
            this.gbxDanhSachBenhNhan.TabStop = false;
            this.gbxDanhSachBenhNhan.Text = "Danh Sách Thông Tin Bệnh Nhân";
            // 
            // gbxTruyVet
            // 
            this.gbxTruyVet.Controls.Add(this.cbxLayNhiem);
            this.gbxTruyVet.Controls.Add(this.lblBenhNhan);
            this.gbxTruyVet.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTruyVet.Location = new System.Drawing.Point(240, 20);
            this.gbxTruyVet.Name = "gbxTruyVet";
            this.gbxTruyVet.Size = new System.Drawing.Size(462, 93);
            this.gbxTruyVet.TabIndex = 73;
            this.gbxTruyVet.TabStop = false;
            this.gbxTruyVet.Text = "Truy vết theo nguồn lây nhiễm";
            // 
            // cbxLayNhiem
            // 
            this.cbxLayNhiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLayNhiem.FormattingEnabled = true;
            this.cbxLayNhiem.ItemHeight = 19;
            this.cbxLayNhiem.Location = new System.Drawing.Point(136, 41);
            this.cbxLayNhiem.Name = "cbxLayNhiem";
            this.cbxLayNhiem.Size = new System.Drawing.Size(304, 27);
            this.cbxLayNhiem.TabIndex = 15;
            this.cbxLayNhiem.SelectedIndexChanged += new System.EventHandler(this.cbxLayNhiem_SelectedIndexChanged);
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Location = new System.Drawing.Point(27, 45);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(92, 19);
            this.lblBenhNhan.TabIndex = 0;
            this.lblBenhNhan.Text = "Bệnh nhân:";
            // 
            // btnThoatKhoa
            // 
            this.btnThoatKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatKhoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatKhoa.Image = global::QLBN.GUI.Properties.Resources._14;
            this.btnThoatKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatKhoa.Location = new System.Drawing.Point(776, 83);
            this.btnThoatKhoa.Name = "btnThoatKhoa";
            this.btnThoatKhoa.Size = new System.Drawing.Size(96, 42);
            this.btnThoatKhoa.TabIndex = 74;
            this.btnThoatKhoa.Text = "Trở lại";
            this.btnThoatKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatKhoa.UseVisualStyleBackColor = true;
            this.btnThoatKhoa.Click += new System.EventHandler(this.btnThoatKhoa_Click);
            // 
            // frmQuanLyTruyVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 658);
            this.Controls.Add(this.gbxDanhSachBenhNhan);
            this.Controls.Add(this.gbxTruyVet);
            this.Controls.Add(this.btnThoatKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyTruyVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Truy Vết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyTruyVet_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyTruyVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.gbxDanhSachBenhNhan.ResumeLayout(false);
            this.gbxTruyVet.ResumeLayout(false);
            this.gbxTruyVet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBNTXG;
        private System.Windows.Forms.GroupBox gbxDanhSachBenhNhan;
        private System.Windows.Forms.GroupBox gbxTruyVet;
        private System.Windows.Forms.ComboBox cbxLayNhiem;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.Button btnThoatKhoa;
    }
}
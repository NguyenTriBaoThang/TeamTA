using QLBN.BUS;
using QLBN.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBN.GUI
{
    public partial class frmQuanLyBenhNhan : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBenhNhan));
        private const string nhanThem = "Thêm";
        private const string nhanSua = "Sửa";
        private int rowIndex = 0;
        private FormClosedEventHandler frmQuanLyTinhTrang_FormClosed;
        private FormClosedEventHandler frmQuanLyTimKiem_FormClosed;
        private FormClosedEventHandler frmQuanLyTruyVet_FormClosed;
        private readonly BenhNhanService benhNhanService = new BenhNhanService();
        private readonly TinhTrangService tinhTrangService = new TinhTrangService();

        public frmQuanLyBenhNhan()
        {
            InitializeComponent();
        }

        private void frmQuanLyBenhNhan_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.DodgerBlue, Color.LightSkyBlue, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void CustomizeGroupBox(GroupBox groupBox, Color titleColor, Color backgroundColor)
        {
            Color color1 = backgroundColor;
            Color color2 = ControlPaint.LightLight(backgroundColor);
            groupBox.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Rectangle bounds = groupBox.ClientRectangle;
                using (LinearGradientBrush brush = new LinearGradientBrush(bounds, color1, color2, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, bounds);
                }
                ControlPaint.DrawBorder3D(g, bounds, Border3DStyle.Etched, (Border3DSide)ButtonBorderStyle.Solid);
                TextRenderer.DrawText(g, groupBox.Text, groupBox.Font, new Point(bounds.Left + 6, bounds.Top), titleColor);
            };
            groupBox.BackColor = Color.LightBlue;
            groupBox.FlatStyle = FlatStyle.Flat;
            groupBox.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, groupBox.ForeColor, ButtonBorderStyle.Solid);
            };
        }

        private void setGridViewStyle(DataGridView dgvDanhSach)
        {
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSach.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDanhSach.BorderStyle = BorderStyle.Fixed3D;
            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSach.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvDanhSach.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSach.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 204, 0);
            dgvDanhSach.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDanhSach.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgvDanhSach.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            dgvDanhSach.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgvDanhSach.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
        }

        private void loadColor()
        {
            lblQuanLyBenhNhan.BackColor = Color.Transparent;
            lblMaBenhNhan.BackColor = Color.Transparent;
            lblGhiChu.BackColor = Color.Transparent;
            lblLayNhiemTu.BackColor = Color.Transparent;
            lblMaBNCanXoa.BackColor = Color.Transparent;
            lblQuanLyBenhNhan.BackColor = Color.Transparent;
            lblQuanLyTinhTrang.BackColor = Color.Transparent;
            lblTenBenhNhan.BackColor = Color.Transparent;
            lblTinhTrang.BackColor = Color.Transparent;
            setGridViewStyle(dgvDanhSachBenhNhan);
            CustomizeGroupBox(gbxChucNang, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxDanhSachBenhNhan, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxXoaMaBN, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxThongTinBenhNhan, Color.Black, Color.LightBlue);
            Image menuBackgroundImage = new Bitmap(menuMain.Width, menuMain.Height);
            using (Graphics g = Graphics.FromImage(menuBackgroundImage))
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, menuMain.Height),
                    Color.FromArgb(255, 255, 255),
                    Color.FromArgb(220, 220, 220)
                );
                g.FillRectangle(gradientBrush, new Rectangle(Point.Empty, menuBackgroundImage.Size));
            }
            menuMain.BackgroundImage = menuBackgroundImage;
            menuMain.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FillBenhNhanCombobox(List<BenhNhan> listBenhNhan)
        {
            listBenhNhan.Insert(0, new BenhNhan());
            cbxLayNhiem.DataSource = listBenhNhan;
            cbxLayNhiem.DisplayMember = "MaBN";
            cbxLayNhiem.ValueMember = "MaBN";
        }

        private void FillTinhTrangCombobox(List<TinhTrang> listTinhTrang)
        {
            listTinhTrang.Insert(0, new TinhTrang());
            cbxTinhTrang.DataSource = listTinhTrang;
            cbxTinhTrang.DisplayMember = "TenTT";
            cbxTinhTrang.ValueMember = "MaTT";
        }

        private string nguonBenh(string bntxg)
        {
            string ans; int cnt = 0;
            if (bntxg == null)
            {
                ans = "F0";
            }
            else
            {
                var listBenhNhan = benhNhanService.FindById(bntxg);
                while (true)
                {
                    if (listBenhNhan.BNTXG == null)
                    {
                        cnt += 1;
                        break;
                    }
                    else
                    {
                        cnt += 1;
                        listBenhNhan = benhNhanService.FindById(listBenhNhan.BNTXG);
                    }
                }
            }
            ans = "F" + cnt.ToString();
            return ans;
        }

        private void BindGrid(List<BenhNhan> listBenhNhan)
        {
            dgvDanhSachBenhNhan.Rows.Clear();
            int cnt = 1;
            foreach (var item in listBenhNhan)
            {
                int index = dgvDanhSachBenhNhan.Rows.Add();
                dgvDanhSachBenhNhan.Rows[index].Cells["colSTT"].Value = cnt.ToString();
                dgvDanhSachBenhNhan.Rows[index].Cells["colMaBN"].Value = item.MaBN;
                dgvDanhSachBenhNhan.Rows[index].Cells["colTenBN"].Value = item.TenBN;
                dgvDanhSachBenhNhan.Rows[index].Cells["colTinhTrang"].Value = item.TinhTrang.TenTT;
                dgvDanhSachBenhNhan.Rows[index].Cells["colGhiChu"].Value = item.GhiChu;
                dgvDanhSachBenhNhan.Rows[index].Cells["colBNTXG"].Value = nguonBenh(item.BNTXG);
                cnt++;
            }
        }

        private void frmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaBenhNhan.Focus();
                btnXoa.Enabled = false;
                btnAdd.Text = nhanThem;
                btnAdd.Image = Properties.Resources._1;
                btnMaBNCanXoa.Text = "Nhập mã cần xoá";
                btnMaBNCanXoa.Image = Properties.Resources._4;
                txtMaBNCanXoa.Enabled = false;
                btnHuyBo.Enabled = false;

                setGridViewStyle(dgvDanhSachBenhNhan);
                loadColor();
                var listBenhNhan = benhNhanService.GetAll();
                var listTinhTrang = tinhTrangService.GetAll();
                FillTinhTrangCombobox(listTinhTrang);

                BindGrid(listBenhNhan);
                FillBenhNhanCombobox(listBenhNhan);
                cbxTinhTrang.SelectedIndex = 1;
                cbxTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxLayNhiem.SelectedIndex = 0;
                cbxLayNhiem.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLyBenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void dgvDanhSachBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
            if (e.RowIndex < 0) return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvDanhSachBenhNhan.Rows[e.RowIndex];
            try
            {
                txtMaBenhNhan.Text = row.Cells["colMaBN"].Value.ToString();
                txtTenBenhNhan.Text = row.Cells["colTenBN"].Value.ToString();
                cbxTinhTrang.SelectedIndex = cbxTinhTrang.FindStringExact(row.Cells["colTinhTrang"].Value.ToString());
                rtbGhiChu.Text = row.Cells["colGhiChu"].Value.ToString();
                BenhNhan dbContext = benhNhanService.FindById(row.Cells["colMaBN"].Value.ToString());
                cbxLayNhiem.SelectedIndex = cbxLayNhiem.FindStringExact(dbContext.BNTXG);
                btnAdd.Text = nhanSua;
                btnAdd.Image = Properties.Resources._2;
                btnXoa.Enabled = true;
                btnHuyBo.Enabled = true;
                txtMaBenhNhan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addSach()
        {
            string maBN = txtMaBenhNhan.Text.ToString();
            string tenBN = txtTenBenhNhan.Text.ToString();
            string ghiChu = rtbGhiChu.Text.ToString();
            int maTT = int.Parse(cbxTinhTrang.SelectedValue.ToString());
            string bntxg = cbxLayNhiem.SelectedValue.ToString();
            BenhNhan benhNhan = new BenhNhan()
            {
                MaBN = maBN,
                TenBN = tenBN,
                MaTT = maTT,
                GhiChu = ghiChu,
                BNTXG = bntxg
            };
            benhNhanService.InsertUpdate(benhNhan);
            MessageBox.Show("Thêm mới dữ liệu thành công!”", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editSach()
        {
            string maBN = txtMaBenhNhan.Text.ToString();
            BenhNhan dbUpdate = benhNhanService.FindById(maBN);
            if (dbUpdate != null)
            {
                if (dbUpdate != null)
                {
                    dbUpdate.TenBN = txtTenBenhNhan.Text.ToString();
                    dbUpdate.GhiChu = rtbGhiChu.Text.ToString();
                    dbUpdate.MaTT = int.Parse(cbxTinhTrang.SelectedValue.ToString());
                    dbUpdate.BNTXG = cbxLayNhiem.SelectedValue.ToString();
                }
                benhNhanService.InsertUpdate(dbUpdate);
            }
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
            txtMaBenhNhan.Enabled = true;
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteData()
        {
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            txtMaBenhNhan.Clear();
            txtTenBenhNhan.Clear();
            rtbGhiChu.Clear();
            cbxLayNhiem.SelectedIndex = 0;
            cbxTinhTrang.SelectedIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear(); bool check = true;
            string maBN = txtMaBenhNhan.Text;
            if (btnAdd.Text == nhanThem)
            {
                bool isDuplicate = false;
                foreach (DataGridViewRow row in dgvDanhSachBenhNhan.Rows)
                {
                    string colmabn = row.Cells["colMaBN"].Value?.ToString();

                    if (colmabn == maBN)
                    {
                        isDuplicate = true;
                        break;
                    }
                    if (isDuplicate)
                    {
                        break;
                    }
                }
                if (isDuplicate)
                {
                    err.SetError(txtMaBenhNhan, "Mã bệnh nhân trùng lặp trong dữ liệu. Vui lòng nhập lại!");
                    check = false;
                }
            }
            if (maBN.Length != 6)
            {
                err.SetError(txtMaBenhNhan, "Mã bệnh nhân không được nhập quá 6 ký tự hoặc nhỏ hơn 6 ký tự. Vui lòng nhập lại!");
                check = false;
            }
            if (string.IsNullOrEmpty(txtMaBenhNhan.Text))
            {
                err.SetError(txtMaBenhNhan, "Mã bệnh nhân không được để trống. Vui lòng nhập đầy đủ thông tin!");
                check = false;
            }
            if (string.IsNullOrEmpty(txtTenBenhNhan.Text))
            {
                err.SetError(txtTenBenhNhan, "Tên bệnh nhân không được để trống. Vui lòng nhập đầy đủ thông tin!");
                check = false;
            }
            if (string.IsNullOrEmpty(rtbGhiChu.Text))
            {
                err.SetError(rtbGhiChu, "Ghi chú không được để trống. Vui lòng nhập đầy đủ thông tin!");
                check = false;
            }
            if (cbxTinhTrang.SelectedIndex == -1)
            {
                err.SetError(cbxTinhTrang, "Tình trạng không được để trống. Vui lòng nhập đầy đủ thông tin!");
                check = false;
            }
            if (check)
            {
                if (btnAdd.Text == nhanThem) addSach();
                else editSach();
                var listBenhNhan = benhNhanService.GetAll();
                BindGrid(listBenhNhan);
                deleteData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenBN = txtTenBenhNhan.Text.ToString();
            string maBN = txtMaBenhNhan.Text.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa: " + tenBN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            benhNhanService.DeleteSach(maBN);
            var listBenhNhan = benhNhanService.GetAll();
            BindGrid(listBenhNhan);
            deleteData();
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
            txtMaBenhNhan.Enabled = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
            txtMaBenhNhan.Enabled = true;
            deleteData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaBNCanXoa_Click(object sender, EventArgs e)
        {
            var listBenhNhan = benhNhanService.GetAll();
            if (btnMaBNCanXoa.Text == "Nhập mã cần xoá")
            {
                deleteData();
                btnMaBNCanXoa.Text = "Xoá mã sách";
                btnMaBNCanXoa.Image = Properties.Resources._13;
                txtMaBNCanXoa.Enabled = true;
                txtMaBenhNhan.Enabled = false;
                txtTenBenhNhan.Enabled = false;
                rtbGhiChu.Enabled = false;
                cbxTinhTrang.Enabled = false;
                cbxLayNhiem.Enabled = false;
            }
            else
            {
                string maToDelete = txtMaBNCanXoa.Text;
                bool exists = false;

                BenhNhan dbDelete = benhNhanService.FindById(maToDelete);
                if (dbDelete != null)
                {
                    exists = true;
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa: " + dbDelete.TenBN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        btnMaBNCanXoa.Text = "Nhập mã cần xoá";
                        btnMaBNCanXoa.Image = Properties.Resources._4;
                        txtMaBNCanXoa.Clear();
                        txtMaBNCanXoa.Enabled = false;
                        txtMaBenhNhan.Enabled = true;
                        txtTenBenhNhan.Enabled = true;
                        rtbGhiChu.Enabled = true;
                        cbxTinhTrang.Enabled = true;
                        cbxLayNhiem.Enabled = true;
                        listBenhNhan = benhNhanService.GetAll();
                        BindGrid(listBenhNhan);
                        return;
                    }
                    benhNhanService.DeleteSach(maToDelete);
                }

                if (!exists) MessageBox.Show("Không tìm thấy mã sách cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMaBNCanXoa.Text = "Nhập mã cần xoá";
                btnMaBNCanXoa.Image = Properties.Resources._4;
                txtMaBNCanXoa.Clear();
                txtMaBNCanXoa.Enabled = false;
                txtMaBenhNhan.Enabled = true;
                txtTenBenhNhan.Enabled = true;
                rtbGhiChu.Enabled = true;
                cbxTinhTrang.Enabled = true;
                cbxLayNhiem.Enabled = true;
                listBenhNhan = benhNhanService.GetAll();
                BindGrid(listBenhNhan);
            }
        }

        private void txtTenBenhNhanCanTim_TextChanged(object sender, EventArgs e)
        {
            var listBenhNhan = benhNhanService.GetAll();
            string tenSach = txtTenBenhNhanCanTim.Text.ToString();
            if (tenSach != null)
            {
                listBenhNhan = benhNhanService.GetAllTenBenhNhan(tenSach);
                BindGrid(listBenhNhan);
            }
            else
            {
                BindGrid(listBenhNhan);
            }
        }

        private void btnTruyVet_Click(object sender, EventArgs e)
        {
            frmQuanLyTruyVet frm = new frmQuanLyTruyVet();
            frm.FormClosed += frmQuanLyTruyVet_FormClosed;
            frm.Show();
        }

        private void btnQuanLyTinhTrang_Click(object sender, EventArgs e)
        {
            frmQuanLyTinhTrang frm = new frmQuanLyTinhTrang();
            frm.FormClosed += frmQuanLyTinhTrang_FormClosed;
            frm.Show();
        }

        private void btnTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            frmQuanLyTimKiem frm = new frmQuanLyTimKiem();
            frm.FormClosed += frmQuanLyTimKiem_FormClosed;
            frm.Show();
        }
    }
}

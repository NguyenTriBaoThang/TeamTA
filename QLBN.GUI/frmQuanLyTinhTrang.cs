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
    public partial class frmQuanLyTinhTrang : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTinhTrang));
        private const string nhanThem = "Thêm";
        private const string nhanSua = "Sửa";
        private int maTinhTrang;
        private int rowIndex = 0;
        private readonly TinhTrangService tinhTrangService = new TinhTrangService();

        public frmQuanLyTinhTrang()
        {
            InitializeComponent();
        }

        private void frmQuanLyTinhTrang_Paint(object sender, PaintEventArgs e)
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
            lblQuanLyTinhTrang.BackColor = Color.Transparent;
            lblTenTinhTrang.BackColor = Color.Transparent;
            setGridViewStyle(dgvDanhSach);
            CustomizeGroupBox(gbxChucNang, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxDanhSach, Color.Black, Color.LightBlue);
        }

        private void BindGrid(List<TinhTrang> listTinhTrang)
        {
            dgvDanhSach.Rows.Clear();
            int cnt = 1;
            foreach (var item in listTinhTrang)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells["colSTT"].Value = cnt.ToString();
                dgvDanhSach.Rows[index].Cells["colMaTT"].Value = item.MaTT;
                dgvDanhSach.Rows[index].Cells["colTenTinhTrang"].Value = item.TenTT;
                cnt++;
            }
        }

        private void frmQuanLyTinhTrang_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenTinhTrang.Focus();
                btnXoa.Enabled = false;
                btnAdd.Text = nhanThem;
                btnAdd.Image = Properties.Resources._1;
                btnHuyBo.Enabled = false;

                setGridViewStyle(dgvDanhSach);
                loadColor();
                var listTinhTrang = tinhTrangService.GetAll();
                BindGrid(listTinhTrang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLyTinhTrang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            frmQuanLyBenhNhan frm = new frmQuanLyBenhNhan();
            frm.Show();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
            if (e.RowIndex < 0) return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
            try
            {
                maTinhTrang = int.Parse(row.Cells["colMaTT"].Value.ToString());
                txtTenTinhTrang.Text = row.Cells["colTenTinhTrang"].Value.ToString();
                btnAdd.Text = nhanSua;
                btnAdd.Image = Properties.Resources._2;
                btnXoa.Enabled = true;
                btnHuyBo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addLoaiSach()
        {
            string tenTinhTrang = txtTenTinhTrang.Text.ToString();
            TinhTrang tinhTrang = new TinhTrang()
            {
                TenTT = tenTinhTrang
            };
            tinhTrangService.InsertUpdate(tinhTrang);
            MessageBox.Show("Thêm mới dữ liệu thành công!”", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editLoaiSach()
        {
            TinhTrang dbUpdate = tinhTrangService.FindById(maTinhTrang);
            if (dbUpdate != null)
            {
                if (dbUpdate != null)
                {
                    dbUpdate.TenTT = txtTenTinhTrang.Text.ToString();
                }
                tinhTrangService.InsertUpdate(dbUpdate);
            }
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteData()
        {
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            txtTenTinhTrang.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear(); bool check = true;
            if (string.IsNullOrEmpty(txtTenTinhTrang.Text))
            {
                err.SetError(txtTenTinhTrang, "Tên tình trạng sách không được để trống. Vui lòng nhập đầy đủ thông tin!");
                check = false;
            }
            if (check)
            {
                if (btnAdd.Text == nhanThem) addLoaiSach();
                else editLoaiSach();
                var listSach = tinhTrangService.GetAll();
                BindGrid(listSach);
                deleteData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenLoaiSach = txtTenTinhTrang.Text.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa: " + tenLoaiSach, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            tinhTrangService.DeleteLoaiSach(maTinhTrang);
            var listTinhTrang = tinhTrangService.GetAll();
            BindGrid(listTinhTrang);
            deleteData();
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            btnAdd.Text = nhanThem;
            btnAdd.Image = Properties.Resources._1;
            deleteData();
        }

        private void btnThoatKhoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenTinhTrangCanTim_TextChanged(object sender, EventArgs e)
        {
            var listTinhTrang = tinhTrangService.GetAll();
            string tenTinhTrang = txtTenTinhTrangCanTim.Text.ToString();
            if (tenTinhTrang != null)
            {
                listTinhTrang = tinhTrangService.GetAllTenLoaiSach(tenTinhTrang);
                BindGrid(listTinhTrang);
            }
            else
            {
                BindGrid(listTinhTrang);
            }
        }
    }
}

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
    public partial class frmQuanLyTimKiem : Form
    {
        private int rowIndex = 0;
        private readonly BenhNhanService benhNhanService = new BenhNhanService();
        private readonly TinhTrangService tinhTrangService = new TinhTrangService();

        public frmQuanLyTimKiem()
        {
            InitializeComponent();
        }

        private void frmQuanLyTimKiem_Paint(object sender, PaintEventArgs e)
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
            lblSoLuong.BackColor = Color.Transparent;
            lblMaBN.BackColor = Color.Transparent;
            lblMaTT.BackColor = Color.Transparent;
            lblTenBN.BackColor = Color.Transparent;
            setGridViewStyle(dgvDanhSachBenhNhan);
            CustomizeGroupBox(gbxChucNang, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxThongTin, Color.Black, Color.LightBlue);
        }

        private void FillFalcultyCombobox(List<TinhTrang> listTinhTrang)
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

        private void ThongKeBenhNhan()
        {
            int totalCount = dgvDanhSachBenhNhan.Rows.Cast<DataGridViewRow>().Count();
            txtSoLuong.Text = totalCount.ToString();
        }

        private void frmQuanLyTimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaBenhNhan.Focus();
                btnXoa.Enabled = false;
                btnHuyBo.Enabled = false;

                setGridViewStyle(dgvDanhSachBenhNhan);
                loadColor();
                var listBenhNhan = benhNhanService.GetAll();
                var listTinhTrang = tinhTrangService.GetAll();
                FillFalcultyCombobox(listTinhTrang);
                BindGrid(listBenhNhan);
                ThongKeBenhNhan();
                cbxTinhTrang.SelectedIndex = 1;
                cbxTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnXoa.Enabled = true;
                btnHuyBo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<BenhNhan> listSach;
            string maToSearch = txtMaBenhNhan.Text.ToString();
            string tenToSearch = txtTenBenhNhan.Text.ToString();
            int loaiToSearch = int.Parse(cbxTinhTrang.SelectedValue.ToString());
            listSach = benhNhanService.FindBenhNhanInformation(maToSearch, tenToSearch, loaiToSearch);
            if (listSach != null)
            {
                BindGrid(listSach);
                ThongKeBenhNhan();
            }
            else
            {
                listSach = benhNhanService.GetAll();
                BindGrid(listSach);
                ThongKeBenhNhan();
                MessageBox.Show("Bạn hãy nhập thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaBenhNhan.Text = "";
            txtTenBenhNhan.Text = "";
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            cbxTinhTrang.SelectedIndex = 1;
            var listSach = benhNhanService.GetAll();
            BindGrid(listSach);
            ThongKeBenhNhan();
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
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            txtMaBenhNhan.Clear();
            txtTenBenhNhan.Clear();
            cbxTinhTrang.SelectedIndex = 1;
            ThongKeBenhNhan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTroLaiData_Click(object sender, EventArgs e)
        {
            txtMaBenhNhan.Focus();
            txtMaBenhNhan.Clear();
            txtTenBenhNhan.Clear();
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            var listTinhTrang = tinhTrangService.GetAll();
            var listBenhNhan = benhNhanService.GetAll();
            FillFalcultyCombobox(listTinhTrang);
            BindGrid(listBenhNhan);
            cbxTinhTrang.SelectedIndex = 1;
            ThongKeBenhNhan();
        }

        private void frmQuanLyTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            frmQuanLyBenhNhan frm = new frmQuanLyBenhNhan();
            frm.Show();
        }
    }
}

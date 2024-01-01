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
    public partial class frmQuanLyTruyVet : Form
    {
        private readonly BenhNhanService benhNhanService = new BenhNhanService();

        public frmQuanLyTruyVet()
        {
            InitializeComponent();
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
            lblBenhNhan.BackColor = Color.Transparent;
            setGridViewStyle(dgvDanhSachBenhNhan);
            CustomizeGroupBox(gbxDanhSachBenhNhan, Color.Black, Color.LightBlue);
            CustomizeGroupBox(gbxTruyVet, Color.Black, Color.LightBlue);
        }

        private void FillBenhNhanCombobox(List<BenhNhan> listBenhNhan)
        {
            listBenhNhan.Insert(0, new BenhNhan());
            cbxLayNhiem.DataSource = listBenhNhan;
            cbxLayNhiem.DisplayMember = "MaBN_TenBN";
            cbxLayNhiem.ValueMember = "MaBN";
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
                dgvDanhSachBenhNhan.Rows[index].Cells["colBNTXG"].Value = item.BNTXG;
                cnt++;
            }
        }

        private void frmQuanLyTruyVet_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvDanhSachBenhNhan);
                loadColor();
                var listBenhNhan = benhNhanService.GetAll();

                BindGrid(listBenhNhan);
                FillBenhNhanCombobox(listBenhNhan);

                cbxLayNhiem.SelectedIndex = 1;
                cbxLayNhiem.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxLayNhiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLayNhiem.SelectedValue != null)
            {
                dgvDanhSachBenhNhan.Rows.Clear();
                string maBn = cbxLayNhiem.SelectedValue.ToString();
                BenhNhan listBenhNhan = benhNhanService.FindById(maBn);
                if (listBenhNhan != null)
                {
                    int cnt = 1;
                    while (true)
                    {
                        if (listBenhNhan.BNTXG == null)
                        {
                            break;
                        }
                        else
                        {
                            listBenhNhan = benhNhanService.FindById(listBenhNhan.BNTXG);
                            int index = dgvDanhSachBenhNhan.Rows.Add();
                            dgvDanhSachBenhNhan.Rows[index].Cells["colSTT"].Value = cnt.ToString();
                            dgvDanhSachBenhNhan.Rows[index].Cells["colMaBN"].Value = listBenhNhan.MaBN;
                            dgvDanhSachBenhNhan.Rows[index].Cells["colTenBN"].Value = listBenhNhan.TenBN;
                            dgvDanhSachBenhNhan.Rows[index].Cells["colTinhTrang"].Value = listBenhNhan.TinhTrang.TenTT;
                            dgvDanhSachBenhNhan.Rows[index].Cells["colGhiChu"].Value = listBenhNhan.GhiChu;
                            dgvDanhSachBenhNhan.Rows[index].Cells["colBNTXG"].Value = "F" + cnt;
                            cnt++;
                        }
                    }
                }
            }
        }

        private void btnThoatKhoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQuanLyTruyVet_FormClosing(object sender, FormClosingEventArgs e)
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

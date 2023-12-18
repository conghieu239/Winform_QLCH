using BUS_QLCH;
using DTO_QLCH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Forms
{
    public partial class FormQuanLyHoaDon : Form
    {
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        static int i;
        BLLQLHD BLLQLHD = new BLLQLHD();
        DTOQLHD hd = new DTOQLHD();
        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQLHD.showHD();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            
            FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon();
            formChiTietHoaDon.hd.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            formChiTietHoaDon.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string MaHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
                string TenKhachHang = selectedRow.Cells["TenKhachHang"].Value.ToString();
                string TenNhanVien = selectedRow.Cells["TenNhanVien"].Value.ToString();
                string TenMaGiamGia = selectedRow.Cells["TenMaGiamGia"].Value.ToString();
                string TongTien = selectedRow.Cells["TongTien"].Value.ToString();
                DateTime NgayTao = DateTime.Parse(selectedRow.Cells["NgayTao"].Value.ToString());

                // Hiển thị giá trị lên các TextBox tương ứng
                txtMaHD.Text = MaHoaDon;
                txtTenKhachHang.Text = TenKhachHang;
                txtTENNV.Text = TenNhanVien;
                txtTenMaGiam.Text = TenMaGiamGia;
                txtTongTien.Text = TongTien;
                dtpNgayTao.Value = NgayTao;
            }
        }
    }
}

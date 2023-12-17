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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        static int i;
        BLLQLNV BLLQLNV = new BLLQLNV();
        DTOQLNV nv = null;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQLNV.showNV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string MaNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                string HoTen = selectedRow.Cells["HoTen"].Value.ToString();
                string TenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString();
                string MatKhau = selectedRow.Cells["MatKhau"].Value.ToString();
                string VaiTro = selectedRow.Cells["VaiTro"].Value.ToString();

                // Hiển thị giá trị lên các TextBox tương ứng
                txtMANV.Text = MaNhanVien;
                txtTENNV.Text = HoTen;
                txtVaiTro.Text = VaiTro;
                txtTaiKhoan.Text = TenDangNhap;
                txtMatKhau.Text = MatKhau;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nv = new DTOQLNV();
            nv.hoTen = txtTENNV.Text;
            nv.maNhanVien = int.Parse(txtMANV.Text);
            nv.tenDangNhap = txtTaiKhoan.Text;
            nv.matKhau = txtMatKhau.Text;
            nv.vaiTro = txtVaiTro.Text;

            if (BLLQLNV.InsertNV(nv))
            {
                Clear();
                dataGridView1.DataSource = BLLQLNV.showNV();
            }
            else
                MessageBox.Show("Lỗi thêm mới...");
        }

        public void Clear()
        {
            txtMANV.Clear();
            txtTENNV.Clear();
            txtVaiTro.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv = new DTOQLNV();

            nv.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (BLLQLNV.DeleteNV(nv))
            {
                Clear();
                dataGridView1.DataSource = BLLQLNV.showNV();
            }
            else
                MessageBox.Show("Lỗi xóa...");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nv = new DTOQLNV();

            nv.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            nv.hoTen = txtTENNV.Text;
            nv.maNhanVien = int.Parse(txtMANV.Text);
            nv.tenDangNhap = txtTaiKhoan.Text;
            nv.matKhau = txtMatKhau.Text;
            nv.vaiTro = txtVaiTro.Text;

            if (BLLQLNV.UpdateNV(nv))
            {
                dataGridView1.DataSource = BLLQLNV.showNV();
            }
            else
                MessageBox.Show("Lỗi update...");
        }
    }
}

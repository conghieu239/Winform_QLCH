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
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        static int i;
        BLLQLKH BLLQLKH = new BLLQLKH();
        DTOQLKH kh = null;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQLKH.showKH();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            kh = new DTOQLKH();
            kh.hoTen = txtHoTen.Text;
            kh.maKhachHang = int.Parse(txtMaKH.Text);
            kh.email = txtEmail.Text;
            kh.soDienThoai = txtSDT.Text;

            if (BLLQLKH.InsertKH(kh))
            {
                Clear();
                dataGridView1.DataSource = BLLQLKH.showKH();
            }
            else
                MessageBox.Show("Lỗi thêm mới...");
        }

        public void Clear()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            kh = new DTOQLKH();

            kh.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (BLLQLKH.DeleteKH(kh))
            {
                Clear();
                dataGridView1.DataSource = BLLQLKH.showKH();
            }
            else
                MessageBox.Show("Lỗi xóa...");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kh = new DTOQLKH();

            kh.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            kh.hoTen = txtHoTen.Text;
            kh.maKhachHang = int.Parse(txtMaKH.Text);
            kh.email = txtEmail.Text;
            kh.soDienThoai = txtSDT.Text;

            if (BLLQLKH.UpdateKH(kh))
            {
                dataGridView1.DataSource = BLLQLKH.showKH();
            }
            else
                MessageBox.Show("Lỗi update...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string MaKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                string HoTen = selectedRow.Cells["HoTen"].Value.ToString();
                string Email = selectedRow.Cells["Email"].Value.ToString();
                string SoDienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString();

                // Hiển thị giá trị lên các TextBox tương ứng
                txtMaKH.Text = MaKhachHang;
                txtHoTen.Text = HoTen;
                txtEmail.Text = Email;
                txtSDT.Text = SoDienThoai;
            }
        }
    }
}

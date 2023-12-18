using DTO_QLCH;
using BUS_QLCH;
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
    public partial class FormQuanLyQuyDinh : Form
    {
        public FormQuanLyQuyDinh()
        {
            InitializeComponent();
        }

        static int i;
        BLLQLQD bLLQLQD = new BLLQLQD();
        DTOQLQD qd = null;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvQD.DataSource = bLLQLQD.showQD();
        }
        void Clear()
        {
            txtMaQuyDinh.Clear();
            txtTenQuyDinh.Clear();
            txtMoTa.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qd = new DTOQLQD();
            qd.maQuyDinh = int.Parse(txtMaQuyDinh.Text);
            qd.tenQuyDinh = txtTenQuyDinh.Text;
            qd.moTa = txtMoTa.Text;

            if (bLLQLQD.InsertQD(qd))
            {
                Clear();
                dgvQD.DataSource = bLLQLQD.showQD();
            }
            else
                MessageBox.Show("Lỗi thêm mói...");


        }

        private void dgvQD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvQD.CurrentRow.Index;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQD.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string MaQuyDinh = selectedRow.Cells["MaQuyDinh"].Value.ToString();
                string TenQuyDinh = selectedRow.Cells["TenQuyDinh"].Value.ToString();
                string Mota = selectedRow.Cells["Mota"].Value.ToString();

                // Hiển thị giá trị lên các TextBox tương ứng
                txtMaQuyDinh.Text = MaQuyDinh;
                txtTenQuyDinh.Text = TenQuyDinh;
                txtMoTa.Text = Mota;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qd = new DTOQLQD();

            qd.Key_update = dgvQD.Rows[i].Cells[0].Value.ToString();
            qd.maQuyDinh = int.Parse(txtMaQuyDinh.Text);
            qd.tenQuyDinh = txtTenQuyDinh.Text;
            qd.moTa = txtMoTa.Text;

            if (bLLQLQD.UpdateQD(qd))
            {
                dgvQD.DataSource = bLLQLQD.showQD();
            }
            else
                MessageBox.Show("Lỗi Update...");


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qd = new DTOQLQD();
            qd.Key_update = dgvQD.Rows[i].Cells[0].Value.ToString();
            if (bLLQLQD.DeleteQD(qd))
            {
                Clear();
                dgvQD.DataSource = bLLQLQD.showQD();
            }
            else
                MessageBox.Show("Lỗi xóa...");


        }
    }
}

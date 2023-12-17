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
    public partial class FormQuanLyKhuyenMai : Form
    {
        public FormQuanLyKhuyenMai()
        {
            InitializeComponent();
        }
        static int i;
        BLLQLMGG BLLQLMGG = new BLLQLMGG();
        DTOQLMGG mgg = null;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQLMGG.showMGG();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string IDMaGiamGia = selectedRow.Cells["IDMaGiamGia"].Value.ToString();
                string TenMaGiamGia = selectedRow.Cells["TenMaGiamGia"].Value.ToString();
                DateTime NgayBatDau = DateTime.Parse(selectedRow.Cells["NgayBatDau"].Value.ToString());
                DateTime NgayKetThuc = DateTime.Parse(selectedRow.Cells["NgayKetThuc"].Value.ToString());
                string SoTienGiam = selectedRow.Cells["SoTienGiam"].Value.ToString();
                string MoTa = selectedRow.Cells["MoTa"].Value.ToString();


                // Hiển thị giá trị lên các TextBox tương ứng
                txtIDMGG.Text = IDMaGiamGia;
                txtTENMGG.Text = TenMaGiamGia;
                dtpNgayBatDau.Value = NgayBatDau;
                dtpNgayKetThuc.Value = NgayKetThuc;
                txtTienGiam.Text = SoTienGiam;
                txtMoTa.Text = MoTa;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mgg = new DTOQLMGG();
            mgg.idMaGiamGia = txtIDMGG.Text;
            mgg.tenMaGiamGia = txtTENMGG.Text;
            mgg.ngayBatDau = dtpNgayBatDau.Value;
            mgg.ngayKetThuc = dtpNgayKetThuc.Value;
            mgg.soTienGiam = double.Parse(txtTienGiam.Text);
            mgg.moTa = txtMoTa.Text;

            if (BLLQLMGG.InsertMGG(mgg))
            {
                Clear();
                dataGridView1.DataSource = BLLQLMGG.showMGG();
            }
            else
                MessageBox.Show("Lỗi thêm mới...");
        }

        public void Clear()
        {
            txtIDMGG.Clear();
            txtTENMGG.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtTienGiam.Clear();
            txtMoTa.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            mgg = new DTOQLMGG();

            mgg.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (BLLQLMGG.DeleteNV(mgg))
            {
                Clear();
                dataGridView1.DataSource = BLLQLMGG.showMGG();
            }
            else
                MessageBox.Show("Lỗi xóa...");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mgg = new DTOQLMGG();

            mgg.Key_update = dataGridView1.Rows[i].Cells[0].Value.ToString();
            mgg.idMaGiamGia = txtIDMGG.Text;
            mgg.tenMaGiamGia = txtTENMGG.Text;
            mgg.ngayBatDau = dtpNgayBatDau.Value;
            mgg.ngayKetThuc = dtpNgayKetThuc.Value;
            mgg.soTienGiam = double.Parse(txtTienGiam.Text);
            mgg.moTa = txtMoTa.Text;

            if (BLLQLMGG.UpdateMGG(mgg))
            {
                dataGridView1.DataSource = BLLQLMGG.showMGG();
            }
            else
                MessageBox.Show("Lỗi update...");
        }
    }
}

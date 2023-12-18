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
    public partial class FormQuanLyDatHang : Form
    {
        public FormQuanLyDatHang()
        {
            InitializeComponent();
        }

        BLLQLDH bLLQLDH = new BLLQLDH();
        DTOQLDH dh = null;
        static int i;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDonDat.DataSource = bLLQLDH.showDH();
            dgvDonDat.Columns[0].HeaderText = "Mã đơn đặt";
            dgvDonDat.Columns[1].HeaderText = "Khách hàng";
            dgvDonDat.Columns[2].HeaderText = "Nhân viên xử lý";
            dgvDonDat.Columns[3].HeaderText = "Ngày đặt";
            dgvDonDat.Columns[4].HeaderText = "Trạng thái";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            i = dgvDonDat.CurrentRow.Index;
            dh = new DTOQLDH();

            dh.Key_update = dgvDonDat.Rows[i].Cells[0].Value.ToString();
            if (bLLQLDH.DeleteDH(dh))
            {
                dgvDonDat.DataSource = bLLQLDH.showDH();
            }
            else
                MessageBox.Show("Lỗi xóa...");


        }

        private void dgvDonDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvDonDat.CurrentRow.Index;
            string value = dgvDonDat.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvDonDat.Rows[e.RowIndex];


            }

        }
    }
}

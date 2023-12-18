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
    public partial class FormChiTietHoaDon : Form
    {
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }
        BLLCTHD BLLCTHD = new BLLCTHD();
        public DTOQLHD hd = new DTOQLHD();
        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLCTHD.showHD(hd);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

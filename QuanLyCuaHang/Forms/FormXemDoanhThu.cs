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
    public partial class FormXemDoanhThu : Form
    {
        public FormXemDoanhThu()
        {
            InitializeComponent();
        }
        BLLDT BLLDT = new BLLDT();

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLDT.showDT();
        }
    }
}

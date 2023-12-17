using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{
    public partial class TrangChu : Form
    {
        private Form activeForm;

        public TrangChu()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyNhanVien(), sender);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTrangChu(), sender);

        }
    }
}

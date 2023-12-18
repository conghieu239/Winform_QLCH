using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLCH;
using BUS_QLCH;

namespace QuanLyCuaHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DTOTaiKhoan user = new DTOTaiKhoan();
        private void btnDN_Click(object sender, EventArgs e)
        {

            user.Tendangnghap = txtTenDangNhap.Text;
            user.Mkdangnhap = txtMatKhau.Text;
            BLLTaikhoan BL = new BLLTaikhoan();
            bool loginSuccess = BL.Login(user.Tendangnghap, user.Mkdangnhap);
            if (loginSuccess)
            {
                //Đăng nhạp thành công
                TrangChu TC = new TrangChu();
                this.Hide();
                TC.ShowDialog();
            }
            else
            {
                // Đăng nhập thất bại
                DialogResult result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    DangNhap dn = new DangNhap();
                    this.Hide();
                    dn.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DangKy DK = new DangKy();
            this.Hide();
            DK.ShowDialog();
            this.Show();
        }
    }
}

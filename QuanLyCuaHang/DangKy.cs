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

namespace QuanLyCuaHang
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        DTOTaiKhoan dk = new DTOTaiKhoan();


        private void btnDK_Click(object sender, EventArgs e)
        {
            dk.Tendangnghap = txtTenDangNhap.Text;
            dk.Mkdangnhap = txtMatKhau.Text;
            BLLTaikhoan dkTaiKhoan = new BLLTaikhoan();
            bool registrationSuccess = dkTaiKhoan.RegisterUser(dk.Tendangnghap, dk.Mkdangnhap);
            if (registrationSuccess)
            {
                if (txtMatKhau.Text == txtXacNhan.Text)
                {
                    DialogResult rs = MessageBox.Show("Đăng ký thành công xin vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        DangNhap dn = new DangNhap();
                        this.Hide();
                        dn.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đảm bảo bạn nhập đúng mật khẩu vào ô xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap();
            this.Hide();
            DN.ShowDialog();
            this.Show();
        }
    }
}

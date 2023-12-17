using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLCH;

namespace DAL_QLCH
{
    public class DALQLNV : DBConnect
    {
        public DataTable showNV()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Nhan_Vien", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updateNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Nhan_Vien set MaNhanVien=@manhanvien,HoTen=@hoten,TenDangNhap=@tendangnhap, MatKhau=@matkhau,VaiTro=@vaitro where Nhan_Vien.MaNhanVien=@key", conn);
                cmd.Parameters.AddWithValue("@manhanvien", nv.maNhanVien);
                cmd.Parameters.AddWithValue("@hoten", nv.hoTen);
                cmd.Parameters.AddWithValue("@tendangnhap", nv.tenDangNhap);
                cmd.Parameters.AddWithValue("@matkhau", nv.matKhau);
                cmd.Parameters.AddWithValue("@vaitro", nv.vaiTro);
                cmd.Parameters.AddWithValue("@key", nv.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Nhan_Vien values (@manhanvien,@hoten,@tendangnhap,@matkhau,@vaitro)", conn);
                cmd.Parameters.AddWithValue("@manhanvien", nv.maNhanVien);
                cmd.Parameters.AddWithValue("@hoten", nv.hoTen);
                cmd.Parameters.AddWithValue("@tendangnhap", nv.tenDangNhap);
                cmd.Parameters.AddWithValue("@matkhau", nv.matKhau);
                cmd.Parameters.AddWithValue("@vaitro", nv.vaiTro);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Nhan_Vien where Nhan_Vien.MaNhanVien=@key", conn);

                cmd.Parameters.AddWithValue("@key", nv.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}


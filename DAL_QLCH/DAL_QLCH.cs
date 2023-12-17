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
    public class DALQLMGG : DBConnect
    {
        public DataTable showMGG()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Ma_Giam_Gia", conn);
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
        public bool updateMGG(DTOQLMGG mgg)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Ma_Giam_Gia set IDMaGiamGia=@idmagiamgia,TenMaGiamGia=@tenmagiamgia,NgayBatDau=@ngaybatdau, " +
                    "NgayKetThuc=@ngayketthuc,SoTienGiam=@sotiengiam, MoTa = @mota where Ma_Giam_Gia.IDMaGiamGia=@key", conn);
                cmd.Parameters.AddWithValue("@idmagiamgia", mgg.idMaGiamGia);
                cmd.Parameters.AddWithValue("@tenmagiamgia", mgg.tenMaGiamGia);
                cmd.Parameters.AddWithValue("@ngaybatdau", mgg.ngayBatDau);
                cmd.Parameters.AddWithValue("@ngayketthuc", mgg.ngayKetThuc);
                cmd.Parameters.AddWithValue("@sotiengiam", mgg.soTienGiam);
                cmd.Parameters.AddWithValue("@mota", mgg.moTa);
                cmd.Parameters.AddWithValue("@key", mgg.Key_update);


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
        public bool insertMGG(DTOQLMGG mgg)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Ma_Giam_Gia values (@idmagiamgia,@tenmagiamgia, @ngaybatdau, @ngayketthuc, @sotiengiam, @mota)", conn);
                cmd.Parameters.AddWithValue("@idmagiamgia", mgg.idMaGiamGia);
                cmd.Parameters.AddWithValue("@tenmagiamgia", mgg.tenMaGiamGia);
                cmd.Parameters.AddWithValue("@ngaybatdau", mgg.ngayBatDau);
                cmd.Parameters.AddWithValue("@ngayketthuc", mgg.ngayKetThuc);
                cmd.Parameters.AddWithValue("@sotiengiam", mgg.soTienGiam);
                cmd.Parameters.AddWithValue("@mota", mgg.moTa);

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
        public bool deleteMGG(DTOQLMGG mgg)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Ma_Giam_Gia where Ma_Giam_Gia.IDMaGiamGia=@key", conn);

                cmd.Parameters.AddWithValue("@key", mgg.Key_update);


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
    public class DALDT : DBConnect
    {
        public DataTable showDT()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT
                      YEAR(NgayTao) AS Nam,
                      MONTH(NgayTao) AS Thang,
                      SUM(TongTien) AS DoanhThu
                    FROM
                      Hoa_Don
                    GROUP BY
                      YEAR(NgayTao),
                      MONTH(NgayTao)
                    ORDER BY
                      Nam ASC,
                      Thang ASC;
                ";
                SqlCommand cmd = new SqlCommand(query, conn);
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
    }
}


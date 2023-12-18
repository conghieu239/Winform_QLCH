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
    public class DALQLKH : DBConnect
    {
        public DataTable showKH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Khach_Hang", conn);
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
        public bool updateKH(DTOQLKH kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Khach_Hang set MaKhachHang=@makhachhang,HoTen=@hoten,Email=@email, SoDienThoai=@sodienthoai where Khach_Hang.MaKhachHang=@key", conn);
                cmd.Parameters.AddWithValue("@makhachhang", kh.maKhachHang);
                cmd.Parameters.AddWithValue("@hoten", kh.hoTen);
                cmd.Parameters.AddWithValue("@email", kh.email);
                cmd.Parameters.AddWithValue("@sodienthoai", kh.soDienThoai);
                cmd.Parameters.AddWithValue("@key", kh.Key_update);


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
        public bool insertKH(DTOQLKH kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Khach_Hang values (@makhachhang,@hoten,@email,@sodienthoai)", conn);
                cmd.Parameters.AddWithValue("@makhachhang", kh.maKhachHang);
                cmd.Parameters.AddWithValue("@hoten", kh.hoTen);
                cmd.Parameters.AddWithValue("@email", kh.email);
                cmd.Parameters.AddWithValue("@sodienthoai", kh.soDienThoai);

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
        public bool deleteKH(DTOQLKH kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Khach_Hang where Khach_Hang.MaKhachHang=@key", conn);

                cmd.Parameters.AddWithValue("@key", kh.Key_update);


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
    public class DATaikhoan : DBConnect
    {
        public bool VerifyLogin(DTOTaiKhoan user)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DANGNHAP WHERE Tendangnhap = N'" + user.Tendangnghap + "'  AND Matkhau = N'" + user.Mkdangnhap + "'";
                SqlCommand command = new SqlCommand(query, conn);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool CheckUsernameAvailability(DTOTaiKhoan user)
        {
            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM DANGNHAP WHERE Tendangnhap = '" + user.Tendangnghap + "'";
                SqlCommand command = new SqlCommand(query, conn);

                int count = (int)command.ExecuteScalar();

                return count == 0;

            }
            finally
            {
                conn.Close();
            }
        }
        public bool RegisterUser(DTOTaiKhoan user)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO DANGNHAP VALUES ('" + user.Tendangnghap + "','" + user.Mkdangnhap + "')";
                SqlCommand command = new SqlCommand(query, conn);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;

            }
            finally
            {
                conn.Close();
            }
        }
    }
    public class DALQLQD : DBConnect
    {
        public DataTable showQD()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Quy_Dinh", conn);
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
        public bool updateQD(DTOQLQD qd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Quy_Dinh set MaQuyDinh=@maquydinh,TenQuyDinh=@tenquydinh,MoTa=@mota where Quy_Dinh.MaQuyDinh=@key", conn);
                cmd.Parameters.AddWithValue("@maquydinh", qd.maQuyDinh);
                cmd.Parameters.AddWithValue("@tenquydinh", qd.tenQuyDinh);
                cmd.Parameters.AddWithValue("@mota", qd.moTa);
                cmd.Parameters.AddWithValue("@key", qd.Key_update);


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
        public bool insertQD(DTOQLQD qd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Quy_Dinh values (@maquydinh, @tenquydinh, @mota)", conn);
                cmd.Parameters.AddWithValue("@maquydinh", qd.maQuyDinh);
                cmd.Parameters.AddWithValue("@tenquydinh", qd.tenQuyDinh);
                cmd.Parameters.AddWithValue("@mota", qd.moTa);

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
        public bool deleteQD(DTOQLQD qd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Quy_Dinh where Quy_Dinh.MaQuyDinh=@key", conn);

                cmd.Parameters.AddWithValue("@key", qd.Key_update);


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
    public class DALQLDH : DBConnect
    {

        public DataTable showDH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT\r\n  MaDatHang,\r\n  Khach_Hang.HoTen,\r\n  " +
                    "Nhan_Vien.HoTen,\r\n  NgayDat,\r\n  TrangThai\r\nFROM\r\n  Dat_Hang\r\n  JOIN Khach_Hang ON Dat_Hang.MaKhachHang = Khach_Hang.MaKhachHang\r\n  " +
                    "JOIN Nhan_Vien ON Dat_Hang.MaNhanVien = Nhan_Vien.MaNhanVien", conn);
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
        public bool deleteDH(DTOQLDH dh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Dat_Hang where Dat_Hang.MaDatHang=@key", conn);

                cmd.Parameters.AddWithValue("@key", dh.Key_update);


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
    public class DALQLHD : DBConnect
    {
        public DataTable showHD()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT HD.MaHoaDon, KH.HoTen AS TenKhachHang, NV.HoTen AS TenNhanVien, HD.NgayTao," +
                                                   "MG.TenMaGiamGia, HD.TongTien FROM Hoa_Don HD " +
                                                   "JOIN Khach_Hang KH ON HD.MaKhachHang = KH.MaKhachHang " +
                                                   "JOIN Nhan_Vien NV ON HD.MaNhanVien = NV.MaNhanVien " +
                                                   "LEFT JOIN Ma_Giam_Gia MG ON HD.IDMaGiamGia = MG.IDMaGiamGia", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // da.Dispose();

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
    public class DALCTHD : DBConnect
    {

        public DataTable showHD(DTOQLHD hd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            MaHoaDon,
                            TenHangHoa,
                            SoLuong,
                            DonGia,
                            TongTien,
                            CASE WHEN ROW_NUMBER() OVER (PARTITION BY MaHoaDon ORDER BY (SELECT NULL)) = 1 THEN TongHoaDon END AS TongHoaDon
                        FROM (
                            SELECT 
                                CTHD.MaHoaDon,
                                HH.TenHangHoa,
                                CTHD.SoLuong,
                                HH.DonGia,
                                CTHD.SoLuong * HH.DonGia AS TongTien,
                                SUM(CTHD.SoLuong * HH.DonGia) OVER (PARTITION BY CTHD.MaHoaDon) AS TongHoaDon
                            FROM 
                                Chi_Tiet_Hoa_Don CTHD
                                JOIN Hang_Hoa HH ON CTHD.MaHangHoa = HH.MaHangHoa
                            WHERE 
                                CTHD.MaHoaDon = @ma
                        ) AS Subquery", conn);
                cmd.Parameters.AddWithValue("@ma", hd.Key_update);
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCH
{
    public class DTOQLNV
    {
        int MaNhanVien;
        string HoTen;
        string TenDangNhap;
        string MatKhau;
        string VaiTro;

        private string key_update;

        public DTOQLNV(int MaNhanVien, string HoTen, string TenDangNhap, string MatKhau, string VaiTro)
        {
            this.MaNhanVien = MaNhanVien;
            this.HoTen = HoTen;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.VaiTro = VaiTro;
        }
        public DTOQLNV() { }

        public int maNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public string tenDangNhap { get => TenDangNhap; set => TenDangNhap = value; }
        public string matKhau { get => MatKhau; set => MatKhau = value; }
        public string vaiTro { get => VaiTro; set => VaiTro = value; }
        public string Key_update { get => key_update; set => key_update = value; }

    }

    public class DTOQLHH
    {
        int MaHangHoa;
        string TenHangHoa;
        string DonGia;
        int SoLuongTonKho;

        public DTOQLHH(int MaHangHoa, string TenHangHoa, string DonGia, int SoLuongTonKho)
        {
            this.MaHangHoa = MaHangHoa;
            this.TenHangHoa = TenHangHoa;
            this.DonGia = DonGia;
            this.SoLuongTonKho = SoLuongTonKho;
        }
        public DTOQLHH() { }

        public int maHangHoa { get => MaHangHoa; set => MaHangHoa = value; }
        public string tenHangHoa { get => TenHangHoa; set => TenHangHoa = value; }
        public string donGia { get => DonGia; set => DonGia = value; }
        public int soLuongTonKho { get => SoLuongTonKho; set => SoLuongTonKho = value; }
    }
    public class DTOQLKH
    {
        int MaKhachHang;
        string HoTen;
        string Email;
        string SoDienThoai;
        private string key_update;

        public DTOQLKH(int MaKhachHang, string HoTen, string Email, string SoDienThoai)
        {
            this.MaKhachHang = MaKhachHang;
            this.HoTen = HoTen;
            this.Email = Email;
            this.SoDienThoai = SoDienThoai;
        }
        public DTOQLKH() { }

        public int maKhachHang { get => MaKhachHang; set => MaKhachHang = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public string email { get => Email; set => Email = value; }
        public string soDienThoai { get => SoDienThoai; set => SoDienThoai = value; }
        public string Key_update { get => key_update; set => key_update = value; }

    }
    public class DTOQLHD
    {
        int MaHoaDon;
        int MaKhachHang;
        int MaNhanVien;
        DateTime NgayTao;
        string IDMaGiamGia;
        double TongTien;
        private string key_update;

        public DTOQLHD(int MaKhachHang, int MaHoaDon, int MaNhanVien, DateTime NgayTao, string IDMaGiamGia, double TongTien)
        {
            this.MaKhachHang = MaKhachHang;
            this.MaHoaDon = MaHoaDon;
            this.MaNhanVien = MaNhanVien;
            this.NgayTao = NgayTao;
            this.IDMaGiamGia = IDMaGiamGia;
            this.TongTien = TongTien;
        }
        public DTOQLHD() { }

        public int maKhachHang { get => MaKhachHang; set => MaKhachHang = value; }
        public int maHoaDon { get => MaHoaDon; set => MaHoaDon = value; }
        public int maNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public string idMaGiamGia { get => IDMaGiamGia; set => IDMaGiamGia = value; }
        public DateTime ngayTao { get => NgayTao; set => NgayTao = value; }
        public double tongTien { get => TongTien; set => TongTien = value; }
        public string Key_update { get => key_update; set => key_update = value; }

    }
    public class DTOQLDH
    {
        int MaDatHang;
        int MaKhachHang;
        int MaNhanVien;
        DateTime NgayDat;
        string TrangThai;
                private string key_update;


        public DTOQLDH(int MaKhachHang, int MaDatHang, int MaNhanVien, DateTime NgayDat, string TrangThai)
        {
            this.MaKhachHang = MaKhachHang;
            this.MaDatHang = MaDatHang;
            this.MaNhanVien = MaNhanVien;
            this.NgayDat = NgayDat;
            this.TrangThai = TrangThai;
        }
        public DTOQLDH() { }

        public int maKhachHang { get => MaKhachHang; set => MaKhachHang = value; }
        public int maDatHang { get => MaDatHang; set => MaDatHang = value; }
        public int maNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public string trangThai { get => TrangThai; set => TrangThai = value; }
        public DateTime ngayDat { get => NgayDat; set => NgayDat = value; }
        public string Key_update { get => key_update; set => key_update = value; }

    }
    public class DTOQLMGG
    {
        string IDMaGiamGia;
        string TenMaGiamGia;
        DateTime NgayBatDau;
        DateTime NgayKetThuc;
        double SoTienGiam;
        string MoTa;

        private string key_update;

        public DTOQLMGG(string IDMaGiamGia, string TenMaGiamGia, DateTime NgayBatDau, DateTime NgayKetThuc, double SoTienGiam, string MoTa)
        {
            this.IDMaGiamGia = IDMaGiamGia;
            this.TenMaGiamGia = TenMaGiamGia;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.SoTienGiam = SoTienGiam;
            this.MoTa = MoTa;
        }
        public DTOQLMGG() { }

        public string idMaGiamGia { get => IDMaGiamGia; set => IDMaGiamGia = value; }
        public string tenMaGiamGia { get => TenMaGiamGia; set => TenMaGiamGia = value; }
        public DateTime ngayBatDau { get => NgayBatDau; set => NgayBatDau = value; }
        public string moTa { get => MoTa; set => MoTa = value; }
        public DateTime ngayKetThuc { get => NgayKetThuc; set => NgayKetThuc = value; }
        public double soTienGiam { get => SoTienGiam; set => SoTienGiam = value;}
        public string Key_update { get => key_update; set => key_update = value; }

    }
    public class DTOQLQD
    {
        int MaQuyDinh;
        string TenQuyDinh;
        string MoTa;
        private string key_update;


        public DTOQLQD(int MaQuyDinh, string TenQuyDinh, string MoTa)
        {
            this.MaQuyDinh = MaQuyDinh;
            this.TenQuyDinh = TenQuyDinh;
            this.MoTa = MoTa;
        }
        public DTOQLQD() { }

        public int maQuyDinh { get => MaQuyDinh; set => MaQuyDinh = value; }
        public string tenQuyDinh { get => TenQuyDinh; set => TenQuyDinh = value; }
        public string moTa { get => MoTa; set => MoTa = value; }
        public string Key_update { get => key_update; set => key_update = value; }

    }
    public class DTOTaiKhoan
    {
        private string tendangnhap;
        private string mkdangnhap;
        public string Tendangnghap { get; set; }
        public string Mkdangnhap { get; set; }
        public DTOTaiKhoan(string tendangnghap, string mkdangnhap)
        {
            this.Tendangnghap = tendangnghap;
            this.Mkdangnhap = mkdangnhap;
        }
        public DTOTaiKhoan() { }
    }
}

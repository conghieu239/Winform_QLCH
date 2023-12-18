using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLCH;
using DTO_QLCH;

namespace BUS_QLCH
{
    public class BLLQLNV
    {
        DALQLNV DALQLNV = new DALQLNV();
        public DataTable showNV()
        {
            DataTable dt = DALQLNV.showNV();
            return dt;
        }
        public bool InsertNV(DTOQLNV nv)
        {
            return DALQLNV.insertNV(nv);
        }
        public bool UpdateNV(DTOQLNV nv)
        {
            return DALQLNV.updateNV(nv);
        }
        public bool DeleteNV(DTOQLNV nv)
        {
            return DALQLNV.deleteNV(nv);
        }
    }
    public class BLLQLMGG
    {
        DALQLMGG DALQLMGG = new DALQLMGG();
        public DataTable showMGG()
        {
            DataTable dt = DALQLMGG.showMGG();
            return dt;
        }
        public bool InsertMGG(DTOQLMGG mgg)
        {
            return DALQLMGG.insertMGG(mgg);
        }
        public bool UpdateMGG(DTOQLMGG mgg)
        {
            return DALQLMGG.updateMGG(mgg);
        }
        public bool DeleteNV(DTOQLMGG mgg)
        {
            return DALQLMGG.deleteMGG(mgg);
        }
    }
    public class BLLDT
    {
        DALDT DALDT = new DALDT();
        public DataTable showDT()
        {
            DataTable dt = DALDT.showDT();
            return dt;
        }
    }
    public class BLLQLKH
    {
        DALQLKH DALQLKH = new DALQLKH();
        public DataTable showKH()
        {
            DataTable dt = DALQLKH.showKH();
            return dt;
        }
        public bool InsertKH(DTOQLKH kh)
        {
            return DALQLKH.insertKH(kh);
        }
        public bool UpdateKH(DTOQLKH kh)
        {
            return DALQLKH.updateKH(kh);
        }
        public bool DeleteKH(DTOQLKH kh)
        {
            return DALQLKH.deleteKH(kh);
        }
    }
    public class BLLTaikhoan
    {
        private DATaikhoan dataAccessLayer;

        public BLLTaikhoan()
        {
            dataAccessLayer = new DATaikhoan();
        }

        public bool Login(string tendangnhap, string mkdangnhap)
        {
            DTOTaiKhoan user = new DTOTaiKhoan
            {
                Tendangnghap = tendangnhap,
                Mkdangnhap = mkdangnhap

            };
            if (dataAccessLayer != null)
            {
                // Kiểm tra thông tin đăng nhập
                bool validLogin = dataAccessLayer.VerifyLogin(user);
                return validLogin;
            }
            else
            {
                return false;
            }
        }
        public bool TenDNKhadung(string tendangnhap)
        {
            DTOTaiKhoan tk = new DTOTaiKhoan()
            {
                Tendangnghap = tendangnhap
            };
            // Kiểm tra tính khả dụng của tên đăng nhập
            return dataAccessLayer.CheckUsernameAvailability(tk);
        }
        public bool RegisterUser(string username, string password)
        {
            DTOTaiKhoan user = new DTOTaiKhoan
            {
                Tendangnghap = username,
                Mkdangnhap = password
            };
            // Kiểm tra tính khả dụng của tên đăng nhập
            if (!TenDNKhadung(username))
            {
                return false;
            }
            else
            {
                return dataAccessLayer.RegisterUser(user);
            }
        }
    }
    public class BLLQLQD
    {
        DALQLQD DALQLQD = new DALQLQD();
        public DataTable showQD()
        {
            DataTable dt = DALQLQD.showQD();
            return dt;
        }
        public bool InsertQD(DTOQLQD qd)
        {
            return DALQLQD.insertQD(qd);
        }
        public bool UpdateQD(DTOQLQD qd)
        {
            return DALQLQD.updateQD(qd);
        }
        public bool DeleteQD(DTOQLQD qd)
        {
            return DALQLQD.deleteQD(qd);
        }
    }
    public class BLLQLDH
    {
        DALQLDH DALQLDH = new DALQLDH();
        public DataTable showDH()
        {
            DataTable dt = DALQLDH.showDH();
            return dt;
        }
        public bool DeleteDH(DTOQLDH dh)
        {
            return DALQLDH.deleteDH(dh);
        }
    }
    public class BLLQLHD
    {
        DALQLHD DALQLHD = new DALQLHD();
        public DataTable showHD()
        {
            DataTable dt = DALQLHD.showHD();
            return dt;
        }
    }
    public class BLLCTHD
    {
        DALCTHD DALCTHD = new DALCTHD();

        public DataTable showHD(DTOQLHD hd)
        {
            DataTable dt = DALCTHD.showHD(hd);
            return dt;
        }
    }
}


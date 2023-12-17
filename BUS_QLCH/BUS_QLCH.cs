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
}


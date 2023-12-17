using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLCH;
using DTO_QLCH;

namespace BLLQLCH
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
}


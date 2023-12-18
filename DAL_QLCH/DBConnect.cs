using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLCH
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=CONGHIEU;Initial Catalog=QLCH2;Integrated Security=True");

    }
}

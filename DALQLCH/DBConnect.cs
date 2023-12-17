using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALQLCH
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=CONGHIEU;Initial Catalog=QLCH;Integrated Security=True");

    }
}

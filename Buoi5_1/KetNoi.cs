using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Buoi5_1
{
    internal class KetNoi
    {
        string SQLconnect;
        public KetNoi() {
            SQLconnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(SQLconnect);
            return conn;
        }
    }
}

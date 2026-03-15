using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuocPham_WinForms
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            string conn = @"Data Source=.;Initial Catalog=Do_An_QLDP;Integrated Security=True";
            return new SqlConnection(conn);
        }
    }
}

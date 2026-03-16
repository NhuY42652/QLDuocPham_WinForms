using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuocPham_WinForms
{
    class Database
    {
        private const string DefaultConnectionString = @"Data Source=.;Initial Catalog=Do_An_QLDP;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["QLDuocPham"] != null
                ? ConfigurationManager.ConnectionStrings["QLDuocPham"].ConnectionString
                : DefaultConnectionString;

            return new SqlConnection(conn);
        }
    }
}
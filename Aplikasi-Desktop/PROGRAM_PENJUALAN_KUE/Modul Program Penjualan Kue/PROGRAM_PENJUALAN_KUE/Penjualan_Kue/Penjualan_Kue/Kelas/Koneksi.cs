using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Tambahkan library koneksi ke SQL Server
using System.Data.SqlClient;

namespace Penjualan_Kue.Kelas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = MALWARE-PC; Initial Catalog = db_penjualan_kue; Integrated Security = true";
            return conn;
        }
    }
}

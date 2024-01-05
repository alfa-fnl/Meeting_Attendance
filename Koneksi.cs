using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Meeting_Attendance
{
    class Koneksi
    {
        public SqlConnection GetKoneksi() 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ALFA_INC\\ALFASERVER;Initial Catalog=db_absensi;Integrated Security=True";
            return conn;
        }
    }
}

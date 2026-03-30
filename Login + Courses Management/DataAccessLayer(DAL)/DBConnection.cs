using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login___Courses_Management.DataAccess
{
    internal class DBConnection
    {
        static SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI-Tanta;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        public static DataTable Select (SqlCommand _cmd)
        {
            DataTable td = new DataTable();
            // work with select always be in disconnected mood
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
            _cmd.Connection = con;
            adapter.Fill(td);
            return td;
        }

        public static int DML (SqlCommand _cmd)
        {
            // work with DMl always be in connected mood
            int result = 0;
            _cmd.Connection = con;
            con.Open();
            result = _cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }
    }
}

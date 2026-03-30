using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form.DAL
{
    public static class DAL
    {
        static SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Company_SD;Integrated Security=True;");
        public static DataTable RunSelect(SqlCommand _cmd)
        {
            _cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dt);
            return dt;

        }
    
        public static int RunDML(SqlCommand sqlCommand)
        {
            int affectedrows = 0;
            sqlCommand.Connection = con;

            con.Open();
            affectedrows = sqlCommand.ExecuteNonQuery();
            con.Close();
            return affectedrows;
        }
    }
}

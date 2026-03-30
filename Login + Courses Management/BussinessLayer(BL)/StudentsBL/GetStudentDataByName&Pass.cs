using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login___Courses_Management.BussinessLayer_BL_.StudentsBL
{
    internal class StudentsBL
    {
        public static DataTable GetStudentDataByNameAndPass(string name, int pass)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS WHERE USERNAME = @name AND USERPASSWORD = @pass;");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("pass", pass);
            return DataAccess.DBConnection.Select(cmd);
        }
    }
}

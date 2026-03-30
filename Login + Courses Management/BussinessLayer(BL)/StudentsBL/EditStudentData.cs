using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login___Courses_Management.BussinessLayer_BL_.StudentsBL
{
    internal class EditStudentData
    {
        public static int EditStudentInfo(string name, int pass, string track, int id)
        {
            int res = 0;
            SqlCommand cmd = new SqlCommand("UPDATE STUDENTS SET USERNAME = @name, USERPASSWORD = @pass, TRACK = @track WHERE ID = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@track", track);

            res = DataAccess.DBConnection.DML(cmd);
            return res;
        }
    }
}

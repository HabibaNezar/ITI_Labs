using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login___Courses_Management.BussinessLayer_BL_.CoursesBL
{
    internal class UpdateCourseDurationByCourseName
    {
        public static int UpdateCourseDurationBy_CourseName(string courseName, int duration)
        {
            
            SqlCommand cmd = new SqlCommand("UPDATE COURSES SET COURES_DURATION = @duration WHERE COURSENAME = @name");
            cmd.Parameters.AddWithValue("duration", duration);
            cmd.Parameters.AddWithValue("name", courseName);
            int res = DataAccess.DBConnection.DML(cmd);

            return res;
        }
    }
}

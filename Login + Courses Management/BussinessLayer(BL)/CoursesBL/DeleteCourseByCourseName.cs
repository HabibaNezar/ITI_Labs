using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Login___Courses_Management.BussinessLayer_BL_.CoursesBL
{
    internal class DeleteCourseByCourseName
    {
        public static int DeleteCourseBy_CourseName(string courseName) 
        {
            int res = 0;
            SqlCommand cmd = new SqlCommand("DELETE FROM COURSES WHERE COURSENAME = @name");
            cmd.Parameters.AddWithValue("@name", courseName);
            res = DataAccess.DBConnection.DML(cmd);

            return res;
        }
    }
}

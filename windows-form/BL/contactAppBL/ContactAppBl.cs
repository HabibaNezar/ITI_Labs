using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form.BL.contactAppBL
{
    public class ContactAppBl
    {
        // method get all 
        public static DataTable getAll()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee");
            return DAL.DAL.RunSelect(cmd);

        }
    }
}

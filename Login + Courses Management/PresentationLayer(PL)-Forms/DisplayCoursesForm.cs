using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___Courses_Management
{
    public partial class DisplayCoursesForm : Form
    {
        public int STD_id { get; set; }
        public DisplayCoursesForm(int id)
        {
            InitializeComponent();
            STD_id = id;
        }

        private void DisplayCoursesForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSES WHERE STD_ID = @id");
            cmd.Parameters.AddWithValue("id", STD_id);
            dgvDisplay.DataSource = DataAccess.DBConnection.Select(cmd);
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

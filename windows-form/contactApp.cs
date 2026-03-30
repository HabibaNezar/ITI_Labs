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
using windows_form.BL.contactAppBL;

namespace windows_form
{
    public partial class contactApp : Form
    {
        public contactApp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Company_SD;Integrated Security=True;");
            //SqlCommand cmd = new SqlCommand("select * from Employee");
            //cmd.Connection = con;

            //DataTable dataTable = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(dataTable);
            //dataGridView.DataSource = dataTable;

            dataGridView.DataSource = ContactAppBl.getAll();
        }
    }
}

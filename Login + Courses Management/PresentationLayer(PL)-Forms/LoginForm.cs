using Login___Courses_Management.BussinessLayer_BL_.StudentsBL;
using Login___Courses_Management.DataAccess;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS WHERE USERNAME = @name;");
            cmd.Parameters.AddWithValue("name", txtName.Text);
            DataTable dt = DataAccess.DBConnection.Select(cmd);

            if (dt != null && dt.Rows.Count > 0) 
            {
                MainForm mainForm = new MainForm(txtName.Text, int.Parse(txtPass.Text), Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][3].ToString());
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("this user name doesnt exist or fail to connect");
            }

                       
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

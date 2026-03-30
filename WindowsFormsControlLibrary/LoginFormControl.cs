using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsControlLibrary
{

    public partial class LoginFormControl : UserControl
    {
        
        public event EventHandler LoginSuccess;

        public LoginFormControl()
        {
            InitializeComponent();
        }

        public string InputUserName { get; set; }
        public string InputUserPassword { get; set; }

        public DataTable GetAllCourses()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI-Tanta;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT COURSENAME FROM COURSES WHERE STD_ID = 
                                        (SELECT ID FROM USERS WHERE USERNAME = @name AND USERPASSWORD = @password)", con);

            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetPersonalInfo()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI-Tanta;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM USERS WHERE USERNAME = @name", con);

            command.Parameters.AddWithValue("@name", name.Text);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;

        }

        private void Login_Click(object sender, EventArgs e)
        {
            InputUserName = name.Text;
            InputUserPassword = password.Text;
            DataTable dt = GetAllCourses();

            if (dt.Rows.Count > 0)
            {
              
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                name.Text = password.Text = string.Empty;
            }
        }

        private void LoginFormControl_Load(object sender, EventArgs e)
        {

        }
    }
}
    


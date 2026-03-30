using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginFormControl1.LoginSuccess += LoginFormControl1_LoginSuccess;
        }

        private void LoginFormControl1_LoginSuccess(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            
            DataTable courses = loginFormControl1.GetAllCourses();
            form2.dgvcourses.DataSource = courses;

            DataTable personalInfo = loginFormControl1.GetPersonalInfo();
            form2.dgvpersonalInfo.DataSource = personalInfo;

            form2.UserName.Text = loginFormControl1.InputUserName;
            form2.UserPassword.Text = loginFormControl1.InputUserPassword;
            form2.Show();
            this.Hide();
            // ونخفي الـ login control عشان نبين إننا دخلنا خلاص
            //loginFormControl1.Visible = false;

            
        }

        private void loginFormControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

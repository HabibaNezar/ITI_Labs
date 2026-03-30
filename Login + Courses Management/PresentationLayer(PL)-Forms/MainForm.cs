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
using System.Xml.Linq;

namespace Login___Courses_Management
{
    public partial class MainForm : Form
    {
        public string Name { get; set; }
        public int Pass { get; set; }
        public int ID { get; set; }
        public string Track { get; set; }

        public MainForm()
        {
        }

        public MainForm(string name, int pass, int id, string track)
        {
            InitializeComponent();
            Name = name;
            Pass = pass;
            ID = id;
            Track = track;
        }

        ////
        

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
           AddCourseForm addCourseForm = new AddCourseForm(ID);
           addCourseForm.Show();
        }

        private void btnDisplayCourses_Click(object sender, EventArgs e)
        {
            DisplayCoursesForm displayCoursesForm = new DisplayCoursesForm(ID);
            displayCoursesForm.Show();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();
            updateCourseForm.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = StudentsBL.GetStudentDataByNameAndPass(Name, Pass);

            if (dt.Rows.Count > 0)
            {
                username.Text = Name;
                trackname.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(Name,Pass,Track);
            profileForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfileForm = new EditProfileForm(Name,Pass,Track, ID);
            editProfileForm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

        }
    }
}

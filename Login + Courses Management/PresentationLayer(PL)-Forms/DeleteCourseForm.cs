using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___Courses_Management
{
    public partial class DeleteCourseForm : Form
    {
        public DeleteCourseForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           int res =  BussinessLayer_BL_.CoursesBL.DeleteCourseByCourseName.DeleteCourseBy_CourseName(txtname.Text);
            if (res > 0)
            {
                MessageBox.Show("course deleted successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("enter an existing course");
            }
        }
    }
}

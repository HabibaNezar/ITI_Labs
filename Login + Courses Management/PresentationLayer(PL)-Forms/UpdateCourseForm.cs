using Login___Courses_Management.BussinessLayer_BL_.CoursesBL;
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
    public partial class UpdateCourseForm : Form
    {
        public UpdateCourseForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int res = BussinessLayer_BL_.CoursesBL.UpdateCourseDurationByCourseName.UpdateCourseDurationBy_CourseName(txtName.Text, Convert.ToInt32(txtDuration.Text));
            if ( res > 0)
            {
                MessageBox.Show("course updated succefully");
                this.Close();

            }
            else
            {
                MessageBox.Show("enter valid existing course");
            }
        }
        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCN_Click(object sender, EventArgs e)
        {

        }
    }
}

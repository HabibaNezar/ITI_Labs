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
    public partial class AddCourseForm : Form
    {
        public int Student_ID { get; set; }
        public AddCourseForm(int std_id)
        {
            InitializeComponent();
            Student_ID = std_id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            SqlCommand cmd = new SqlCommand("INSERT INTO COURSES(COURSE_ID, COURSENAME, STD_ID, COURES_DURATION) VALUES (@course_id, @name, @std_id, @duration)");
            cmd.Parameters.AddWithValue("course_id", random.Next(1, 700));
            cmd.Parameters.AddWithValue("name", txtName.Text);
            cmd.Parameters.AddWithValue("std_id", Student_ID);
            int durationValue;
            if(int.TryParse(txtDuration.Text, out durationValue))
            {
                cmd.Parameters.AddWithValue("duration", durationValue);
            }
            else
            {
                MessageBox.Show("enter valid duration just numbers","error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int res = DataAccess.DBConnection.DML(cmd);
            if(res > 0)
            {
                MessageBox.Show("course added succefully");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("fail to connection or error in data entered");
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

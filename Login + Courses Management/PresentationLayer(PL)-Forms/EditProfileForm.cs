using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Login___Courses_Management
{
    public partial class EditProfileForm : Form
    {
        public string Name { get; set; }
        public int Pass { get; set; }
        public int ID { get; set; }
        public string Track { get; set; }
        public EditProfileForm(string name, int pass, string track, int id)
        {
            InitializeComponent();
            Name = name;
            Pass = pass;
            Track = track;
            ID = id;
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtPassword.Text = Pass.ToString();
            txtTrack.Text = Track;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Name = txtName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Pass = Convert.ToInt32(txtPassword.Text);
        }

        private void txtTrack_TextChanged(object sender, EventArgs e)
        {
            Track = txtTrack.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int res = BussinessLayer_BL_.StudentsBL.EditStudentData.EditStudentInfo(Name, Pass, Track, ID);
            if (res > 0)
            {
                MessageBox.Show("information updated successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("fail to update");
            }

        }
    }
}

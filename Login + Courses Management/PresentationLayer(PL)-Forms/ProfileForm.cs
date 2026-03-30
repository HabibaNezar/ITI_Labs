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
    public partial class ProfileForm : Form
    {
        public string Name { get; set; }
        public int Pass { get; set; }
        public string Track { get; set; }

        public ProfileForm(string name, int pass, string track)
        {
            InitializeComponent();
            Name = name;
            Pass = pass;
            Track = track;
        }

        private void labelCN_Click(object sender, EventArgs e)
        {

        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }



        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtPassword.Text = Pass.ToString();
            txtTrack.Text = Track;
        }

        
    }
}

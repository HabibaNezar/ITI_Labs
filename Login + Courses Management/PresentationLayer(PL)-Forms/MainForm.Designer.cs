namespace Login___Courses_Management
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome = new System.Windows.Forms.Label();
            this.labeltr = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.trackname = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDisplayCourses = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Courses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.welcome.Location = new System.Drawing.Point(3, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(123, 29);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome: ";
            // 
            // labeltr
            // 
            this.labeltr.AutoSize = true;
            this.labeltr.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labeltr.Location = new System.Drawing.Point(3, 38);
            this.labeltr.Name = "labeltr";
            this.labeltr.Size = new System.Drawing.Size(89, 29);
            this.labeltr.TabIndex = 1;
            this.labeltr.Text = "Track: ";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.username.Location = new System.Drawing.Point(118, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(112, 29);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            // 
            // trackname
            // 
            this.trackname.AutoSize = true;
            this.trackname.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.trackname.Location = new System.Drawing.Point(118, 38);
            this.trackname.Name = "trackname";
            this.trackname.Size = new System.Drawing.Size(122, 29);
            this.trackname.TabIndex = 3;
            this.trackname.Text = "trackname";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(676, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 39);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(64, 184);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(166, 29);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnDisplayCourses
            // 
            this.btnDisplayCourses.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCourses.Location = new System.Drawing.Point(64, 237);
            this.btnDisplayCourses.Name = "btnDisplayCourses";
            this.btnDisplayCourses.Size = new System.Drawing.Size(166, 29);
            this.btnDisplayCourses.TabIndex = 6;
            this.btnDisplayCourses.Text = "Display Courses";
            this.btnDisplayCourses.UseVisualStyleBackColor = true;
            this.btnDisplayCourses.Click += new System.EventHandler(this.btnDisplayCourses_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.Location = new System.Drawing.Point(64, 291);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(166, 29);
            this.btnUpdateCourse.TabIndex = 7;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(64, 343);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(166, 29);
            this.btnDeleteCourse.TabIndex = 8;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(487, 184);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(166, 29);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(487, 237);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 29);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Courses
            // 
            this.Courses.AutoSize = true;
            this.Courses.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Courses.Location = new System.Drawing.Point(95, 141);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(100, 29);
            this.Courses.TabIndex = 11;
            this.Courses.Text = "Courses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(446, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personal Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnDisplayCourses);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.trackname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labeltr);
            this.Controls.Add(this.welcome);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label labeltr;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDisplayCourses;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label Courses;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label username;
        public System.Windows.Forms.Label trackname;
    }
}
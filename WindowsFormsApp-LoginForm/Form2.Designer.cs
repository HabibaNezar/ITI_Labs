namespace WindowsFormsApp_LoginForm
{
    partial class Form2
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
            this.Welcome = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Track = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.courses = new System.Windows.Forms.Label();
            this.dgvcourses = new System.Windows.Forms.DataGridView();
            this.PersonalInformation = new System.Windows.Forms.Label();
            this.dgvpersonalInfo = new System.Windows.Forms.DataGridView();
            this.UpdateCourses = new System.Windows.Forms.Button();
            this.DisplayCourses = new System.Windows.Forms.Button();
            this.AddNewCourse = new System.Windows.Forms.Button();
            this.DeleteCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(12, 81);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(100, 26);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome:";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(118, 81);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(61, 26);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "label1";
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.Location = new System.Drawing.Point(12, 129);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(70, 26);
            this.Track.TabIndex = 2;
            this.Track.Text = "Track:";
            this.Track.Click += new System.EventHandler(this.Track_Click);
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(113, 129);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(66, 26);
            this.UserPassword.TabIndex = 3;
            this.UserPassword.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = " Courses Application";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(691, 29);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(97, 29);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // courses
            // 
            this.courses.AutoSize = true;
            this.courses.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.courses.Location = new System.Drawing.Point(101, 186);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(78, 26);
            this.courses.TabIndex = 7;
            this.courses.Text = "courses";
            this.courses.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dgvcourses
            // 
            this.dgvcourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourses.Location = new System.Drawing.Point(12, 215);
            this.dgvcourses.Name = "dgvcourses";
            this.dgvcourses.RowHeadersWidth = 51;
            this.dgvcourses.RowTemplate.Height = 24;
            this.dgvcourses.Size = new System.Drawing.Size(269, 97);
            this.dgvcourses.TabIndex = 8;
            this.dgvcourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PersonalInformation
            // 
            this.PersonalInformation.AutoSize = true;
            this.PersonalInformation.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PersonalInformation.Location = new System.Drawing.Point(541, 186);
            this.PersonalInformation.Name = "PersonalInformation";
            this.PersonalInformation.Size = new System.Drawing.Size(199, 26);
            this.PersonalInformation.TabIndex = 9;
            this.PersonalInformation.Text = "PersonalInformation";
            this.PersonalInformation.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dgvpersonalInfo
            // 
            this.dgvpersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonalInfo.Location = new System.Drawing.Point(486, 215);
            this.dgvpersonalInfo.Name = "dgvpersonalInfo";
            this.dgvpersonalInfo.RowHeadersWidth = 51;
            this.dgvpersonalInfo.RowTemplate.Height = 24;
            this.dgvpersonalInfo.Size = new System.Drawing.Size(302, 97);
            this.dgvpersonalInfo.TabIndex = 10;
            // 
            // UpdateCourses
            // 
            this.UpdateCourses.Location = new System.Drawing.Point(12, 327);
            this.UpdateCourses.Name = "UpdateCourses";
            this.UpdateCourses.Size = new System.Drawing.Size(111, 23);
            this.UpdateCourses.TabIndex = 11;
            this.UpdateCourses.Text = "UpdateCourses";
            this.UpdateCourses.UseVisualStyleBackColor = true;
            // 
            // DisplayCourses
            // 
            this.DisplayCourses.Location = new System.Drawing.Point(12, 356);
            this.DisplayCourses.Name = "DisplayCourses";
            this.DisplayCourses.Size = new System.Drawing.Size(111, 23);
            this.DisplayCourses.TabIndex = 12;
            this.DisplayCourses.Text = "DisplayCourses";
            this.DisplayCourses.UseVisualStyleBackColor = true;
            // 
            // AddNewCourse
            // 
            this.AddNewCourse.Location = new System.Drawing.Point(12, 385);
            this.AddNewCourse.Name = "AddNewCourse";
            this.AddNewCourse.Size = new System.Drawing.Size(111, 23);
            this.AddNewCourse.TabIndex = 13;
            this.AddNewCourse.Text = "AddNewCourse";
            this.AddNewCourse.UseVisualStyleBackColor = true;
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(12, 415);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Size = new System.Drawing.Size(111, 23);
            this.DeleteCourse.TabIndex = 14;
            this.DeleteCourse.Text = "DeleteCourse";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCourse);
            this.Controls.Add(this.AddNewCourse);
            this.Controls.Add(this.DisplayCourses);
            this.Controls.Add(this.UpdateCourses);
            this.Controls.Add(this.dgvpersonalInfo);
            this.Controls.Add(this.PersonalInformation);
            this.Controls.Add(this.dgvcourses);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Welcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label courses;
        private System.Windows.Forms.Label PersonalInformation;
        public System.Windows.Forms.DataGridView dgvcourses;
        public System.Windows.Forms.DataGridView dgvpersonalInfo;
        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Button UpdateCourses;
        private System.Windows.Forms.Button DisplayCourses;
        private System.Windows.Forms.Button AddNewCourse;
        private System.Windows.Forms.Button DeleteCourse;
    }
}
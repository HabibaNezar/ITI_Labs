namespace WindowsFormsControlLibrary
{
    public partial class LoginFormControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(66, 116);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(106, 26);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(66, 184);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(138, 26);
            this.UserPassword.TabIndex = 1;
            this.UserPassword.Text = "UserPassword";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(220, 173);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(289, 37);
            this.password.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(220, 106);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(289, 36);
            this.name.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(269, 268);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(127, 41);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Name = "LoginFormControl";
            this.Size = new System.Drawing.Size(685, 397);
            this.Load += new System.EventHandler(this.LoginFormControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Login;
    }
}

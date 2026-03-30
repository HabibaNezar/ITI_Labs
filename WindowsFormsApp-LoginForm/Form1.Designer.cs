namespace WindowsFormsApp_LoginForm
{
    partial class Form1
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
            this.loginFormControl1 = new WindowsFormsControlLibrary.LoginFormControl();
            this.SuspendLayout();
            // 
            // loginFormControl1
            // 
            this.loginFormControl1.InputUserName = null;
            this.loginFormControl1.InputUserPassword = null;
            this.loginFormControl1.Location = new System.Drawing.Point(42, 28);
            this.loginFormControl1.Name = "loginFormControl1";
            this.loginFormControl1.Size = new System.Drawing.Size(685, 397);
            this.loginFormControl1.TabIndex = 0;
            this.loginFormControl1.Load += new System.EventHandler(this.loginFormControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginFormControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.LoginFormControl loginFormControl1;
    }
}


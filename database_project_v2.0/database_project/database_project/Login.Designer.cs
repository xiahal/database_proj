namespace database_project
{
    partial class Login
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
            this.systemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.teacherLoginButton = new System.Windows.Forms.Button();
            this.managerLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.systemName.Location = new System.Drawing.Point(136, 94);
            this.systemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(468, 72);
            this.systemName.TabIndex = 0;
            this.systemName.Text = "教学管理系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(303, 236);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(241, 28);
            this.idBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(303, 288);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(241, 28);
            this.passwordBox.TabIndex = 4;
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Location = new System.Drawing.Point(67, 382);
            this.studentLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(166, 39);
            this.studentLoginButton.TabIndex = 5;
            this.studentLoginButton.Text = "学生登陆";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            this.studentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // teacherLoginButton
            // 
            this.teacherLoginButton.Location = new System.Drawing.Point(292, 382);
            this.teacherLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.teacherLoginButton.Name = "teacherLoginButton";
            this.teacherLoginButton.Size = new System.Drawing.Size(166, 39);
            this.teacherLoginButton.TabIndex = 6;
            this.teacherLoginButton.Text = "教师登录";
            this.teacherLoginButton.UseVisualStyleBackColor = true;
            this.teacherLoginButton.Click += new System.EventHandler(this.TeacherLoginButton_Click);
            // 
            // managerLoginButton
            // 
            this.managerLoginButton.Location = new System.Drawing.Point(517, 382);
            this.managerLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.managerLoginButton.Name = "managerLoginButton";
            this.managerLoginButton.Size = new System.Drawing.Size(166, 39);
            this.managerLoginButton.TabIndex = 7;
            this.managerLoginButton.Text = "管理员登陆";
            this.managerLoginButton.UseVisualStyleBackColor = true;
            this.managerLoginButton.Click += new System.EventHandler(this.ManagerLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.managerLoginButton);
            this.Controls.Add(this.teacherLoginButton);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.systemName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button studentLoginButton;
        private System.Windows.Forms.Button teacherLoginButton;
        private System.Windows.Forms.Button managerLoginButton;
    }
}
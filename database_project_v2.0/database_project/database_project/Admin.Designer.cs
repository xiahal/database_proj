namespace database_project
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aname = new System.Windows.Forms.Label();
            this.aemail = new System.Windows.Forms.Label();
            this.aid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classManageButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.teacherManageButton = new System.Windows.Forms.Button();
            this.studentManageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chooseManageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aname);
            this.groupBox1.Controls.Add(this.aemail);
            this.groupBox1.Controls.Add(this.aid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理员信息";
            // 
            // aname
            // 
            this.aname.AutoSize = true;
            this.aname.Location = new System.Drawing.Point(168, 187);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(70, 24);
            this.aname.TabIndex = 6;
            this.aname.Text = "aname";
            // 
            // aemail
            // 
            this.aemail.AutoSize = true;
            this.aemail.Location = new System.Drawing.Point(552, 88);
            this.aemail.Name = "aemail";
            this.aemail.Size = new System.Drawing.Size(82, 24);
            this.aemail.TabIndex = 5;
            this.aemail.Text = "aemail";
            // 
            // aid
            // 
            this.aid.AutoSize = true;
            this.aid.Location = new System.Drawing.Point(168, 88);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(46, 24);
            this.aid.TabIndex = 4;
            this.aid.Text = "aid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "邮箱：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // classManageButton
            // 
            this.classManageButton.Location = new System.Drawing.Point(134, 418);
            this.classManageButton.Name = "classManageButton";
            this.classManageButton.Size = new System.Drawing.Size(215, 51);
            this.classManageButton.TabIndex = 7;
            this.classManageButton.Text = "课程管理";
            this.classManageButton.UseVisualStyleBackColor = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(134, 586);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(215, 51);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "修改密码";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // teacherManageButton
            // 
            this.teacherManageButton.Location = new System.Drawing.Point(603, 418);
            this.teacherManageButton.Name = "teacherManageButton";
            this.teacherManageButton.Size = new System.Drawing.Size(215, 51);
            this.teacherManageButton.TabIndex = 10;
            this.teacherManageButton.Text = "教师管理";
            this.teacherManageButton.UseVisualStyleBackColor = true;
            // 
            // studentManageButton
            // 
            this.studentManageButton.Location = new System.Drawing.Point(603, 502);
            this.studentManageButton.Name = "studentManageButton";
            this.studentManageButton.Size = new System.Drawing.Size(215, 51);
            this.studentManageButton.TabIndex = 11;
            this.studentManageButton.Text = "学生管理";
            this.studentManageButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(603, 586);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(215, 51);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // chooseManageButton
            // 
            this.chooseManageButton.Location = new System.Drawing.Point(134, 502);
            this.chooseManageButton.Name = "chooseManageButton";
            this.chooseManageButton.Size = new System.Drawing.Size(215, 51);
            this.chooseManageButton.TabIndex = 13;
            this.chooseManageButton.Text = "选课管理";
            this.chooseManageButton.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.chooseManageButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.studentManageButton);
            this.Controls.Add(this.teacherManageButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.classManageButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "管理员界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aname;
        private System.Windows.Forms.Label aemail;
        private System.Windows.Forms.Label aid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classManageButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button teacherManageButton;
        private System.Windows.Forms.Button studentManageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button chooseManageButton;
    }
}
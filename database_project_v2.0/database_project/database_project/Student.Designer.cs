namespace database_project
{
    partial class Student
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
            this.sgrade = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.semail = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeSearchButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sgrade);
            this.groupBox1.Controls.Add(this.sname);
            this.groupBox1.Controls.Add(this.semail);
            this.groupBox1.Controls.Add(this.sid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(674, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // sgrade
            // 
            this.sgrade.AutoSize = true;
            this.sgrade.Location = new System.Drawing.Point(414, 140);
            this.sgrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sgrade.Name = "sgrade";
            this.sgrade.Size = new System.Drawing.Size(62, 18);
            this.sgrade.TabIndex = 7;
            this.sgrade.Text = "sgrade";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(126, 140);
            this.sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(53, 18);
            this.sname.TabIndex = 6;
            this.sname.Text = "sname";
            // 
            // semail
            // 
            this.semail.AutoSize = true;
            this.semail.Location = new System.Drawing.Point(414, 66);
            this.semail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semail.Name = "semail";
            this.semail.Size = new System.Drawing.Size(62, 18);
            this.semail.TabIndex = 5;
            this.semail.Text = "semail";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Location = new System.Drawing.Point(126, 66);
            this.sid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(35, 18);
            this.sid.TabIndex = 4;
            this.sid.Text = "sid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "年级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "邮箱：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // gradeSearchButton
            // 
            this.gradeSearchButton.Location = new System.Drawing.Point(86, 349);
            this.gradeSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.gradeSearchButton.Name = "gradeSearchButton";
            this.gradeSearchButton.Size = new System.Drawing.Size(196, 48);
            this.gradeSearchButton.TabIndex = 3;
            this.gradeSearchButton.Text = "成绩查询";
            this.gradeSearchButton.UseVisualStyleBackColor = true;
            this.gradeSearchButton.Click += new System.EventHandler(this.GradeSearchButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(435, 349);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(196, 48);
            this.changePasswordButton.TabIndex = 4;
            this.changePasswordButton.Text = "修改密码";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(558, 425);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.gradeSearchButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.Text = "学生界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sgrade;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label semail;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gradeSearchButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button exitButton;
    }
}
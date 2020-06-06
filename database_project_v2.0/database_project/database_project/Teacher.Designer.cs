namespace database_project
{
    partial class Teacher
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
            this.tsalary = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeInputButton = new System.Windows.Forms.Button();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tsalary);
            this.groupBox1.Controls.Add(this.tname);
            this.groupBox1.Controls.Add(this.temail);
            this.groupBox1.Controls.Add(this.tid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教师信息";
            // 
            // tsalary
            // 
            this.tsalary.AutoSize = true;
            this.tsalary.Location = new System.Drawing.Point(552, 187);
            this.tsalary.Name = "tsalary";
            this.tsalary.Size = new System.Drawing.Size(94, 24);
            this.tsalary.TabIndex = 7;
            this.tsalary.Text = "tsalary";
            // 
            // tname
            // 
            this.tname.AutoSize = true;
            this.tname.Location = new System.Drawing.Point(168, 187);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(70, 24);
            this.tname.TabIndex = 6;
            this.tname.Text = "tname";
            // 
            // temail
            // 
            this.temail.AutoSize = true;
            this.temail.Location = new System.Drawing.Point(552, 88);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(82, 24);
            this.temail.TabIndex = 5;
            this.temail.Text = "temail";
            // 
            // tid
            // 
            this.tid.AutoSize = true;
            this.tid.Location = new System.Drawing.Point(168, 88);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(46, 24);
            this.tid.TabIndex = 4;
            this.tid.Text = "tid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "工资：";
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
            // gradeInputButton
            // 
            this.gradeInputButton.Location = new System.Drawing.Point(59, 471);
            this.gradeInputButton.Name = "gradeInputButton";
            this.gradeInputButton.Size = new System.Drawing.Size(218, 60);
            this.gradeInputButton.TabIndex = 2;
            this.gradeInputButton.Text = "成绩录入";
            this.gradeInputButton.UseVisualStyleBackColor = true;
            this.gradeInputButton.Click += new System.EventHandler(this.gradeInput_Click);
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(394, 471);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(218, 60);
            this.studentSearchButton.TabIndex = 3;
            this.studentSearchButton.Text = "学生查询";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            this.studentSearchButton.Click += new System.EventHandler(this.studentSearch_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(719, 471);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(218, 60);
            this.changePasswordButton.TabIndex = 4;
            this.changePasswordButton.Text = "修改密码";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(831, 565);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(106, 64);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.studentSearchButton);
            this.Controls.Add(this.gradeInputButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Teacher";
            this.Text = "教师界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tsalary;
        private System.Windows.Forms.Label tname;
        private System.Windows.Forms.Label temail;
        private System.Windows.Forms.Label tid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gradeInputButton;
        private System.Windows.Forms.Button studentSearchButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button exitButton;
    }
}
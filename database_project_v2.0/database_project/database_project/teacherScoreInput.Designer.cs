namespace database_project
{
    partial class teacherScoreInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.studentScoreBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.classIdBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastClassIdBox = new System.Windows.Forms.TextBox();
            this.lastStudentIdBox = new System.Windows.Forms.TextBox();
            this.lastStudentScoreBox = new System.Windows.Forms.TextBox();
            this.confirmInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "成绩：";
            // 
            // studentIdBox
            // 
            this.studentIdBox.Location = new System.Drawing.Point(261, 196);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(256, 35);
            this.studentIdBox.TabIndex = 4;
            // 
            // studentScoreBox
            // 
            this.studentScoreBox.Location = new System.Drawing.Point(261, 278);
            this.studentScoreBox.Name = "studentScoreBox";
            this.studentScoreBox.Size = new System.Drawing.Size(256, 35);
            this.studentScoreBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "最近录入：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "课程号";
            // 
            // classIdBox
            // 
            this.classIdBox.FormattingEnabled = true;
            this.classIdBox.Location = new System.Drawing.Point(261, 109);
            this.classIdBox.Name = "classIdBox";
            this.classIdBox.Size = new System.Drawing.Size(256, 32);
            this.classIdBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "学生号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "成绩";
            // 
            // lastClassIdBox
            // 
            this.lastClassIdBox.Location = new System.Drawing.Point(261, 487);
            this.lastClassIdBox.Name = "lastClassIdBox";
            this.lastClassIdBox.Size = new System.Drawing.Size(176, 35);
            this.lastClassIdBox.TabIndex = 11;
            // 
            // lastStudentIdBox
            // 
            this.lastStudentIdBox.Location = new System.Drawing.Point(475, 487);
            this.lastStudentIdBox.Name = "lastStudentIdBox";
            this.lastStudentIdBox.Size = new System.Drawing.Size(176, 35);
            this.lastStudentIdBox.TabIndex = 12;
            // 
            // lastStudentScoreBox
            // 
            this.lastStudentScoreBox.Location = new System.Drawing.Point(693, 487);
            this.lastStudentScoreBox.Name = "lastStudentScoreBox";
            this.lastStudentScoreBox.Size = new System.Drawing.Size(176, 35);
            this.lastStudentScoreBox.TabIndex = 13;
            // 
            // confirmInputButton
            // 
            this.confirmInputButton.Location = new System.Drawing.Point(649, 278);
            this.confirmInputButton.Name = "confirmInputButton";
            this.confirmInputButton.Size = new System.Drawing.Size(150, 35);
            this.confirmInputButton.TabIndex = 14;
            this.confirmInputButton.Text = "确认";
            this.confirmInputButton.UseVisualStyleBackColor = true;
            this.confirmInputButton.Click += new System.EventHandler(this.confirmInput_Click);
            // 
            // teacherScoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.confirmInputButton);
            this.Controls.Add(this.lastStudentScoreBox);
            this.Controls.Add(this.lastStudentIdBox);
            this.Controls.Add(this.lastClassIdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classIdBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentScoreBox);
            this.Controls.Add(this.studentIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "teacherScoreInput";
            this.Text = "成绩录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.TextBox studentScoreBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox classIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastClassIdBox;
        private System.Windows.Forms.TextBox lastStudentIdBox;
        private System.Windows.Forms.TextBox lastStudentScoreBox;
        private System.Windows.Forms.Button confirmInputButton;
    }
}
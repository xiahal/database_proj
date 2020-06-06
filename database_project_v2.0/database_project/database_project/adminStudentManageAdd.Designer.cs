namespace database_project
{
    partial class adminStudentManageAdd
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.studentGradeBox = new System.Windows.Forms.TextBox();
            this.studentNumBox = new System.Windows.Forms.TextBox();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentMailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(407, 504);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(188, 58);
            this.confirmButton.TabIndex = 19;
            this.confirmButton.Text = "确认添加";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // studentGradeBox
            // 
            this.studentGradeBox.Location = new System.Drawing.Point(476, 313);
            this.studentGradeBox.Name = "studentGradeBox";
            this.studentGradeBox.Size = new System.Drawing.Size(274, 35);
            this.studentGradeBox.TabIndex = 18;
            // 
            // studentNumBox
            // 
            this.studentNumBox.Location = new System.Drawing.Point(476, 217);
            this.studentNumBox.Name = "studentNumBox";
            this.studentNumBox.Size = new System.Drawing.Size(274, 35);
            this.studentNumBox.TabIndex = 17;
            // 
            // studentNameBox
            // 
            this.studentNameBox.Location = new System.Drawing.Point(476, 124);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(274, 35);
            this.studentNameBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "年级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "姓名：";
            // 
            // studentMailBox
            // 
            this.studentMailBox.Location = new System.Drawing.Point(476, 400);
            this.studentMailBox.Name = "studentMailBox";
            this.studentMailBox.Size = new System.Drawing.Size(274, 35);
            this.studentMailBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "邮箱号：";
            // 
            // adminStudentManageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.studentMailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.studentGradeBox);
            this.Controls.Add(this.studentNumBox);
            this.Controls.Add(this.studentNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "adminStudentManageAdd";
            this.Text = "新建学生";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox studentGradeBox;
        private System.Windows.Forms.TextBox studentNumBox;
        private System.Windows.Forms.TextBox studentNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentMailBox;
        private System.Windows.Forms.Label label4;
    }
}
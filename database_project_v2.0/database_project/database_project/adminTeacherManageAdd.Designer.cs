namespace database_project
{
    partial class adminTeacherManageAdd
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
            this.teacherMailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.teacherSalaryBox = new System.Windows.Forms.TextBox();
            this.teacherNumBox = new System.Windows.Forms.TextBox();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teacherMailBox
            // 
            this.teacherMailBox.Location = new System.Drawing.Point(476, 396);
            this.teacherMailBox.Name = "teacherMailBox";
            this.teacherMailBox.Size = new System.Drawing.Size(274, 35);
            this.teacherMailBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "邮箱号：";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(407, 500);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(188, 58);
            this.confirmButton.TabIndex = 28;
            this.confirmButton.Text = "确认添加";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // teacherSalaryBox
            // 
            this.teacherSalaryBox.Location = new System.Drawing.Point(476, 309);
            this.teacherSalaryBox.Name = "teacherSalaryBox";
            this.teacherSalaryBox.Size = new System.Drawing.Size(274, 35);
            this.teacherSalaryBox.TabIndex = 27;
            // 
            // teacherNumBox
            // 
            this.teacherNumBox.Location = new System.Drawing.Point(476, 213);
            this.teacherNumBox.Name = "teacherNumBox";
            this.teacherNumBox.Size = new System.Drawing.Size(274, 35);
            this.teacherNumBox.TabIndex = 26;
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(476, 120);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(274, 35);
            this.teacherNameBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "工资：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "工号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "姓名：";
            // 
            // adminTeacherManageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.teacherMailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.teacherSalaryBox);
            this.Controls.Add(this.teacherNumBox);
            this.Controls.Add(this.teacherNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminTeacherManageAdd";
            this.Text = "新建教师";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teacherMailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox teacherSalaryBox;
        private System.Windows.Forms.TextBox teacherNumBox;
        private System.Windows.Forms.TextBox teacherNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
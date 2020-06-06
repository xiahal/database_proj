namespace database_project
{
    partial class adminScManageChange
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
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.classNumBox = new System.Windows.Forms.TextBox();
            this.studentNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(395, 500);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(188, 58);
            this.confirmButton.TabIndex = 35;
            this.confirmButton.Text = "确认修改";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(464, 309);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(274, 35);
            this.gradeBox.TabIndex = 34;
            // 
            // classNumBox
            // 
            this.classNumBox.Location = new System.Drawing.Point(464, 213);
            this.classNumBox.Name = "classNumBox";
            this.classNumBox.Size = new System.Drawing.Size(274, 35);
            this.classNumBox.TabIndex = 33;
            // 
            // studentNumBox
            // 
            this.studentNumBox.Location = new System.Drawing.Point(464, 120);
            this.studentNumBox.Name = "studentNumBox";
            this.studentNumBox.Size = new System.Drawing.Size(274, 35);
            this.studentNumBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "成绩：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "课程号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "学号：";
            // 
            // adminScManageChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.classNumBox);
            this.Controls.Add(this.studentNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminScManageChange";
            this.Text = "修改选课";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.TextBox classNumBox;
        private System.Windows.Forms.TextBox studentNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
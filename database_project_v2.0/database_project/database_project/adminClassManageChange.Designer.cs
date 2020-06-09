namespace database_project
{
    partial class adminClassManageChange
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
            this.teacherBox = new System.Windows.Forms.TextBox();
            this.classNameBox = new System.Windows.Forms.TextBox();
            this.classNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(307, 372);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(141, 44);
            this.confirmButton.TabIndex = 19;
            this.confirmButton.Text = "确认修改";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // teacherBox
            // 
            this.teacherBox.Location = new System.Drawing.Point(357, 235);
            this.teacherBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(206, 28);
            this.teacherBox.TabIndex = 18;
            // 
            // classNameBox
            // 
            this.classNameBox.Location = new System.Drawing.Point(357, 163);
            this.classNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classNameBox.Name = "classNameBox";
            this.classNameBox.Size = new System.Drawing.Size(206, 28);
            this.classNameBox.TabIndex = 17;
            // 
            // classNumBox
            // 
            this.classNumBox.Location = new System.Drawing.Point(357, 93);
            this.classNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classNumBox.Name = "classNumBox";
            this.classNumBox.Size = new System.Drawing.Size(206, 28);
            this.classNumBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "新授课教师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "新课程名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "新课程号：";
            // 
            // adminClassManageChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.teacherBox);
            this.Controls.Add(this.classNameBox);
            this.Controls.Add(this.classNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminClassManageChange";
            this.Text = "课程修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.TextBox classNameBox;
        private System.Windows.Forms.TextBox classNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
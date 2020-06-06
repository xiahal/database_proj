namespace database_project
{
    partial class adminClassManageAdd
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
            this.teacherBox = new System.Windows.Forms.TextBox();
            this.classNameBox = new System.Windows.Forms.TextBox();
            this.classNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherBox
            // 
            this.teacherBox.Location = new System.Drawing.Point(462, 360);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(274, 35);
            this.teacherBox.TabIndex = 11;
            // 
            // classNameBox
            // 
            this.classNameBox.Location = new System.Drawing.Point(462, 264);
            this.classNameBox.Name = "classNameBox";
            this.classNameBox.Size = new System.Drawing.Size(274, 35);
            this.classNameBox.TabIndex = 10;
            // 
            // classNumBox
            // 
            this.classNumBox.Location = new System.Drawing.Point(462, 171);
            this.classNumBox.Name = "classNumBox";
            this.classNumBox.Size = new System.Drawing.Size(274, 35);
            this.classNumBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "授课教师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "课程名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "课程号：";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(395, 543);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(188, 58);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "确认添加";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // adminClassManageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.teacherBox);
            this.Controls.Add(this.classNameBox);
            this.Controls.Add(this.classNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminClassManageAdd";
            this.Text = "课程新增";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.TextBox classNameBox;
        private System.Windows.Forms.TextBox classNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
    }
}
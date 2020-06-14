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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teaNumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherBox
            // 
            this.teacherBox.Location = new System.Drawing.Point(124, 152);
            this.teacherBox.Margin = new System.Windows.Forms.Padding(2);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(152, 28);
            this.teacherBox.TabIndex = 11;
            // 
            // classNameBox
            // 
            this.classNameBox.Location = new System.Drawing.Point(124, 53);
            this.classNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.classNameBox.Name = "classNameBox";
            this.classNameBox.Size = new System.Drawing.Size(152, 28);
            this.classNameBox.TabIndex = 10;
            // 
            // classNumBox
            // 
            this.classNumBox.Location = new System.Drawing.Point(115, 53);
            this.classNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.classNumBox.Name = "classNumBox";
            this.classNumBox.Size = new System.Drawing.Size(137, 28);
            this.classNumBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "授课教师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "课程名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "课程号：";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(377, 403);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(141, 44);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "确认添加";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.teaNumBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.classNumBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 238);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息新增";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.teacherBox);
            this.groupBox2.Controls.Add(this.classNameBox);
            this.groupBox2.Location = new System.Drawing.Point(377, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 238);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息校对";
            // 
            // teaNumBox
            // 
            this.teaNumBox.Location = new System.Drawing.Point(115, 151);
            this.teaNumBox.Name = "teaNumBox";
            this.teaNumBox.Size = new System.Drawing.Size(137, 28);
            this.teaNumBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "教工号";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(158, 403);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(141, 44);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "核对信息";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // adminClassManageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminClassManageAdd";
            this.Text = "课程新增";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.TextBox classNameBox;
        private System.Windows.Forms.TextBox classNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teaNumBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button checkButton;
    }
}
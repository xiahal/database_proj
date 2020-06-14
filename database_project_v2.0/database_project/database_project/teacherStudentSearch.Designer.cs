namespace database_project
{
    partial class teacherStudentSearch
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
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.classIdBox = new System.Windows.Forms.TextBox();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.messageGroup = new System.Windows.Forms.GroupBox();
            this.classNumberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageScoreBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.messageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程号：";
            // 
            // studentIdBox
            // 
            this.studentIdBox.Location = new System.Drawing.Point(135, 58);
            this.studentIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(146, 28);
            this.studentIdBox.TabIndex = 2;
            // 
            // classIdBox
            // 
            this.classIdBox.Location = new System.Drawing.Point(135, 106);
            this.classIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.classIdBox.Name = "classIdBox";
            this.classIdBox.Size = new System.Drawing.Size(146, 28);
            this.classIdBox.TabIndex = 3;
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(319, 106);
            this.studentSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(81, 26);
            this.studentSearchButton.TabIndex = 4;
            this.studentSearchButton.Text = "查询";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            this.studentSearchButton.Click += new System.EventHandler(this.StudentSearchButton_Click);
            // 
            // messageGroup
            // 
            this.messageGroup.Controls.Add(this.classNumberBox);
            this.messageGroup.Controls.Add(this.label4);
            this.messageGroup.Controls.Add(this.label3);
            this.messageGroup.Controls.Add(this.averageScoreBox);
            this.messageGroup.Location = new System.Drawing.Point(428, 34);
            this.messageGroup.Margin = new System.Windows.Forms.Padding(2);
            this.messageGroup.Name = "messageGroup";
            this.messageGroup.Padding = new System.Windows.Forms.Padding(2);
            this.messageGroup.Size = new System.Drawing.Size(248, 112);
            this.messageGroup.TabIndex = 5;
            this.messageGroup.TabStop = false;
            this.messageGroup.Text = "统计信息";
            // 
            // classNumberBox
            // 
            this.classNumberBox.Location = new System.Drawing.Point(115, 24);
            this.classNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.classNumberBox.Name = "classNumberBox";
            this.classNumberBox.Size = new System.Drawing.Size(120, 28);
            this.classNumberBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "平均成绩：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "课程门数：";
            // 
            // averageScoreBox
            // 
            this.averageScoreBox.Location = new System.Drawing.Point(115, 73);
            this.averageScoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.averageScoreBox.Name = "averageScoreBox";
            this.averageScoreBox.Size = new System.Drawing.Size(120, 28);
            this.averageScoreBox.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(40, 159);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.Size = new System.Drawing.Size(659, 341);
            this.dataGridView.TabIndex = 6;
            // 
            // teacherStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.messageGroup);
            this.Controls.Add(this.studentSearchButton);
            this.Controls.Add(this.classIdBox);
            this.Controls.Add(this.studentIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "teacherStudentSearch";
            this.Text = "学生查询";
            this.messageGroup.ResumeLayout(false);
            this.messageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.TextBox classIdBox;
        private System.Windows.Forms.Button studentSearchButton;
        private System.Windows.Forms.GroupBox messageGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox averageScoreBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox classNumberBox;
    }
}
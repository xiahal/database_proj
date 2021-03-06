﻿namespace database_project
{
    partial class adminTeacherManage
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
            this.changeButton = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.indexGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.teacherSalaryBox = new System.Windows.Forms.TextBox();
            this.teacherNumBox = new System.Windows.Forms.TextBox();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.indexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(578, 456);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(93, 34);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "修改";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.studentDataGrid);
            this.dataGroupBox.Location = new System.Drawing.Point(14, 107);
            this.dataGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGroupBox.Size = new System.Drawing.Size(702, 326);
            this.dataGroupBox.TabIndex = 17;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "数据";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(4, 26);
            this.studentDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.RowHeadersWidth = 82;
            this.studentDataGrid.RowTemplate.Height = 37;
            this.studentDataGrid.Size = new System.Drawing.Size(693, 296);
            this.studentDataGrid.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 456);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 34);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(56, 456);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 34);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // indexGroupBox
            // 
            this.indexGroupBox.Controls.Add(this.searchButton);
            this.indexGroupBox.Controls.Add(this.teacherSalaryBox);
            this.indexGroupBox.Controls.Add(this.teacherNumBox);
            this.indexGroupBox.Controls.Add(this.teacherNameBox);
            this.indexGroupBox.Controls.Add(this.label3);
            this.indexGroupBox.Controls.Add(this.teacher);
            this.indexGroupBox.Controls.Add(this.label1);
            this.indexGroupBox.Location = new System.Drawing.Point(14, 19);
            this.indexGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.indexGroupBox.Name = "indexGroupBox";
            this.indexGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.indexGroupBox.Size = new System.Drawing.Size(702, 84);
            this.indexGroupBox.TabIndex = 14;
            this.indexGroupBox.TabStop = false;
            this.indexGroupBox.Text = "检索";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(586, 38);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 35);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // teacherSalaryBox
            // 
            this.teacherSalaryBox.Location = new System.Drawing.Point(461, 44);
            this.teacherSalaryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherSalaryBox.Name = "teacherSalaryBox";
            this.teacherSalaryBox.Size = new System.Drawing.Size(92, 28);
            this.teacherSalaryBox.TabIndex = 6;
            // 
            // teacherNumBox
            // 
            this.teacherNumBox.Location = new System.Drawing.Point(262, 44);
            this.teacherNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherNumBox.Name = "teacherNumBox";
            this.teacherNumBox.Size = new System.Drawing.Size(90, 28);
            this.teacherNumBox.TabIndex = 5;
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(92, 44);
            this.teacherNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(76, 28);
            this.teacherNameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "工资";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(196, 46);
            this.teacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(44, 18);
            this.teacher.TabIndex = 2;
            this.teacher.Text = "工号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // adminTeacherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.indexGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminTeacherManage";
            this.Text = "教师管理";
            this.dataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.indexGroupBox.ResumeLayout(false);
            this.indexGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox indexGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox teacherSalaryBox;
        private System.Windows.Forms.TextBox teacherNumBox;
        private System.Windows.Forms.TextBox teacherNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label label1;
    }
}
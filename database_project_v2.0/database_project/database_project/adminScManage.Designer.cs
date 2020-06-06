namespace database_project
{
    partial class adminScManage
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
            this.classDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.indexGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.classNumBox = new System.Windows.Forms.TextBox();
            this.studentNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGrid)).BeginInit();
            this.indexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(770, 608);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(124, 45);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "修改";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.classDataGrid);
            this.dataGroupBox.Location = new System.Drawing.Point(19, 143);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(936, 434);
            this.dataGroupBox.TabIndex = 12;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "数据";
            // 
            // classDataGrid
            // 
            this.classDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGrid.Location = new System.Drawing.Point(6, 34);
            this.classDataGrid.Name = "classDataGrid";
            this.classDataGrid.RowHeadersWidth = 82;
            this.classDataGrid.RowTemplate.Height = 37;
            this.classDataGrid.Size = new System.Drawing.Size(924, 394);
            this.classDataGrid.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(434, 608);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 45);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(74, 608);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 45);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // indexGroupBox
            // 
            this.indexGroupBox.Controls.Add(this.searchButton);
            this.indexGroupBox.Controls.Add(this.scoreBox);
            this.indexGroupBox.Controls.Add(this.classNumBox);
            this.indexGroupBox.Controls.Add(this.studentNumBox);
            this.indexGroupBox.Controls.Add(this.label3);
            this.indexGroupBox.Controls.Add(this.label2);
            this.indexGroupBox.Controls.Add(this.label1);
            this.indexGroupBox.Location = new System.Drawing.Point(19, 25);
            this.indexGroupBox.Name = "indexGroupBox";
            this.indexGroupBox.Size = new System.Drawing.Size(936, 112);
            this.indexGroupBox.TabIndex = 9;
            this.indexGroupBox.TabStop = false;
            this.indexGroupBox.Text = "检索";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(781, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 47);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(615, 58);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(121, 35);
            this.scoreBox.TabIndex = 6;
            // 
            // classNumBox
            // 
            this.classNumBox.Location = new System.Drawing.Point(349, 58);
            this.classNumBox.Name = "classNumBox";
            this.classNumBox.Size = new System.Drawing.Size(118, 35);
            this.classNumBox.TabIndex = 5;
            // 
            // studentNumBox
            // 
            this.studentNumBox.Location = new System.Drawing.Point(123, 58);
            this.studentNumBox.Name = "studentNumBox";
            this.studentNumBox.Size = new System.Drawing.Size(100, 35);
            this.studentNumBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "成绩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号";
            // 
            // adminScManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.indexGroupBox);
            this.Name = "adminScManage";
            this.Text = "选课管理";
            this.dataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGrid)).EndInit();
            this.indexGroupBox.ResumeLayout(false);
            this.indexGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.DataGridView classDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox indexGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox classNumBox;
        private System.Windows.Forms.TextBox studentNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
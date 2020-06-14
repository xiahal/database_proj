namespace database_project
{
    partial class studentScoreSearch
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
            this.averageScoreBox = new System.Windows.Forms.TextBox();
            this.classNumberBox = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseAndScoreQuery = new System.Windows.Forms.Button();
            this.StumessageGroup = new System.Windows.Forms.GroupBox();
            this.GPAlabel = new System.Windows.Forms.Label();
            this.GPABox = new System.Windows.Forms.TextBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.TermBox = new System.Windows.Forms.ComboBox();
            this.EXITbutton = new System.Windows.Forms.Button();
            this.score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StumessageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "已修门数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "平均分：";
            // 
            // averageScoreBox
            // 
            this.averageScoreBox.Location = new System.Drawing.Point(130, 28);
            this.averageScoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.averageScoreBox.Name = "averageScoreBox";
            this.averageScoreBox.Size = new System.Drawing.Size(144, 28);
            this.averageScoreBox.TabIndex = 4;
            // 
            // classNumberBox
            // 
            this.classNumberBox.Location = new System.Drawing.Point(130, 121);
            this.classNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.classNumberBox.Name = "classNumberBox";
            this.classNumberBox.Size = new System.Drawing.Size(144, 28);
            this.classNumberBox.TabIndex = 5;
            // 
            // score
            // 
            this.score.Controls.Add(this.dataGridView1);
            this.score.Location = new System.Drawing.Point(28, 204);
            this.score.Margin = new System.Windows.Forms.Padding(2);
            this.score.Name = "score";
            this.score.Padding = new System.Windows.Forms.Padding(2);
            this.score.Size = new System.Drawing.Size(688, 288);
            this.score.TabIndex = 6;
            this.score.TabStop = false;
            this.score.Text = "课程成绩";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(680, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseAndScoreQuery
            // 
            this.CourseAndScoreQuery.Location = new System.Drawing.Point(91, 140);
            this.CourseAndScoreQuery.Name = "CourseAndScoreQuery";
            this.CourseAndScoreQuery.Size = new System.Drawing.Size(75, 29);
            this.CourseAndScoreQuery.TabIndex = 7;
            this.CourseAndScoreQuery.Text = "查询";
            this.CourseAndScoreQuery.UseVisualStyleBackColor = true;
            this.CourseAndScoreQuery.Click += new System.EventHandler(this.CourseAndScoreQuery_Click);
            // 
            // StumessageGroup
            // 
            this.StumessageGroup.Controls.Add(this.GPABox);
            this.StumessageGroup.Controls.Add(this.GPAlabel);
            this.StumessageGroup.Controls.Add(this.classNumberBox);
            this.StumessageGroup.Controls.Add(this.averageScoreBox);
            this.StumessageGroup.Controls.Add(this.label2);
            this.StumessageGroup.Controls.Add(this.label1);
            this.StumessageGroup.Location = new System.Drawing.Point(351, 30);
            this.StumessageGroup.Name = "StumessageGroup";
            this.StumessageGroup.Size = new System.Drawing.Size(319, 169);
            this.StumessageGroup.TabIndex = 8;
            this.StumessageGroup.TabStop = false;
            this.StumessageGroup.Text = "统计信息";
            // 
            // GPAlabel
            // 
            this.GPAlabel.AutoSize = true;
            this.GPAlabel.Location = new System.Drawing.Point(18, 79);
            this.GPAlabel.Name = "GPAlabel";
            this.GPAlabel.Size = new System.Drawing.Size(62, 18);
            this.GPAlabel.TabIndex = 0;
            this.GPAlabel.Text = "绩点：";
            // 
            // GPABox
            // 
            this.GPABox.Location = new System.Drawing.Point(130, 75);
            this.GPABox.Name = "GPABox";
            this.GPABox.Size = new System.Drawing.Size(144, 28);
            this.GPABox.TabIndex = 1;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(68, 68);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(98, 18);
            this.termLabel.TabIndex = 9;
            this.termLabel.Text = "选择学期：";
            // 
            // TermBox
            // 
            this.TermBox.FormattingEnabled = true;
            this.TermBox.Location = new System.Drawing.Point(172, 65);
            this.TermBox.Name = "TermBox";
            this.TermBox.Size = new System.Drawing.Size(121, 26);
            this.TermBox.TabIndex = 10;
            // 
            // EXITbutton
            // 
            this.EXITbutton.Location = new System.Drawing.Point(203, 140);
            this.EXITbutton.Name = "EXITbutton";
            this.EXITbutton.Size = new System.Drawing.Size(75, 29);
            this.EXITbutton.TabIndex = 11;
            this.EXITbutton.Text = "退出";
            this.EXITbutton.UseVisualStyleBackColor = true;
            this.EXITbutton.Click += new System.EventHandler(this.EXITbutton_Click);
            // 
            // studentScoreSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.EXITbutton);
            this.Controls.Add(this.TermBox);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.CourseAndScoreQuery);
            this.Controls.Add(this.score);
            this.Controls.Add(this.StumessageGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentScoreSearch";
            this.Text = "成绩查询";
            this.score.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StumessageGroup.ResumeLayout(false);
            this.StumessageGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox averageScoreBox;
        private System.Windows.Forms.TextBox classNumberBox;
        private System.Windows.Forms.GroupBox score;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CourseAndScoreQuery;
        private System.Windows.Forms.GroupBox StumessageGroup;
        private System.Windows.Forms.TextBox GPABox;
        private System.Windows.Forms.Label GPAlabel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.ComboBox TermBox;
        private System.Windows.Forms.Button EXITbutton;
    }
}
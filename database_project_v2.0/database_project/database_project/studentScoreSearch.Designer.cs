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
            this.score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "已修门数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "平均分：";
            // 
            // averageScoreBox
            // 
            this.averageScoreBox.Location = new System.Drawing.Point(452, 58);
            this.averageScoreBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.averageScoreBox.Name = "averageScoreBox";
            this.averageScoreBox.Size = new System.Drawing.Size(144, 28);
            this.averageScoreBox.TabIndex = 4;
            // 
            // classNumberBox
            // 
            this.classNumberBox.Location = new System.Drawing.Point(174, 58);
            this.classNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classNumberBox.Name = "classNumberBox";
            this.classNumberBox.Size = new System.Drawing.Size(144, 28);
            this.classNumberBox.TabIndex = 5;
            // 
            // score
            // 
            this.score.Controls.Add(this.dataGridView1);
            this.score.Location = new System.Drawing.Point(28, 104);
            this.score.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.score.Name = "score";
            this.score.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.score.Size = new System.Drawing.Size(688, 388);
            this.score.TabIndex = 6;
            this.score.TabStop = false;
            this.score.Text = "课程成绩";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(680, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentScoreSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.score);
            this.Controls.Add(this.classNumberBox);
            this.Controls.Add(this.averageScoreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "studentScoreSearch";
            this.Text = "成绩查询";
            this.score.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
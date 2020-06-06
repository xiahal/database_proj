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
            this.label1.Location = new System.Drawing.Point(96, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "已修门数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "平均分：";
            // 
            // averageScoreBox
            // 
            this.averageScoreBox.Location = new System.Drawing.Point(602, 77);
            this.averageScoreBox.Name = "averageScoreBox";
            this.averageScoreBox.Size = new System.Drawing.Size(190, 35);
            this.averageScoreBox.TabIndex = 4;
            // 
            // classNumberBox
            // 
            this.classNumberBox.Location = new System.Drawing.Point(232, 77);
            this.classNumberBox.Name = "classNumberBox";
            this.classNumberBox.Size = new System.Drawing.Size(190, 35);
            this.classNumberBox.TabIndex = 5;
            // 
            // score
            // 
            this.score.Controls.Add(this.dataGridView1);
            this.score.Location = new System.Drawing.Point(37, 139);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(918, 518);
            this.score.TabIndex = 6;
            this.score.TabStop = false;
            this.score.Text = "课程成绩";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(906, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentScoreSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.score);
            this.Controls.Add(this.classNumberBox);
            this.Controls.Add(this.averageScoreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
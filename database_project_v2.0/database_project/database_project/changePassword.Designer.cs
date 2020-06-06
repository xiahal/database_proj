namespace database_project
{
    partial class changePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.originalPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswardBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.conceal = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // originalPasswordBox
            // 
            this.originalPasswordBox.Location = new System.Drawing.Point(404, 141);
            this.originalPasswordBox.Name = "originalPasswordBox";
            this.originalPasswordBox.Size = new System.Drawing.Size(274, 35);
            this.originalPasswordBox.TabIndex = 3;
            // 
            // newPasswardBox
            // 
            this.newPasswardBox.Location = new System.Drawing.Point(404, 234);
            this.newPasswardBox.Name = "newPasswardBox";
            this.newPasswardBox.Size = new System.Drawing.Size(274, 35);
            this.newPasswardBox.TabIndex = 4;
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(404, 330);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(274, 35);
            this.confirmPasswordBox.TabIndex = 5;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(228, 478);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(177, 49);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // conceal
            // 
            this.conceal.Location = new System.Drawing.Point(577, 478);
            this.conceal.Name = "conceal";
            this.conceal.Size = new System.Drawing.Size(177, 49);
            this.conceal.TabIndex = 7;
            this.conceal.Text = "取消";
            this.conceal.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.ForeColor = System.Drawing.Color.DarkRed;
            this.message.Location = new System.Drawing.Point(175, 582);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(117, 28);
            this.message.TabIndex = 8;
            this.message.Text = "message";
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.message);
            this.Controls.Add(this.conceal);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.newPasswardBox);
            this.Controls.Add(this.originalPasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changePassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox originalPasswordBox;
        private System.Windows.Forms.TextBox newPasswardBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button conceal;
        private System.Windows.Forms.Label message;
    }
}
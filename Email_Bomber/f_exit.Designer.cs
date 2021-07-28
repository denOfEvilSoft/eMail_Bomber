
namespace Email_Bomber
{
    partial class f_exit
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
            this.l_really = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_really
            // 
            this.l_really.AutoSize = true;
            this.l_really.Location = new System.Drawing.Point(93, 23);
            this.l_really.Name = "l_really";
            this.l_really.Size = new System.Drawing.Size(71, 12);
            this.l_really.TabIndex = 0;
            this.l_really.Text = "종료할거야?";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(12, 51);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "종료";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_cancle
            // 
            this.b_cancle.Location = new System.Drawing.Point(170, 51);
            this.b_cancle.Name = "b_cancle";
            this.b_cancle.Size = new System.Drawing.Size(75, 23);
            this.b_cancle.TabIndex = 2;
            this.b_cancle.Text = "취소";
            this.b_cancle.UseVisualStyleBackColor = true;
            this.b_cancle.Click += new System.EventHandler(this.b_cancle_Click);
            // 
            // exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 86);
            this.Controls.Add(this.b_cancle);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_really);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_really;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_cancle;
    }
}
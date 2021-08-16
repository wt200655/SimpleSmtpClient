namespace SimpleSmtpClient
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.VfSslCA = new System.Windows.Forms.CheckBox();
            this.guiUseSsl = new System.Windows.Forms.CheckBox();
            this.guiPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.guiUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guiUseCredentials = new System.Windows.Forms.CheckBox();
            this.guiPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.guiServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.emailGroup = new System.Windows.Forms.GroupBox();
            this.guiEmailBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.guiEmailSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.guiEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.guiEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.guiSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.serverGroup.SuspendLayout();
            this.emailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.VfSslCA);
            this.serverGroup.Controls.Add(this.guiUseSsl);
            this.serverGroup.Controls.Add(this.guiPassword);
            this.serverGroup.Controls.Add(this.lblPassword);
            this.serverGroup.Controls.Add(this.guiUser);
            this.serverGroup.Controls.Add(this.lblUserName);
            this.serverGroup.Controls.Add(this.guiUseCredentials);
            this.serverGroup.Controls.Add(this.guiPort);
            this.serverGroup.Controls.Add(this.lblPort);
            this.serverGroup.Controls.Add(this.guiServerName);
            this.serverGroup.Controls.Add(this.lblServerName);
            this.serverGroup.Location = new System.Drawing.Point(12, 18);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(540, 123);
            this.serverGroup.TabIndex = 0;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "SMTP配置";
            // 
            // VfSslCA
            // 
            this.VfSslCA.AutoSize = true;
            this.VfSslCA.Location = new System.Drawing.Point(198, 91);
            this.VfSslCA.Name = "VfSslCA";
            this.VfSslCA.Size = new System.Drawing.Size(96, 16);
            this.VfSslCA.TabIndex = 10;
            this.VfSslCA.Text = "跳过证书验证";
            this.VfSslCA.UseVisualStyleBackColor = true;
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Location = new System.Drawing.Point(126, 91);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(66, 16);
            this.guiUseSsl.TabIndex = 9;
            this.guiUseSsl.Text = "启用SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            this.guiUseSsl.CheckedChanged += new System.EventHandler(this.guiUseSsl_CheckedChanged);
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(393, 58);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.ReadOnly = true;
            this.guiPassword.Size = new System.Drawing.Size(129, 21);
            this.guiPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(360, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "密码";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(69, 58);
            this.guiUser.Name = "guiUser";
            this.guiUser.ReadOnly = true;
            this.guiUser.Size = new System.Drawing.Size(275, 21);
            this.guiUser.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 12);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "用户名";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Location = new System.Drawing.Point(24, 91);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(96, 16);
            this.guiUseCredentials.TabIndex = 4;
            this.guiUseCredentials.Text = "启用安全认证";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(393, 26);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(129, 21);
            this.guiPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(360, 29);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "端口";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(69, 26);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(275, 21);
            this.guiServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 29);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(41, 12);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "服务器";
            // 
            // emailGroup
            // 
            this.emailGroup.Controls.Add(this.guiEmailBody);
            this.emailGroup.Controls.Add(this.lblBody);
            this.emailGroup.Controls.Add(this.guiEmailSubject);
            this.emailGroup.Controls.Add(this.lblSubject);
            this.emailGroup.Controls.Add(this.guiEmailTo);
            this.emailGroup.Controls.Add(this.lblEmailTo);
            this.emailGroup.Controls.Add(this.guiEmailFrom);
            this.emailGroup.Controls.Add(this.lblEmailFrom);
            this.emailGroup.Location = new System.Drawing.Point(12, 157);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Size = new System.Drawing.Size(539, 223);
            this.emailGroup.TabIndex = 1;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "邮件内容";
            // 
            // guiEmailBody
            // 
            this.guiEmailBody.Location = new System.Drawing.Point(76, 131);
            this.guiEmailBody.Multiline = true;
            this.guiEmailBody.Name = "guiEmailBody";
            this.guiEmailBody.Size = new System.Drawing.Size(446, 71);
            this.guiEmailBody.TabIndex = 8;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(22, 132);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(29, 12);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "正文";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(76, 96);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(446, 21);
            this.guiEmailSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(22, 99);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(29, 12);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "主题";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(76, 61);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(446, 21);
            this.guiEmailTo.TabIndex = 4;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(22, 64);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(41, 12);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "收件人";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Location = new System.Drawing.Point(76, 26);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.Size = new System.Drawing.Size(446, 21);
            this.guiEmailFrom.TabIndex = 2;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(22, 28);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(41, 12);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "发件人";
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(446, 394);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(104, 29);
            this.guiSendMail.TabIndex = 2;
            this.guiSendMail.Text = "发送邮件";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "本程序采用MIT许可    By：毋须";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看该开源项目";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 434);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guiSendMail);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "简易SMTP客户端";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.emailGroup.ResumeLayout(false);
            this.emailGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.TextBox guiPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox guiUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox guiUseCredentials;
        private System.Windows.Forms.TextBox guiPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox guiServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.GroupBox emailGroup;
        private System.Windows.Forms.TextBox guiEmailBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox guiEmailSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox guiEmailTo;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox guiEmailFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.Button guiSendMail;
        private System.Windows.Forms.CheckBox guiUseSsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox VfSslCA;
    }
}


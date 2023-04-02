
namespace NWConfigScriptor
{
    partial class VmTftpTransfer
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
            this.Btn_ExitVmTftpTransfer = new System.Windows.Forms.Button();
            this.Btn_OpenTftpd64 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_EditConfigFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tbx_OutputDisplay = new System.Windows.Forms.TextBox();
            this.Btn_SendToRouter = new System.Windows.Forms.Button();
            this.Btn_GetFromRouter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tbx_secretPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbx_portNumTFTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbx_passwordTFTP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tbx_usernameTFTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rtbx_EditConfig = new System.Windows.Forms.RichTextBox();
            this.Tbx_FileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_FilesNotFoundError = new System.Windows.Forms.Label();
            this.Btn_GetFilePath = new System.Windows.Forms.Button();
            this.Cklbx_TftpConfigFiles = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_TargetDeviceIP = new System.Windows.Forms.TextBox();
            this.Tbx_TargetServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ExitVmTftpTransfer
            // 
            this.Btn_ExitVmTftpTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_ExitVmTftpTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExitVmTftpTransfer.Location = new System.Drawing.Point(645, 25);
            this.Btn_ExitVmTftpTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ExitVmTftpTransfer.Name = "Btn_ExitVmTftpTransfer";
            this.Btn_ExitVmTftpTransfer.Size = new System.Drawing.Size(132, 73);
            this.Btn_ExitVmTftpTransfer.TabIndex = 0;
            this.Btn_ExitVmTftpTransfer.Text = "Close";
            this.Btn_ExitVmTftpTransfer.UseVisualStyleBackColor = false;
            this.Btn_ExitVmTftpTransfer.Click += new System.EventHandler(this.Btn_ExitVmTftpTransfer_Click);
            // 
            // Btn_OpenTftpd64
            // 
            this.Btn_OpenTftpd64.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_OpenTftpd64.Location = new System.Drawing.Point(499, 10);
            this.Btn_OpenTftpd64.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_OpenTftpd64.Name = "Btn_OpenTftpd64";
            this.Btn_OpenTftpd64.Size = new System.Drawing.Size(132, 52);
            this.Btn_OpenTftpd64.TabIndex = 1;
            this.Btn_OpenTftpd64.Text = "Open Tftpd64";
            this.Btn_OpenTftpd64.UseVisualStyleBackColor = false;
            this.Btn_OpenTftpd64.Click += new System.EventHandler(this.Btn_OpenTftpd64_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 56);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TFTP Transfer Page";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Save.Location = new System.Drawing.Point(254, 308);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(216, 43);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_EditConfigFile
            // 
            this.Btn_EditConfigFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_EditConfigFile.Location = new System.Drawing.Point(255, 260);
            this.Btn_EditConfigFile.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EditConfigFile.Name = "Btn_EditConfigFile";
            this.Btn_EditConfigFile.Size = new System.Drawing.Size(216, 43);
            this.Btn_EditConfigFile.TabIndex = 3;
            this.Btn_EditConfigFile.Text = "Open config file to edit";
            this.Btn_EditConfigFile.UseVisualStyleBackColor = false;
            this.Btn_EditConfigFile.Click += new System.EventHandler(this.Btn_EditConfigFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tbx_OutputDisplay);
            this.panel2.Controls.Add(this.Btn_OpenTftpd64);
            this.panel2.Controls.Add(this.Btn_ExitVmTftpTransfer);
            this.panel2.Controls.Add(this.Btn_SendToRouter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 129);
            this.panel2.TabIndex = 3;
            // 
            // Tbx_OutputDisplay
            // 
            this.Tbx_OutputDisplay.Location = new System.Drawing.Point(28, 5);
            this.Tbx_OutputDisplay.Multiline = true;
            this.Tbx_OutputDisplay.Name = "Tbx_OutputDisplay";
            this.Tbx_OutputDisplay.ReadOnly = true;
            this.Tbx_OutputDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tbx_OutputDisplay.Size = new System.Drawing.Size(454, 121);
            this.Tbx_OutputDisplay.TabIndex = 2;
            // 
            // Btn_SendToRouter
            // 
            this.Btn_SendToRouter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_SendToRouter.Location = new System.Drawing.Point(499, 66);
            this.Btn_SendToRouter.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SendToRouter.Name = "Btn_SendToRouter";
            this.Btn_SendToRouter.Size = new System.Drawing.Size(132, 52);
            this.Btn_SendToRouter.TabIndex = 10;
            this.Btn_SendToRouter.Text = "Send to router";
            this.Btn_SendToRouter.UseVisualStyleBackColor = false;
            this.Btn_SendToRouter.Click += new System.EventHandler(this.Btn_SendToRouter_Click);
            // 
            // Btn_GetFromRouter
            // 
            this.Btn_GetFromRouter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_GetFromRouter.Location = new System.Drawing.Point(255, 5);
            this.Btn_GetFromRouter.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_GetFromRouter.Name = "Btn_GetFromRouter";
            this.Btn_GetFromRouter.Size = new System.Drawing.Size(216, 51);
            this.Btn_GetFromRouter.TabIndex = 10;
            this.Btn_GetFromRouter.Text = "Get router config";
            this.Btn_GetFromRouter.UseVisualStyleBackColor = false;
            this.Btn_GetFromRouter.Click += new System.EventHandler(this.Btn_GetFromRouter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Btn_Save);
            this.panel3.Controls.Add(this.Tbx_secretPassword);
            this.panel3.Controls.Add(this.Btn_EditConfigFile);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Tbx_portNumTFTP);
            this.panel3.Controls.Add(this.Btn_GetFromRouter);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Tbx_passwordTFTP);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Tbx_usernameTFTP);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Rtbx_EditConfig);
            this.panel3.Controls.Add(this.Tbx_FileName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Lbl_FilesNotFoundError);
            this.panel3.Controls.Add(this.Btn_GetFilePath);
            this.panel3.Controls.Add(this.Cklbx_TftpConfigFiles);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Tbx_TargetDeviceIP);
            this.panel3.Controls.Add(this.Tbx_TargetServerIP);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 355);
            this.panel3.TabIndex = 4;
            // 
            // Tbx_secretPassword
            // 
            this.Tbx_secretPassword.Location = new System.Drawing.Point(125, 95);
            this.Tbx_secretPassword.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_secretPassword.Name = "Tbx_secretPassword";
            this.Tbx_secretPassword.Size = new System.Drawing.Size(118, 27);
            this.Tbx_secretPassword.TabIndex = 24;
            this.Tbx_secretPassword.Text = "gns3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "secret pass";
            // 
            // Tbx_portNumTFTP
            // 
            this.Tbx_portNumTFTP.Location = new System.Drawing.Point(125, 64);
            this.Tbx_portNumTFTP.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_portNumTFTP.Name = "Tbx_portNumTFTP";
            this.Tbx_portNumTFTP.Size = new System.Drawing.Size(118, 27);
            this.Tbx_portNumTFTP.TabIndex = 22;
            this.Tbx_portNumTFTP.Text = "23";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "port number";
            // 
            // Tbx_passwordTFTP
            // 
            this.Tbx_passwordTFTP.Location = new System.Drawing.Point(125, 33);
            this.Tbx_passwordTFTP.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_passwordTFTP.Name = "Tbx_passwordTFTP";
            this.Tbx_passwordTFTP.Size = new System.Drawing.Size(118, 27);
            this.Tbx_passwordTFTP.TabIndex = 20;
            this.Tbx_passwordTFTP.Text = "gns3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "password";
            // 
            // Tbx_usernameTFTP
            // 
            this.Tbx_usernameTFTP.Location = new System.Drawing.Point(125, 2);
            this.Tbx_usernameTFTP.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_usernameTFTP.Name = "Tbx_usernameTFTP";
            this.Tbx_usernameTFTP.Size = new System.Drawing.Size(118, 27);
            this.Tbx_usernameTFTP.TabIndex = 18;
            this.Tbx_usernameTFTP.Text = "gns3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "username";
            // 
            // Rtbx_EditConfig
            // 
            this.Rtbx_EditConfig.Location = new System.Drawing.Point(487, 5);
            this.Rtbx_EditConfig.Name = "Rtbx_EditConfig";
            this.Rtbx_EditConfig.Size = new System.Drawing.Size(298, 345);
            this.Rtbx_EditConfig.TabIndex = 15;
            this.Rtbx_EditConfig.Text = "Display config file contents:";
            // 
            // Tbx_FileName
            // 
            this.Tbx_FileName.Location = new System.Drawing.Point(13, 302);
            this.Tbx_FileName.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_FileName.Name = "Tbx_FileName";
            this.Tbx_FileName.PlaceholderText = "file-name";
            this.Tbx_FileName.Size = new System.Drawing.Size(228, 27);
            this.Tbx_FileName.TabIndex = 14;
            this.Tbx_FileName.Text = "running-config";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter a name for the config file to\r\nbe created";
            // 
            // Lbl_FilesNotFoundError
            // 
            this.Lbl_FilesNotFoundError.AutoSize = true;
            this.Lbl_FilesNotFoundError.ForeColor = System.Drawing.Color.Red;
            this.Lbl_FilesNotFoundError.Location = new System.Drawing.Point(266, 230);
            this.Lbl_FilesNotFoundError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_FilesNotFoundError.Name = "Lbl_FilesNotFoundError";
            this.Lbl_FilesNotFoundError.Size = new System.Drawing.Size(165, 20);
            this.Lbl_FilesNotFoundError.TabIndex = 12;
            this.Lbl_FilesNotFoundError.Text = "** No config files found";
            this.Lbl_FilesNotFoundError.Visible = false;
            // 
            // Btn_GetFilePath
            // 
            this.Btn_GetFilePath.Location = new System.Drawing.Point(439, 230);
            this.Btn_GetFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_GetFilePath.Name = "Btn_GetFilePath";
            this.Btn_GetFilePath.Size = new System.Drawing.Size(31, 27);
            this.Btn_GetFilePath.TabIndex = 11;
            this.Btn_GetFilePath.Text = ":";
            this.Btn_GetFilePath.UseVisualStyleBackColor = true;
            this.Btn_GetFilePath.Click += new System.EventHandler(this.Btn_GetFilePath_Click);
            // 
            // Cklbx_TftpConfigFiles
            // 
            this.Cklbx_TftpConfigFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.Cklbx_TftpConfigFiles.CheckOnClick = true;
            this.Cklbx_TftpConfigFiles.FormattingEnabled = true;
            this.Cklbx_TftpConfigFiles.Location = new System.Drawing.Point(254, 112);
            this.Cklbx_TftpConfigFiles.Margin = new System.Windows.Forms.Padding(2);
            this.Cklbx_TftpConfigFiles.Name = "Cklbx_TftpConfigFiles";
            this.Cklbx_TftpConfigFiles.Size = new System.Drawing.Size(217, 114);
            this.Cklbx_TftpConfigFiles.Sorted = true;
            this.Cklbx_TftpConfigFiles.TabIndex = 8;
            this.Cklbx_TftpConfigFiles.ThreeDCheckBoxes = true;
            this.Cklbx_TftpConfigFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Cklbx_TftpConfigFiles_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select the config file to transfer\r\nto the server";
            // 
            // Tbx_TargetDeviceIP
            // 
            this.Tbx_TargetDeviceIP.Location = new System.Drawing.Point(11, 176);
            this.Tbx_TargetDeviceIP.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_TargetDeviceIP.Name = "Tbx_TargetDeviceIP";
            this.Tbx_TargetDeviceIP.PlaceholderText = "10.10.10.5";
            this.Tbx_TargetDeviceIP.Size = new System.Drawing.Size(230, 27);
            this.Tbx_TargetDeviceIP.TabIndex = 5;
            this.Tbx_TargetDeviceIP.Text = "10.10.10.5";
            // 
            // Tbx_TargetServerIP
            // 
            this.Tbx_TargetServerIP.Location = new System.Drawing.Point(13, 230);
            this.Tbx_TargetServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_TargetServerIP.Name = "Tbx_TargetServerIP";
            this.Tbx_TargetServerIP.PlaceholderText = "10.10.10.100";
            this.Tbx_TargetServerIP.Size = new System.Drawing.Size(228, 27);
            this.Tbx_TargetServerIP.TabIndex = 4;
            this.Tbx_TargetServerIP.Text = "10.10.10.12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter IP address of the TFTP server ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter the IP address of the target\r\nrouter/switch device";
            // 
            // VmTftpTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VmTftpTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VmTftpTransfer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExitVmTftpTransfer;
        private System.Windows.Forms.Button Btn_OpenTftpd64;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_TargetDeviceIP;
        private System.Windows.Forms.TextBox Tbx_TargetServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox Cklbx_TftpConfigFiles;
        private System.Windows.Forms.Button Btn_GetFromRouter;
        private System.Windows.Forms.Button Btn_GetFilePath;
        private System.Windows.Forms.Label Lbl_FilesNotFoundError;
        private System.Windows.Forms.Button Btn_SendToRouter;
        private System.Windows.Forms.RichTextBox Rtbx_EditConfig;
        private System.Windows.Forms.TextBox Tbx_FileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_EditConfigFile;
        private System.Windows.Forms.TextBox Tbx_OutputDisplay;
        private System.Windows.Forms.TextBox Tbx_portNumTFTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbx_passwordTFTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbx_usernameTFTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_secretPassword;
        private System.Windows.Forms.Label label9;
    }
}
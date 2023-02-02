
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_FilesNotFoundError = new System.Windows.Forms.Label();
            this.Btn_GetFilePath = new System.Windows.Forms.Button();
            this.Btn_SendTftp = new System.Windows.Forms.Button();
            this.Btn_TestTftpCon = new System.Windows.Forms.Button();
            this.Cklbx_TftpConfigFiles = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_TargetDeviceIP = new System.Windows.Forms.TextBox();
            this.Tbx_TargetDeviceGateway = new System.Windows.Forms.TextBox();
            this.Tbx_TargetNetworkIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ExitVmTftpTransfer
            // 
            this.Btn_ExitVmTftpTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_ExitVmTftpTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExitVmTftpTransfer.Location = new System.Drawing.Point(735, 26);
            this.Btn_ExitVmTftpTransfer.Name = "Btn_ExitVmTftpTransfer";
            this.Btn_ExitVmTftpTransfer.Size = new System.Drawing.Size(137, 74);
            this.Btn_ExitVmTftpTransfer.TabIndex = 0;
            this.Btn_ExitVmTftpTransfer.Text = "Close";
            this.Btn_ExitVmTftpTransfer.UseVisualStyleBackColor = false;
            this.Btn_ExitVmTftpTransfer.Click += new System.EventHandler(this.Btn_ExitVmTftpTransfer_Click);
            // 
            // Btn_OpenTftpd64
            // 
            this.Btn_OpenTftpd64.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_OpenTftpd64.Location = new System.Drawing.Point(168, 26);
            this.Btn_OpenTftpd64.Name = "Btn_OpenTftpd64";
            this.Btn_OpenTftpd64.Size = new System.Drawing.Size(122, 74);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 150);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "TFTP Transfer Page";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_OpenTftpd64);
            this.panel2.Controls.Add(this.Btn_ExitVmTftpTransfer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 150);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Lbl_FilesNotFoundError);
            this.panel3.Controls.Add(this.Btn_GetFilePath);
            this.panel3.Controls.Add(this.Btn_SendTftp);
            this.panel3.Controls.Add(this.Btn_TestTftpCon);
            this.panel3.Controls.Add(this.Cklbx_TftpConfigFiles);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Tbx_TargetDeviceIP);
            this.panel3.Controls.Add(this.Tbx_TargetDeviceGateway);
            this.panel3.Controls.Add(this.Tbx_TargetNetworkIP);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 375);
            this.panel3.TabIndex = 4;
            // 
            // Lbl_FilesNotFoundError
            // 
            this.Lbl_FilesNotFoundError.AutoSize = true;
            this.Lbl_FilesNotFoundError.ForeColor = System.Drawing.Color.Red;
            this.Lbl_FilesNotFoundError.Location = new System.Drawing.Point(503, 307);
            this.Lbl_FilesNotFoundError.Name = "Lbl_FilesNotFoundError";
            this.Lbl_FilesNotFoundError.Size = new System.Drawing.Size(201, 25);
            this.Lbl_FilesNotFoundError.TabIndex = 12;
            this.Lbl_FilesNotFoundError.Text = "** No config files found";
            this.Lbl_FilesNotFoundError.Visible = false;
            // 
            // Btn_GetFilePath
            // 
            this.Btn_GetFilePath.Location = new System.Drawing.Point(815, 160);
            this.Btn_GetFilePath.Name = "Btn_GetFilePath";
            this.Btn_GetFilePath.Size = new System.Drawing.Size(39, 34);
            this.Btn_GetFilePath.TabIndex = 11;
            this.Btn_GetFilePath.Text = ":";
            this.Btn_GetFilePath.UseVisualStyleBackColor = true;
            this.Btn_GetFilePath.Click += new System.EventHandler(this.Btn_GetFilePath_Click);
            // 
            // Btn_SendTftp
            // 
            this.Btn_SendTftp.Location = new System.Drawing.Point(815, 236);
            this.Btn_SendTftp.Name = "Btn_SendTftp";
            this.Btn_SendTftp.Size = new System.Drawing.Size(136, 68);
            this.Btn_SendTftp.TabIndex = 10;
            this.Btn_SendTftp.Text = "Send";
            this.Btn_SendTftp.UseVisualStyleBackColor = true;
            this.Btn_SendTftp.Click += new System.EventHandler(this.Btn_SendTftp_Click);
            // 
            // Btn_TestTftpCon
            // 
            this.Btn_TestTftpCon.Location = new System.Drawing.Point(118, 250);
            this.Btn_TestTftpCon.Name = "Btn_TestTftpCon";
            this.Btn_TestTftpCon.Size = new System.Drawing.Size(328, 54);
            this.Btn_TestTftpCon.TabIndex = 9;
            this.Btn_TestTftpCon.Text = "Test connection";
            this.Btn_TestTftpCon.UseVisualStyleBackColor = true;
            this.Btn_TestTftpCon.Click += new System.EventHandler(this.Btn_TestTftpCon_Click);
            // 
            // Cklbx_TftpConfigFiles
            // 
            this.Cklbx_TftpConfigFiles.FormattingEnabled = true;
            this.Cklbx_TftpConfigFiles.Location = new System.Drawing.Point(503, 160);
            this.Cklbx_TftpConfigFiles.Name = "Cklbx_TftpConfigFiles";
            this.Cklbx_TftpConfigFiles.Size = new System.Drawing.Size(290, 144);
            this.Cklbx_TftpConfigFiles.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select the config file to transfer";
            // 
            // Tbx_TargetDeviceIP
            // 
            this.Tbx_TargetDeviceIP.Location = new System.Drawing.Point(118, 160);
            this.Tbx_TargetDeviceIP.Name = "Tbx_TargetDeviceIP";
            this.Tbx_TargetDeviceIP.PlaceholderText = "192.168.10.2";
            this.Tbx_TargetDeviceIP.Size = new System.Drawing.Size(328, 31);
            this.Tbx_TargetDeviceIP.TabIndex = 5;
            // 
            // Tbx_TargetDeviceGateway
            // 
            this.Tbx_TargetDeviceGateway.Location = new System.Drawing.Point(504, 58);
            this.Tbx_TargetDeviceGateway.Name = "Tbx_TargetDeviceGateway";
            this.Tbx_TargetDeviceGateway.PlaceholderText = "0.0.0.255";
            this.Tbx_TargetDeviceGateway.Size = new System.Drawing.Size(289, 31);
            this.Tbx_TargetDeviceGateway.TabIndex = 4;
            // 
            // Tbx_TargetNetworkIP
            // 
            this.Tbx_TargetNetworkIP.Location = new System.Drawing.Point(120, 58);
            this.Tbx_TargetNetworkIP.Name = "Tbx_TargetNetworkIP";
            this.Tbx_TargetNetworkIP.PlaceholderText = "192.168.0.0";
            this.Tbx_TargetNetworkIP.Size = new System.Drawing.Size(326, 31);
            this.Tbx_TargetNetworkIP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter the network gateway";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter the IP address of the target device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter IP address of the network";
            // 
            // VmTftpTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(985, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VmTftpTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VmTftpTransfer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox Tbx_TargetDeviceGateway;
        private System.Windows.Forms.TextBox Tbx_TargetNetworkIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Cklbx_TftpConfigFiles;
        private System.Windows.Forms.Button Btn_SendTftp;
        private System.Windows.Forms.Button Btn_TestTftpCon;
        private System.Windows.Forms.Button Btn_GetFilePath;
        private System.Windows.Forms.Label Lbl_FilesNotFoundError;
    }
}
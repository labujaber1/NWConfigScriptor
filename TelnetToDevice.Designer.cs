namespace NWConfigScriptor
{
    partial class TelnetToDevice
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
            this.Lbl_IPAddress = new System.Windows.Forms.Label();
            this.Tbx_IPAddress = new System.Windows.Forms.TextBox();
            this.Tbx_PortNum = new System.Windows.Forms.TextBox();
            this.Lbl_PortNumber = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.Btn_CommandFileChooser = new System.Windows.Forms.Button();
            this.Tbx_CommandFileDisplay = new System.Windows.Forms.TextBox();
            this.Btn_SendTelnet = new System.Windows.Forms.Button();
            this.Btn_ClearFields = new System.Windows.Forms.Button();
            this.Btn_ExitTelnetPage = new System.Windows.Forms.Button();
            this.Lbl_SelectAdaptor = new System.Windows.Forms.Label();
            this.Cmbx_AdaptorChoice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tbx_CommsDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_secretPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_IPAddress
            // 
            this.Lbl_IPAddress.AutoSize = true;
            this.Lbl_IPAddress.Location = new System.Drawing.Point(65, 101);
            this.Lbl_IPAddress.Name = "Lbl_IPAddress";
            this.Lbl_IPAddress.Size = new System.Drawing.Size(114, 20);
            this.Lbl_IPAddress.TabIndex = 0;
            this.Lbl_IPAddress.Text = "Enter IP address";
            // 
            // Tbx_IPAddress
            // 
            this.Tbx_IPAddress.Location = new System.Drawing.Point(217, 98);
            this.Tbx_IPAddress.Name = "Tbx_IPAddress";
            this.Tbx_IPAddress.PlaceholderText = "192.168.0.1";
            this.Tbx_IPAddress.Size = new System.Drawing.Size(245, 27);
            this.Tbx_IPAddress.TabIndex = 1;
            this.Tbx_IPAddress.Text = "10.10.10.5";
            // 
            // Tbx_PortNum
            // 
            this.Tbx_PortNum.Location = new System.Drawing.Point(217, 145);
            this.Tbx_PortNum.Name = "Tbx_PortNum";
            this.Tbx_PortNum.PlaceholderText = "23";
            this.Tbx_PortNum.Size = new System.Drawing.Size(245, 27);
            this.Tbx_PortNum.TabIndex = 2;
            this.Tbx_PortNum.Text = "23";
            // 
            // Lbl_PortNumber
            // 
            this.Lbl_PortNumber.AutoSize = true;
            this.Lbl_PortNumber.Location = new System.Drawing.Point(65, 152);
            this.Lbl_PortNumber.Name = "Lbl_PortNumber";
            this.Lbl_PortNumber.Size = new System.Drawing.Size(130, 20);
            this.Lbl_PortNumber.TabIndex = 3;
            this.Lbl_PortNumber.Text = "Enter port number";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(66, 244);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(110, 20);
            this.Lbl_Password.TabIndex = 4;
            this.Lbl_Password.Text = "Enter password";
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Location = new System.Drawing.Point(217, 237);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PlaceholderText = "gns3";
            this.Tbx_Password.Size = new System.Drawing.Size(245, 27);
            this.Tbx_Password.TabIndex = 5;
            this.Tbx_Password.Text = "gns3";
            // 
            // Btn_CommandFileChooser
            // 
            this.Btn_CommandFileChooser.Location = new System.Drawing.Point(69, 332);
            this.Btn_CommandFileChooser.Name = "Btn_CommandFileChooser";
            this.Btn_CommandFileChooser.Size = new System.Drawing.Size(197, 34);
            this.Btn_CommandFileChooser.TabIndex = 6;
            this.Btn_CommandFileChooser.Text = "Select command file";
            this.Btn_CommandFileChooser.UseVisualStyleBackColor = true;
            this.Btn_CommandFileChooser.Click += new System.EventHandler(this.Btn_CommandFileChooser_Click);
            // 
            // Tbx_CommandFileDisplay
            // 
            this.Tbx_CommandFileDisplay.Location = new System.Drawing.Point(12, 372);
            this.Tbx_CommandFileDisplay.Multiline = true;
            this.Tbx_CommandFileDisplay.Name = "Tbx_CommandFileDisplay";
            this.Tbx_CommandFileDisplay.PlaceholderText = "Command text file path";
            this.Tbx_CommandFileDisplay.ReadOnly = true;
            this.Tbx_CommandFileDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_CommandFileDisplay.Size = new System.Drawing.Size(480, 57);
            this.Tbx_CommandFileDisplay.TabIndex = 7;
            this.Tbx_CommandFileDisplay.Text = "C:\\Users\\labuj\\Documents\\Degree_CS2021_yr3\\Final_Project\\TestR1Config.txt";
            // 
            // Btn_SendTelnet
            // 
            this.Btn_SendTelnet.Location = new System.Drawing.Point(68, 470);
            this.Btn_SendTelnet.Name = "Btn_SendTelnet";
            this.Btn_SendTelnet.Size = new System.Drawing.Size(115, 48);
            this.Btn_SendTelnet.TabIndex = 8;
            this.Btn_SendTelnet.Text = "Send";
            this.Btn_SendTelnet.UseVisualStyleBackColor = true;
            this.Btn_SendTelnet.Click += new System.EventHandler(this.Btn_SendTelnet_Click);
            // 
            // Btn_ClearFields
            // 
            this.Btn_ClearFields.Location = new System.Drawing.Point(272, 470);
            this.Btn_ClearFields.Name = "Btn_ClearFields";
            this.Btn_ClearFields.Size = new System.Drawing.Size(115, 48);
            this.Btn_ClearFields.TabIndex = 10;
            this.Btn_ClearFields.Text = "Clear fields";
            this.Btn_ClearFields.UseVisualStyleBackColor = true;
            this.Btn_ClearFields.Click += new System.EventHandler(this.Btn_ClearFields_Click);
            // 
            // Btn_ExitTelnetPage
            // 
            this.Btn_ExitTelnetPage.Location = new System.Drawing.Point(644, 470);
            this.Btn_ExitTelnetPage.Name = "Btn_ExitTelnetPage";
            this.Btn_ExitTelnetPage.Size = new System.Drawing.Size(115, 48);
            this.Btn_ExitTelnetPage.TabIndex = 11;
            this.Btn_ExitTelnetPage.Text = "Close";
            this.Btn_ExitTelnetPage.UseVisualStyleBackColor = true;
            this.Btn_ExitTelnetPage.Click += new System.EventHandler(this.Btn_ExitTelnetPage_Click);
            // 
            // Lbl_SelectAdaptor
            // 
            this.Lbl_SelectAdaptor.AutoSize = true;
            this.Lbl_SelectAdaptor.Location = new System.Drawing.Point(66, 56);
            this.Lbl_SelectAdaptor.Name = "Lbl_SelectAdaptor";
            this.Lbl_SelectAdaptor.Size = new System.Drawing.Size(106, 20);
            this.Lbl_SelectAdaptor.TabIndex = 12;
            this.Lbl_SelectAdaptor.Text = "Select adaptor";
            // 
            // Cmbx_AdaptorChoice
            // 
            this.Cmbx_AdaptorChoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Cmbx_AdaptorChoice.FormattingEnabled = true;
            this.Cmbx_AdaptorChoice.Location = new System.Drawing.Point(217, 53);
            this.Cmbx_AdaptorChoice.Name = "Cmbx_AdaptorChoice";
            this.Cmbx_AdaptorChoice.Size = new System.Drawing.Size(245, 28);
            this.Cmbx_AdaptorChoice.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(196, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "*";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(196, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(196, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(196, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(272, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(68, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(371, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telnet command file to device";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(69, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "** Please fill in all fields";
            this.label11.Visible = false;
            // 
            // Tbx_CommsDisplay
            // 
            this.Tbx_CommsDisplay.Location = new System.Drawing.Point(498, 47);
            this.Tbx_CommsDisplay.Multiline = true;
            this.Tbx_CommsDisplay.Name = "Tbx_CommsDisplay";
            this.Tbx_CommsDisplay.ReadOnly = true;
            this.Tbx_CommsDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_CommsDisplay.Size = new System.Drawing.Size(261, 382);
            this.Tbx_CommsDisplay.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comms display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter device name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(196, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "*";
            this.label3.Visible = false;
            // 
            // Tbx_Username
            // 
            this.Tbx_Username.Location = new System.Drawing.Point(217, 191);
            this.Tbx_Username.Name = "Tbx_Username";
            this.Tbx_Username.PlaceholderText = "gns3";
            this.Tbx_Username.Size = new System.Drawing.Size(245, 27);
            this.Tbx_Username.TabIndex = 26;
            this.Tbx_Username.Text = "gns3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(196, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "*";
            this.label4.Visible = false;
            // 
            // Tbx_secretPassword
            // 
            this.Tbx_secretPassword.Location = new System.Drawing.Point(217, 281);
            this.Tbx_secretPassword.Name = "Tbx_secretPassword";
            this.Tbx_secretPassword.PlaceholderText = "gns3";
            this.Tbx_secretPassword.Size = new System.Drawing.Size(245, 27);
            this.Tbx_secretPassword.TabIndex = 28;
            this.Tbx_secretPassword.Text = "gns3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Enter secret password";
            // 
            // TelnetToDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbx_secretPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Tbx_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_CommsDisplay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmbx_AdaptorChoice);
            this.Controls.Add(this.Lbl_SelectAdaptor);
            this.Controls.Add(this.Btn_ExitTelnetPage);
            this.Controls.Add(this.Btn_ClearFields);
            this.Controls.Add(this.Btn_SendTelnet);
            this.Controls.Add(this.Tbx_CommandFileDisplay);
            this.Controls.Add(this.Btn_CommandFileChooser);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_PortNumber);
            this.Controls.Add(this.Tbx_PortNum);
            this.Controls.Add(this.Tbx_IPAddress);
            this.Controls.Add(this.Lbl_IPAddress);
            this.Name = "TelnetToDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelnetTo_Device";
            this.Load += new System.EventHandler(this.TelnetToDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IPAddress;
        private System.Windows.Forms.TextBox Tbx_IPAddress;
        private System.Windows.Forms.TextBox Tbx_PortNum;
        private System.Windows.Forms.Label Lbl_PortNumber;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.Button Btn_CommandFileChooser;
        private System.Windows.Forms.TextBox Tbx_CommandFileDisplay;
        private System.Windows.Forms.Button Btn_SendTelnet;
        private System.Windows.Forms.Button Btn_ClearFields;
        private System.Windows.Forms.Button Btn_ExitTelnetPage;
        private System.Windows.Forms.Label Lbl_SelectAdaptor;
        private System.Windows.Forms.ComboBox Cmbx_AdaptorChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tbx_CommsDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Tbx_secretPassword;
    }
}
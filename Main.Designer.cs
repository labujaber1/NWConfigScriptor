
namespace NWConfigScriptor
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleMain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_VmTftpTrans = new System.Windows.Forms.Button();
            this.Btn_Telnet = new System.Windows.Forms.Button();
            this.Btn_CreateScript = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.Lbl_TitleMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 78);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_TitleMain
            // 
            this.Lbl_TitleMain.AutoSize = true;
            this.Lbl_TitleMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TitleMain.Location = new System.Drawing.Point(20, 19);
            this.Lbl_TitleMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleMain.Name = "Lbl_TitleMain";
            this.Lbl_TitleMain.Size = new System.Drawing.Size(364, 37);
            this.Lbl_TitleMain.TabIndex = 0;
            this.Lbl_TitleMain.Text = "ConfigScriptor Main Menu ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.Btn_Exit);
            this.panel2.Controls.Add(this.Btn_VmTftpTrans);
            this.panel2.Controls.Add(this.Btn_Telnet);
            this.panel2.Controls.Add(this.Btn_CreateScript);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 575);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_Exit.Location = new System.Drawing.Point(32, 408);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(125, 58);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_VmTftpTrans
            // 
            this.Btn_VmTftpTrans.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_VmTftpTrans.Location = new System.Drawing.Point(32, 239);
            this.Btn_VmTftpTrans.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_VmTftpTrans.Name = "Btn_VmTftpTrans";
            this.Btn_VmTftpTrans.Size = new System.Drawing.Size(125, 62);
            this.Btn_VmTftpTrans.TabIndex = 2;
            this.Btn_VmTftpTrans.Text = "VmTftp Transfer";
            this.Btn_VmTftpTrans.UseVisualStyleBackColor = false;
            this.Btn_VmTftpTrans.Click += new System.EventHandler(this.Btn_VmTftpTrans_Click);
            // 
            // Btn_Telnet
            // 
            this.Btn_Telnet.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_Telnet.Location = new System.Drawing.Point(32, 154);
            this.Btn_Telnet.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Telnet.Name = "Btn_Telnet";
            this.Btn_Telnet.Size = new System.Drawing.Size(125, 62);
            this.Btn_Telnet.TabIndex = 1;
            this.Btn_Telnet.Text = "Telnet to device";
            this.Btn_Telnet.UseVisualStyleBackColor = false;
            this.Btn_Telnet.Click += new System.EventHandler(this.Btn_Telnet_Click);
            // 
            // Btn_CreateScript
            // 
            this.Btn_CreateScript.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_CreateScript.Location = new System.Drawing.Point(32, 70);
            this.Btn_CreateScript.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_CreateScript.Name = "Btn_CreateScript";
            this.Btn_CreateScript.Size = new System.Drawing.Size(125, 62);
            this.Btn_CreateScript.TabIndex = 0;
            this.Btn_CreateScript.Text = "Create script";
            this.Btn_CreateScript.UseVisualStyleBackColor = false;
            this.Btn_CreateScript.Click += new System.EventHandler(this.Btn_CreateScript_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(994, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 575);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(191, 626);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 27);
            this.panel4.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1019, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_VmTftpTrans;
        private System.Windows.Forms.Button Btn_Telnet;
        private System.Windows.Forms.Button Btn_CreateScript;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
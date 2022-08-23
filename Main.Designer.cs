
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
            this.Btn_AddToGns3 = new System.Windows.Forms.Button();
            this.Btn_CreateScript = new System.Windows.Forms.Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 94);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_TitleMain
            // 
            this.Lbl_TitleMain.AutoSize = true;
            this.Lbl_TitleMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TitleMain.Location = new System.Drawing.Point(25, 24);
            this.Lbl_TitleMain.Name = "Lbl_TitleMain";
            this.Lbl_TitleMain.Size = new System.Drawing.Size(429, 45);
            this.Lbl_TitleMain.TabIndex = 0;
            this.Lbl_TitleMain.Text = "ConfigScriptor Main Menu ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.Btn_Exit);
            this.panel2.Controls.Add(this.Btn_VmTftpTrans);
            this.panel2.Controls.Add(this.Btn_AddToGns3);
            this.panel2.Controls.Add(this.Btn_CreateScript);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 680);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_Exit.Location = new System.Drawing.Point(40, 510);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(156, 73);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_VmTftpTrans
            // 
            this.Btn_VmTftpTrans.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_VmTftpTrans.Location = new System.Drawing.Point(40, 240);
            this.Btn_VmTftpTrans.Name = "Btn_VmTftpTrans";
            this.Btn_VmTftpTrans.Size = new System.Drawing.Size(156, 77);
            this.Btn_VmTftpTrans.TabIndex = 2;
            this.Btn_VmTftpTrans.Text = "VmTftp Transfer";
            this.Btn_VmTftpTrans.UseVisualStyleBackColor = false;
            this.Btn_VmTftpTrans.Click += new System.EventHandler(this.Btn_VmTftpTrans_Click);
            // 
            // Btn_AddToGns3
            // 
            this.Btn_AddToGns3.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_AddToGns3.Location = new System.Drawing.Point(40, 133);
            this.Btn_AddToGns3.Name = "Btn_AddToGns3";
            this.Btn_AddToGns3.Size = new System.Drawing.Size(156, 77);
            this.Btn_AddToGns3.TabIndex = 1;
            this.Btn_AddToGns3.Text = "Add to Gns3";
            this.Btn_AddToGns3.UseVisualStyleBackColor = false;
            this.Btn_AddToGns3.Click += new System.EventHandler(this.Btn_AddToGns3_Click);
            // 
            // Btn_CreateScript
            // 
            this.Btn_CreateScript.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_CreateScript.Location = new System.Drawing.Point(40, 28);
            this.Btn_CreateScript.Name = "Btn_CreateScript";
            this.Btn_CreateScript.Size = new System.Drawing.Size(156, 77);
            this.Btn_CreateScript.TabIndex = 0;
            this.Btn_CreateScript.Text = "Create script";
            this.Btn_CreateScript.UseVisualStyleBackColor = false;
            this.Btn_CreateScript.Click += new System.EventHandler(this.Btn_CreateScript_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "Main";
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
        private System.Windows.Forms.Button Btn_AddToGns3;
        private System.Windows.Forms.Button Btn_CreateScript;
    }
}
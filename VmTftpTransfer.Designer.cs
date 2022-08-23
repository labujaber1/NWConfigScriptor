
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
            this.SuspendLayout();
            // 
            // Btn_ExitVmTftpTransfer
            // 
            this.Btn_ExitVmTftpTransfer.Location = new System.Drawing.Point(740, 545);
            this.Btn_ExitVmTftpTransfer.Name = "Btn_ExitVmTftpTransfer";
            this.Btn_ExitVmTftpTransfer.Size = new System.Drawing.Size(137, 74);
            this.Btn_ExitVmTftpTransfer.TabIndex = 0;
            this.Btn_ExitVmTftpTransfer.Text = "Exit";
            this.Btn_ExitVmTftpTransfer.UseVisualStyleBackColor = true;
            this.Btn_ExitVmTftpTransfer.Click += new System.EventHandler(this.Btn_ExitVmTftpTransfer_Click);
            // 
            // Btn_OpenTftpd64
            // 
            this.Btn_OpenTftpd64.Location = new System.Drawing.Point(193, 545);
            this.Btn_OpenTftpd64.Name = "Btn_OpenTftpd64";
            this.Btn_OpenTftpd64.Size = new System.Drawing.Size(122, 60);
            this.Btn_OpenTftpd64.TabIndex = 1;
            this.Btn_OpenTftpd64.Text = "Open Tftpd64";
            this.Btn_OpenTftpd64.UseVisualStyleBackColor = true;
            this.Btn_OpenTftpd64.Click += new System.EventHandler(this.Btn_OpenTftpd64_Click);
            // 
            // VmTftpTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(985, 675);
            this.Controls.Add(this.Btn_OpenTftpd64);
            this.Controls.Add(this.Btn_ExitVmTftpTransfer);
            this.Name = "VmTftpTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VmTftpTransfer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExitVmTftpTransfer;
        private System.Windows.Forms.Button Btn_OpenTftpd64;
    }
}

namespace NWConfigScriptor
{
    partial class AddToGns3Form
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
            this.Btn_ExitGns3Form = new System.Windows.Forms.Button();
            this.Cklbx_ScriptList = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Gns3Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_ScriptList = new System.Windows.Forms.Label();
            this.Tbx_UserPath = new System.Windows.Forms.TextBox();
            this.Cklbx_Gns3Configs = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ExitGns3Form
            // 
            this.Btn_ExitGns3Form.BackColor = System.Drawing.Color.Fuchsia;
            this.Btn_ExitGns3Form.Location = new System.Drawing.Point(773, 16);
            this.Btn_ExitGns3Form.Name = "Btn_ExitGns3Form";
            this.Btn_ExitGns3Form.Size = new System.Drawing.Size(135, 65);
            this.Btn_ExitGns3Form.TabIndex = 0;
            this.Btn_ExitGns3Form.Text = "Exit";
            this.Btn_ExitGns3Form.UseVisualStyleBackColor = false;
            this.Btn_ExitGns3Form.Click += new System.EventHandler(this.Btn_ExitGns3Form_Click);
            // 
            // Cklbx_ScriptList
            // 
            this.Cklbx_ScriptList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cklbx_ScriptList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Cklbx_ScriptList.FormattingEnabled = true;
            this.Cklbx_ScriptList.Location = new System.Drawing.Point(26, 197);
            this.Cklbx_ScriptList.Name = "Cklbx_ScriptList";
            this.Cklbx_ScriptList.Size = new System.Drawing.Size(281, 340);
            this.Cklbx_ScriptList.TabIndex = 1;
            this.Cklbx_ScriptList.ThreeDCheckBoxes = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.Lbl_Gns3Title);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 110);
            this.panel2.TabIndex = 3;
            // 
            // Lbl_Gns3Title
            // 
            this.Lbl_Gns3Title.AutoSize = true;
            this.Lbl_Gns3Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Gns3Title.Location = new System.Drawing.Point(299, 33);
            this.Lbl_Gns3Title.Name = "Lbl_Gns3Title";
            this.Lbl_Gns3Title.Size = new System.Drawing.Size(374, 45);
            this.Lbl_Gns3Title.TabIndex = 0;
            this.Lbl_Gns3Title.Text = "Replace Gns3 config files";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.Btn_ExitGns3Form);
            this.panel3.Location = new System.Drawing.Point(-1, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 102);
            this.panel3.TabIndex = 4;
            // 
            // Lbl_ScriptList
            // 
            this.Lbl_ScriptList.AutoSize = true;
            this.Lbl_ScriptList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ScriptList.Location = new System.Drawing.Point(26, 137);
            this.Lbl_ScriptList.Name = "Lbl_ScriptList";
            this.Lbl_ScriptList.Size = new System.Drawing.Size(266, 50);
            this.Lbl_ScriptList.TabIndex = 2;
            this.Lbl_ScriptList.Text = "List of config scripts in the\r\napplications ConfigScripts folder";
            // 
            // Tbx_UserPath
            // 
            this.Tbx_UserPath.Location = new System.Drawing.Point(356, 137);
            this.Tbx_UserPath.Multiline = true;
            this.Tbx_UserPath.Name = "Tbx_UserPath";
            this.Tbx_UserPath.PlaceholderText = "User path";
            this.Tbx_UserPath.Size = new System.Drawing.Size(298, 31);
            this.Tbx_UserPath.TabIndex = 5;
            // 
            // Cklbx_Gns3Configs
            // 
            this.Cklbx_Gns3Configs.FormattingEnabled = true;
            this.Cklbx_Gns3Configs.Location = new System.Drawing.Point(356, 197);
            this.Cklbx_Gns3Configs.Name = "Cklbx_Gns3Configs";
            this.Cklbx_Gns3Configs.Size = new System.Drawing.Size(298, 340);
            this.Cklbx_Gns3Configs.TabIndex = 6;
            this.Cklbx_Gns3Configs.ThreeDCheckBoxes = true;
            // 
            // AddToGns3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(985, 675);
            this.Controls.Add(this.Cklbx_Gns3Configs);
            this.Controls.Add(this.Tbx_UserPath);
            this.Controls.Add(this.Lbl_ScriptList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Cklbx_ScriptList);
            this.Controls.Add(this.panel2);
            this.Name = "AddToGns3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToGns3Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExitGns3Form;
        private System.Windows.Forms.CheckedListBox Cklbx_ScriptList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_ScriptList;
        private System.Windows.Forms.Label Lbl_Gns3Title;
        private System.Windows.Forms.TextBox Tbx_UserPath;
        private System.Windows.Forms.CheckedListBox Cklbx_Gns3Configs;
    }
}
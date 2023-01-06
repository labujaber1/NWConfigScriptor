
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
            this.Cklbx_Gns3Projects = new System.Windows.Forms.CheckedListBox();
            this.Cklbx_ProjectDevices = new System.Windows.Forms.CheckedListBox();
            this.Lbl_UserPath = new System.Windows.Forms.Label();
            this.Btn_OtherConfigFolder = new System.Windows.Forms.Button();
            this.Btn_Append = new System.Windows.Forms.Button();
            this.Btn_ReplaceConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_SelectAppPath = new System.Windows.Forms.Button();
            this.Btn_ConvertTxtToConfig = new System.Windows.Forms.Button();
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
            this.Cklbx_ScriptList.CheckOnClick = true;
            this.Cklbx_ScriptList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Cklbx_ScriptList.FormattingEnabled = true;
            this.Cklbx_ScriptList.Location = new System.Drawing.Point(24, 154);
            this.Cklbx_ScriptList.Name = "Cklbx_ScriptList";
            this.Cklbx_ScriptList.Size = new System.Drawing.Size(281, 228);
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
            this.panel2.Size = new System.Drawing.Size(986, 85);
            this.panel2.TabIndex = 3;
            // 
            // Lbl_Gns3Title
            // 
            this.Lbl_Gns3Title.AutoSize = true;
            this.Lbl_Gns3Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Gns3Title.Location = new System.Drawing.Point(313, 9);
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
            this.Lbl_ScriptList.Location = new System.Drawing.Point(12, 94);
            this.Lbl_ScriptList.Name = "Lbl_ScriptList";
            this.Lbl_ScriptList.Size = new System.Drawing.Size(316, 50);
            this.Lbl_ScriptList.TabIndex = 2;
            this.Lbl_ScriptList.Text = "List of generated config .txt scripts\r\nin the applications ConfigScripts folder";
            // 
            // Tbx_UserPath
            // 
            this.Tbx_UserPath.Location = new System.Drawing.Point(432, 94);
            this.Tbx_UserPath.Multiline = true;
            this.Tbx_UserPath.Name = "Tbx_UserPath";
            this.Tbx_UserPath.PlaceholderText = "User path";
            this.Tbx_UserPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_UserPath.Size = new System.Drawing.Size(486, 65);
            this.Tbx_UserPath.TabIndex = 5;
            // 
            // Cklbx_Gns3Projects
            // 
            this.Cklbx_Gns3Projects.CheckOnClick = true;
            this.Cklbx_Gns3Projects.FormattingEnabled = true;
            this.Cklbx_Gns3Projects.HorizontalScrollbar = true;
            this.Cklbx_Gns3Projects.Location = new System.Drawing.Point(490, 187);
            this.Cklbx_Gns3Projects.Name = "Cklbx_Gns3Projects";
            this.Cklbx_Gns3Projects.Size = new System.Drawing.Size(428, 88);
            this.Cklbx_Gns3Projects.TabIndex = 6;
            this.Cklbx_Gns3Projects.ThreeDCheckBoxes = true;
            this.Cklbx_Gns3Projects.SelectedIndexChanged += new System.EventHandler(this.Cklbx_Gns3Projects_SelectedIndexChanged);
            // 
            // Cklbx_ProjectDevices
            // 
            this.Cklbx_ProjectDevices.CheckOnClick = true;
            this.Cklbx_ProjectDevices.FormattingEnabled = true;
            this.Cklbx_ProjectDevices.Location = new System.Drawing.Point(490, 326);
            this.Cklbx_ProjectDevices.Name = "Cklbx_ProjectDevices";
            this.Cklbx_ProjectDevices.Size = new System.Drawing.Size(428, 228);
            this.Cklbx_ProjectDevices.TabIndex = 7;
            // 
            // Lbl_UserPath
            // 
            this.Lbl_UserPath.AutoSize = true;
            this.Lbl_UserPath.Location = new System.Drawing.Point(338, 97);
            this.Lbl_UserPath.Name = "Lbl_UserPath";
            this.Lbl_UserPath.Size = new System.Drawing.Size(88, 25);
            this.Lbl_UserPath.TabIndex = 8;
            this.Lbl_UserPath.Text = "User path";
            // 
            // Btn_OtherConfigFolder
            // 
            this.Btn_OtherConfigFolder.Location = new System.Drawing.Point(311, 154);
            this.Btn_OtherConfigFolder.Name = "Btn_OtherConfigFolder";
            this.Btn_OtherConfigFolder.Size = new System.Drawing.Size(43, 36);
            this.Btn_OtherConfigFolder.TabIndex = 9;
            this.Btn_OtherConfigFolder.Text = " : ";
            this.Btn_OtherConfigFolder.UseVisualStyleBackColor = true;
            this.Btn_OtherConfigFolder.Click += new System.EventHandler(this.Btn_OtherConfigFolder_Click);
            // 
            // Btn_Append
            // 
            this.Btn_Append.Location = new System.Drawing.Point(24, 486);
            this.Btn_Append.Name = "Btn_Append";
            this.Btn_Append.Size = new System.Drawing.Size(281, 68);
            this.Btn_Append.TabIndex = 10;
            this.Btn_Append.Text = "APPEND textf to start-up config file";
            this.Btn_Append.UseVisualStyleBackColor = true;
            this.Btn_Append.Click += new System.EventHandler(this.Btn_Append_Click);
            // 
            // Btn_ReplaceConfig
            // 
            this.Btn_ReplaceConfig.Location = new System.Drawing.Point(327, 411);
            this.Btn_ReplaceConfig.Name = "Btn_ReplaceConfig";
            this.Btn_ReplaceConfig.Size = new System.Drawing.Size(112, 143);
            this.Btn_ReplaceConfig.TabIndex = 11;
            this.Btn_ReplaceConfig.Text = "REPLACE start-up config file";
            this.Btn_ReplaceConfig.UseVisualStyleBackColor = true;
            this.Btn_ReplaceConfig.Click += new System.EventHandler(this.Btn_ReplaceConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Projects: click a project to view its devices below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Project devices: select the file to append to or replace";
            // 
            // Btn_SelectAppPath
            // 
            this.Btn_SelectAppPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SelectAppPath.Location = new System.Drawing.Point(924, 94);
            this.Btn_SelectAppPath.Name = "Btn_SelectAppPath";
            this.Btn_SelectAppPath.Size = new System.Drawing.Size(38, 39);
            this.Btn_SelectAppPath.TabIndex = 14;
            this.Btn_SelectAppPath.Text = ":";
            this.Btn_SelectAppPath.UseVisualStyleBackColor = true;
            this.Btn_SelectAppPath.Click += new System.EventHandler(this.Btn_SelectAppPath_Click);
            // 
            // Btn_ConvertTxtToConfig
            // 
            this.Btn_ConvertTxtToConfig.Location = new System.Drawing.Point(24, 411);
            this.Btn_ConvertTxtToConfig.Name = "Btn_ConvertTxtToConfig";
            this.Btn_ConvertTxtToConfig.Size = new System.Drawing.Size(281, 69);
            this.Btn_ConvertTxtToConfig.TabIndex = 15;
            this.Btn_ConvertTxtToConfig.Text = "CONVERT textf to startup-configf";
            this.Btn_ConvertTxtToConfig.UseVisualStyleBackColor = true;
            this.Btn_ConvertTxtToConfig.Click += new System.EventHandler(this.Btn_ConvertTxtToConfig_Click);
            // 
            // AddToGns3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(985, 675);
            this.Controls.Add(this.Btn_ConvertTxtToConfig);
            this.Controls.Add(this.Btn_ReplaceConfig);
            this.Controls.Add(this.Btn_SelectAppPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Append);
            this.Controls.Add(this.Btn_OtherConfigFolder);
            this.Controls.Add(this.Lbl_UserPath);
            this.Controls.Add(this.Cklbx_ProjectDevices);
            this.Controls.Add(this.Cklbx_Gns3Projects);
            this.Controls.Add(this.Tbx_UserPath);
            this.Controls.Add(this.Lbl_ScriptList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Cklbx_ScriptList);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private System.Windows.Forms.CheckedListBox Cklbx_Gns3Projects;
        private System.Windows.Forms.CheckedListBox Cklbx_ProjectDevices;
        private System.Windows.Forms.Label Lbl_UserPath;
        private System.Windows.Forms.Button Btn_OtherConfigFolder;
        private System.Windows.Forms.Button Btn_Append;
        private System.Windows.Forms.Button Btn_ReplaceConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SelectAppPath;
        private System.Windows.Forms.Button Btn_ConvertTxtToConfig;
    }
}
//##########################################//
//                                          //
// Project: Network Scriptor Config Creater //
// Author:  L. Abu-Jaber                    //
// Date:    09/05/2022                      //
// Control System: Github                   //
//                                          //
//##########################################//

namespace NWConfigScriptor
{
    /// <summary>
    /// ConfigScriptorForm
    /// </summary>
    partial class ConfigScriptorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.CmbxCmdScriptList = new System.Windows.Forms.ComboBox();
            this.LblCmmdDisplay = new System.Windows.Forms.Label();
            this.LbxConfigScript = new System.Windows.Forms.ListBox();
            this.LblScriptEditor = new System.Windows.Forms.Label();
            this.RtbxScript = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateScriptListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblInfo2 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.TbShowCommands = new System.Windows.Forms.TextBox();
            this.BtnAppendDisplay = new System.Windows.Forms.Button();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.BtnClearDisplay = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblPoint = new System.Windows.Forms.Label();
            this.LblAbout = new System.Windows.Forms.Label();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.AutoSize = true;
            this.LblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(299, 9);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(403, 38);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "Network Configuration Scriptor";
            // 
            // CmbxCmdScriptList
            // 
            this.CmbxCmdScriptList.BackColor = System.Drawing.SystemColors.Control;
            this.CmbxCmdScriptList.FormattingEnabled = true;
            this.CmbxCmdScriptList.Location = new System.Drawing.Point(14, 66);
            this.CmbxCmdScriptList.Name = "CmbxCmdScriptList";
            this.CmbxCmdScriptList.Size = new System.Drawing.Size(334, 36);
            this.CmbxCmdScriptList.TabIndex = 1;
            this.CmbxCmdScriptList.Text = "- Select command file -";
            this.CmbxCmdScriptList.SelectedIndexChanged += new System.EventHandler(this.CmbxCmdScriptList_SelectedIndexChanged);
            // 
            // LblCmmdDisplay
            // 
            this.LblCmmdDisplay.AutoSize = true;
            this.LblCmmdDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCmmdDisplay.Location = new System.Drawing.Point(168, 110);
            this.LblCmmdDisplay.Name = "LblCmmdDisplay";
            this.LblCmmdDisplay.Size = new System.Drawing.Size(180, 28);
            this.LblCmmdDisplay.TabIndex = 2;
            this.LblCmmdDisplay.Text = "Command display";
            // 
            // LbxConfigScript
            // 
            this.LbxConfigScript.BackColor = System.Drawing.SystemColors.Control;
            this.LbxConfigScript.FormattingEnabled = true;
            this.LbxConfigScript.HorizontalScrollbar = true;
            this.LbxConfigScript.ItemHeight = 28;
            this.LbxConfigScript.Location = new System.Drawing.Point(14, 141);
            this.LbxConfigScript.Name = "LbxConfigScript";
            this.LbxConfigScript.ScrollAlwaysVisible = true;
            this.LbxConfigScript.Size = new System.Drawing.Size(505, 368);
            this.LbxConfigScript.TabIndex = 3;
            this.LbxConfigScript.DoubleClick += new System.EventHandler(this.LbxConfigScript_DoubleClick);
            // 
            // LblScriptEditor
            // 
            this.LblScriptEditor.AutoSize = true;
            this.LblScriptEditor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblScriptEditor.Location = new System.Drawing.Point(707, 57);
            this.LblScriptEditor.Name = "LblScriptEditor";
            this.LblScriptEditor.Size = new System.Drawing.Size(130, 28);
            this.LblScriptEditor.TabIndex = 4;
            this.LblScriptEditor.Text = "Script editor";
            // 
            // RtbxScript
            // 
            this.RtbxScript.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RtbxScript.ContextMenuStrip = this.ContextMenuStrip1;
            this.RtbxScript.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbxScript.Location = new System.Drawing.Point(571, 88);
            this.RtbxScript.Name = "RtbxScript";
            this.RtbxScript.Size = new System.Drawing.Size(402, 271);
            this.RtbxScript.TabIndex = 5;
            this.RtbxScript.Text = "";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem,
            this.SelectAllCopyToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.LoadFileToolStripMenuItem,
            this.AppendToFileToolStripMenuItem,
            this.updateScriptListToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(256, 260);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.SelectAllToolStripMenuItem.Text = "Select all";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // SelectAllCopyToolStripMenuItem
            // 
            this.SelectAllCopyToolStripMenuItem.Name = "SelectAllCopyToolStripMenuItem";
            this.SelectAllCopyToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.SelectAllCopyToolStripMenuItem.Text = "Select all copy";
            this.SelectAllCopyToolStripMenuItem.Click += new System.EventHandler(this.SelectAllCopyToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.SaveFileToolStripMenuItem.Text = "Save file";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // LoadFileToolStripMenuItem
            // 
            this.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            this.LoadFileToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.LoadFileToolStripMenuItem.Text = "Load file";
            this.LoadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // AppendToFileToolStripMenuItem
            // 
            this.AppendToFileToolStripMenuItem.Name = "AppendToFileToolStripMenuItem";
            this.AppendToFileToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.AppendToFileToolStripMenuItem.Text = "Append to file";
            this.AppendToFileToolStripMenuItem.Click += new System.EventHandler(this.AppendToFileToolStripMenuItem_Click);
            // 
            // updateScriptListToolStripMenuItem
            // 
            this.updateScriptListToolStripMenuItem.Name = "updateScriptListToolStripMenuItem";
            this.updateScriptListToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.updateScriptListToolStripMenuItem.Text = "Update command list";
            this.updateScriptListToolStripMenuItem.Click += new System.EventHandler(this.UpdateCommandListToolStripMenuItem_Click);
            // 
            // LblInfo2
            // 
            this.LblInfo2.AutoSize = true;
            this.LblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInfo2.Location = new System.Drawing.Point(14, 521);
            this.LblInfo2.Name = "LblInfo2";
            this.LblInfo2.Size = new System.Drawing.Size(424, 58);
            this.LblInfo2.TabIndex = 7;
            this.LblInfo2.Text = "Double click command to append to editor.\r\nInsert command into editor using butto" +
    "n below.";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInfo.Location = new System.Drawing.Point(571, 362);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(355, 86);
            this.LblInfo.TabIndex = 8;
            this.LblInfo.Text = "Edit text as normal, insert a command  \r\nbetween commands. Right click or\r\nCtl+C " +
    "to copy to the clipboard.";
            // 
            // TbShowCommands
            // 
            this.TbShowCommands.Location = new System.Drawing.Point(571, 466);
            this.TbShowCommands.Multiline = true;
            this.TbShowCommands.Name = "TbShowCommands";
            this.TbShowCommands.ReadOnly = true;
            this.TbShowCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbShowCommands.Size = new System.Drawing.Size(402, 128);
            this.TbShowCommands.TabIndex = 9;
            // 
            // BtnAppendDisplay
            // 
            this.BtnAppendDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAppendDisplay.Location = new System.Drawing.Point(14, 598);
            this.BtnAppendDisplay.Name = "BtnAppendDisplay";
            this.BtnAppendDisplay.Size = new System.Drawing.Size(124, 67);
            this.BtnAppendDisplay.TabIndex = 10;
            this.BtnAppendDisplay.Text = "Insert in editor";
            this.BtnAppendDisplay.UseVisualStyleBackColor = true;
            this.BtnAppendDisplay.Click += new System.EventHandler(this.BtnAppendDisplay_Click);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveFile.Location = new System.Drawing.Point(158, 598);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(124, 65);
            this.BtnSaveFile.TabIndex = 11;
            this.BtnSaveFile.Text = "Save editor to file";
            this.BtnSaveFile.UseVisualStyleBackColor = true;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // BtnClearDisplay
            // 
            this.BtnClearDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClearDisplay.Location = new System.Drawing.Point(299, 598);
            this.BtnClearDisplay.Name = "BtnClearDisplay";
            this.BtnClearDisplay.Size = new System.Drawing.Size(124, 67);
            this.BtnClearDisplay.TabIndex = 12;
            this.BtnClearDisplay.Text = "Clear editor";
            this.BtnClearDisplay.UseVisualStyleBackColor = true;
            this.BtnClearDisplay.Click += new System.EventHandler(this.BtnClearDisplay_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(828, 598);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 65);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblPoint
            // 
            this.LblPoint.AutoSize = true;
            this.LblPoint.Location = new System.Drawing.Point(525, 208);
            this.LblPoint.Name = "LblPoint";
            this.LblPoint.Size = new System.Drawing.Size(40, 56);
            this.LblPoint.TabIndex = 14;
            this.LblPoint.Text = ">>\r\n>>";
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAbout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblAbout.Location = new System.Drawing.Point(888, 23);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(54, 23);
            this.LblAbout.TabIndex = 15;
            this.LblAbout.Text = "About";
            this.LblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddFile.Location = new System.Drawing.Point(443, 598);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(112, 68);
            this.BtnAddFile.TabIndex = 16;
            this.BtnAddFile.Text = "Add cmmd file";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteFile.Location = new System.Drawing.Point(571, 598);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(112, 69);
            this.BtnDeleteFile.TabIndex = 17;
            this.BtnDeleteFile.Text = "Delete cmmd file";
            this.BtnDeleteFile.UseVisualStyleBackColor = true;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // ConfigScriptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 675);
            this.Controls.Add(this.BtnDeleteFile);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.LblPoint);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearDisplay);
            this.Controls.Add(this.BtnSaveFile);
            this.Controls.Add(this.BtnAppendDisplay);
            this.Controls.Add(this.TbShowCommands);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblInfo2);
            this.Controls.Add(this.RtbxScript);
            this.Controls.Add(this.LblScriptEditor);
            this.Controls.Add(this.LbxConfigScript);
            this.Controls.Add(this.LblCmmdDisplay);
            this.Controls.Add(this.CmbxCmdScriptList);
            this.Controls.Add(this.LblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigScriptorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr Scriptor";
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPageTitle;
        private System.Windows.Forms.ComboBox CmbxCmdScriptList;
        private System.Windows.Forms.Label LblCmmdDisplay;
        private System.Windows.Forms.ListBox LbxConfigScript;
        private System.Windows.Forms.Label LblScriptEditor;
        private System.Windows.Forms.RichTextBox RtbxScript;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label LblInfo2;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TextBox TbShowCommands;
        private System.Windows.Forms.Button BtnAppendDisplay;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.Button BtnClearDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblPoint;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppendToFileToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.ToolStripMenuItem updateScriptListToolStripMenuItem;
        private System.Windows.Forms.Button BtnDeleteFile;
    }
}


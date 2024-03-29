﻿//##########################################//
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
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.BtnClearDisplay = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblPoint = new System.Windows.Forms.Label();
            this.LblAbout = new System.Windows.Forms.Label();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.Btn_OpenPutty = new System.Windows.Forms.Button();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.AutoSize = true;
            this.LblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(14, 9);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(347, 32);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "Network Configuration Scriptor";
            // 
            // CmbxCmdScriptList
            // 
            this.CmbxCmdScriptList.BackColor = System.Drawing.SystemColors.Control;
            this.CmbxCmdScriptList.FormattingEnabled = true;
            this.CmbxCmdScriptList.Location = new System.Drawing.Point(12, 53);
            this.CmbxCmdScriptList.Name = "CmbxCmdScriptList";
            this.CmbxCmdScriptList.Size = new System.Drawing.Size(334, 31);
            this.CmbxCmdScriptList.TabIndex = 1;
            this.CmbxCmdScriptList.Text = "- Select command file -";
            this.CmbxCmdScriptList.SelectedIndexChanged += new System.EventHandler(this.CmbxCmdScriptList_SelectedIndexChanged);
            // 
            // LblCmmdDisplay
            // 
            this.LblCmmdDisplay.AutoSize = true;
            this.LblCmmdDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCmmdDisplay.Location = new System.Drawing.Point(118, 87);
            this.LblCmmdDisplay.Name = "LblCmmdDisplay";
            this.LblCmmdDisplay.Size = new System.Drawing.Size(155, 23);
            this.LblCmmdDisplay.TabIndex = 2;
            this.LblCmmdDisplay.Text = "Command display";
            // 
            // LbxConfigScript
            // 
            this.LbxConfigScript.BackColor = System.Drawing.SystemColors.Control;
            this.LbxConfigScript.FormattingEnabled = true;
            this.LbxConfigScript.HorizontalScrollbar = true;
            this.LbxConfigScript.ItemHeight = 23;
            this.LbxConfigScript.Location = new System.Drawing.Point(12, 90);
            this.LbxConfigScript.Name = "LbxConfigScript";
            this.LbxConfigScript.ScrollAlwaysVisible = true;
            this.LbxConfigScript.Size = new System.Drawing.Size(439, 280);
            this.LbxConfigScript.TabIndex = 3;
            this.LbxConfigScript.DoubleClick += new System.EventHandler(this.LbxConfigScript_DoubleClick);
            // 
            // LblScriptEditor
            // 
            this.LblScriptEditor.AutoSize = true;
            this.LblScriptEditor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblScriptEditor.Location = new System.Drawing.Point(472, 12);
            this.LblScriptEditor.Name = "LblScriptEditor";
            this.LblScriptEditor.Size = new System.Drawing.Size(112, 23);
            this.LblScriptEditor.TabIndex = 4;
            this.LblScriptEditor.Text = "Script editor";
            // 
            // RtbxScript
            // 
            this.RtbxScript.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RtbxScript.ContextMenuStrip = this.ContextMenuStrip1;
            this.RtbxScript.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbxScript.Location = new System.Drawing.Point(472, 42);
            this.RtbxScript.Name = "RtbxScript";
            this.RtbxScript.Size = new System.Drawing.Size(304, 287);
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
            this.ContextMenuStrip1.Size = new System.Drawing.Size(222, 196);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.SelectAllToolStripMenuItem.Text = "Select all";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // SelectAllCopyToolStripMenuItem
            // 
            this.SelectAllCopyToolStripMenuItem.Name = "SelectAllCopyToolStripMenuItem";
            this.SelectAllCopyToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.SelectAllCopyToolStripMenuItem.Text = "Select all copy";
            this.SelectAllCopyToolStripMenuItem.Click += new System.EventHandler(this.SelectAllCopyToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.SaveFileToolStripMenuItem.Text = "Save file";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // LoadFileToolStripMenuItem
            // 
            this.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            this.LoadFileToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.LoadFileToolStripMenuItem.Text = "Load file";
            this.LoadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // AppendToFileToolStripMenuItem
            // 
            this.AppendToFileToolStripMenuItem.Name = "AppendToFileToolStripMenuItem";
            this.AppendToFileToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.AppendToFileToolStripMenuItem.Text = "Append to file";
            this.AppendToFileToolStripMenuItem.Click += new System.EventHandler(this.AppendToFileToolStripMenuItem_Click);
            // 
            // updateScriptListToolStripMenuItem
            // 
            this.updateScriptListToolStripMenuItem.Name = "updateScriptListToolStripMenuItem";
            this.updateScriptListToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.updateScriptListToolStripMenuItem.Text = "Update command list";
            this.updateScriptListToolStripMenuItem.Click += new System.EventHandler(this.UpdateCommandListToolStripMenuItem_Click);
            // 
            // LblInfo2
            // 
            this.LblInfo2.AutoSize = true;
            this.LblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInfo2.Location = new System.Drawing.Point(14, 373);
            this.LblInfo2.Name = "LblInfo2";
            this.LblInfo2.Size = new System.Drawing.Size(327, 25);
            this.LblInfo2.TabIndex = 7;
            this.LblInfo2.Text = "Double click command to append to editor.";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInfo.Location = new System.Drawing.Point(472, 332);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(304, 71);
            this.LblInfo.TabIndex = 8;
            this.LblInfo.Text = "Edit text as normal, insert a command  \r\nbetween commands. Right click or\r\nCtl+C " +
    "to copy to the clipboard.";
            // 
            // TbShowCommands
            // 
            this.TbShowCommands.Location = new System.Drawing.Point(14, 401);
            this.TbShowCommands.Multiline = true;
            this.TbShowCommands.Name = "TbShowCommands";
            this.TbShowCommands.ReadOnly = true;
            this.TbShowCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbShowCommands.Size = new System.Drawing.Size(437, 131);
            this.TbShowCommands.TabIndex = 9;
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveFile.Location = new System.Drawing.Point(472, 412);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(92, 60);
            this.BtnSaveFile.TabIndex = 11;
            this.BtnSaveFile.Text = "Save editor to file";
            this.BtnSaveFile.UseVisualStyleBackColor = true;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // BtnClearDisplay
            // 
            this.BtnClearDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClearDisplay.Location = new System.Drawing.Point(600, 6);
            this.BtnClearDisplay.Name = "BtnClearDisplay";
            this.BtnClearDisplay.Size = new System.Drawing.Size(110, 35);
            this.BtnClearDisplay.TabIndex = 12;
            this.BtnClearDisplay.Text = "Clear editor";
            this.BtnClearDisplay.UseVisualStyleBackColor = true;
            this.BtnClearDisplay.Click += new System.EventHandler(this.BtnClearDisplay_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(684, 478);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 54);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblPoint
            // 
            this.LblPoint.AutoSize = true;
            this.LblPoint.Location = new System.Drawing.Point(432, 38);
            this.LblPoint.Name = "LblPoint";
            this.LblPoint.Size = new System.Drawing.Size(34, 46);
            this.LblPoint.TabIndex = 14;
            this.LblPoint.Text = ">>\r\n>>";
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAbout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblAbout.Location = new System.Drawing.Point(727, 6);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(49, 21);
            this.LblAbout.TabIndex = 15;
            this.LblAbout.Text = "About";
            this.LblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddFile.Location = new System.Drawing.Point(578, 412);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(92, 60);
            this.BtnAddFile.TabIndex = 16;
            this.BtnAddFile.Text = "Add cmmd file";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteFile.Location = new System.Drawing.Point(684, 412);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(92, 60);
            this.BtnDeleteFile.TabIndex = 17;
            this.BtnDeleteFile.Text = "Delete cmmd file";
            this.BtnDeleteFile.UseVisualStyleBackColor = true;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // Btn_OpenPutty
            // 
            this.Btn_OpenPutty.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_OpenPutty.Location = new System.Drawing.Point(472, 491);
            this.Btn_OpenPutty.Name = "Btn_OpenPutty";
            this.Btn_OpenPutty.Size = new System.Drawing.Size(94, 29);
            this.Btn_OpenPutty.TabIndex = 18;
            this.Btn_OpenPutty.Text = "Open putty";
            this.Btn_OpenPutty.UseVisualStyleBackColor = true;
            this.Btn_OpenPutty.Click += new System.EventHandler(this.Btn_OpenPutty_Click);
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(576, 491);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(94, 28);
            this.Btn_Help.TabIndex = 19;
            this.Btn_Help.Text = "Help";
            this.Btn_Help.UseVisualStyleBackColor = true;
            this.Btn_Help.Click += new System.EventHandler(this.Btn_Help_Click);
            // 
            // ConfigScriptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.Btn_OpenPutty);
            this.Controls.Add(this.BtnDeleteFile);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.LblPoint);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearDisplay);
            this.Controls.Add(this.BtnSaveFile);
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
        private System.Windows.Forms.Button Btn_OpenPutty;
        private System.Windows.Forms.Button Btn_Help;
    }
}


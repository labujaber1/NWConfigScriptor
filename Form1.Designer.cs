
namespace NWConfigScriptor
{
    partial class Form1
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.cmbxCmdScriptList = new System.Windows.Forms.ComboBox();
            this.lblCmmdDisplay = new System.Windows.Forms.Label();
            this.lbxConfigScript = new System.Windows.Forms.ListBox();
            this.lblScriptEditor = new System.Windows.Forms.Label();
            this.rtbxScript = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbShowCommands = new System.Windows.Forms.TextBox();
            this.btnAppendDisplay = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.Location = new System.Drawing.Point(239, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(315, 38);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Network Config Scriptor";
            // 
            // cmbxCmdScriptList
            // 
            this.cmbxCmdScriptList.FormattingEnabled = true;
            this.cmbxCmdScriptList.Location = new System.Drawing.Point(16, 51);
            this.cmbxCmdScriptList.Name = "cmbxCmdScriptList";
            this.cmbxCmdScriptList.Size = new System.Drawing.Size(324, 33);
            this.cmbxCmdScriptList.TabIndex = 1;
            this.cmbxCmdScriptList.Text = "- Select script -";
            this.cmbxCmdScriptList.SelectedIndexChanged += new System.EventHandler(this.cmbxCmdScriptList_SelectedIndexChanged);
            // 
            // lblCmmdDisplay
            // 
            this.lblCmmdDisplay.AutoSize = true;
            this.lblCmmdDisplay.Location = new System.Drawing.Point(96, 98);
            this.lblCmmdDisplay.Name = "lblCmmdDisplay";
            this.lblCmmdDisplay.Size = new System.Drawing.Size(157, 25);
            this.lblCmmdDisplay.TabIndex = 2;
            this.lblCmmdDisplay.Text = "Command display";
            // 
            // lbxConfigScript
            // 
            this.lbxConfigScript.BackColor = System.Drawing.SystemColors.Control;
            this.lbxConfigScript.FormattingEnabled = true;
            this.lbxConfigScript.ItemHeight = 25;
            this.lbxConfigScript.Location = new System.Drawing.Point(12, 135);
            this.lbxConfigScript.Name = "lbxConfigScript";
            this.lbxConfigScript.Size = new System.Drawing.Size(328, 279);
            this.lbxConfigScript.TabIndex = 3;
            this.lbxConfigScript.DoubleClick += new System.EventHandler(this.lbxConfigScript_DoubleClick);
            // 
            // lblScriptEditor
            // 
            this.lblScriptEditor.AutoSize = true;
            this.lblScriptEditor.Location = new System.Drawing.Point(523, 51);
            this.lblScriptEditor.Name = "lblScriptEditor";
            this.lblScriptEditor.Size = new System.Drawing.Size(109, 25);
            this.lblScriptEditor.TabIndex = 4;
            this.lblScriptEditor.Text = "Script editor";
            // 
            // rtbxScript
            // 
            this.rtbxScript.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbxScript.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbxScript.Location = new System.Drawing.Point(418, 83);
            this.rtbxScript.Name = "rtbxScript";
            this.rtbxScript.Size = new System.Drawing.Size(315, 242);
            this.rtbxScript.TabIndex = 5;
            this.rtbxScript.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectAllCopyToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 132);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectAllCopyToolStripMenuItem
            // 
            this.selectAllCopyToolStripMenuItem.Name = "selectAllCopyToolStripMenuItem";
            this.selectAllCopyToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.selectAllCopyToolStripMenuItem.Text = "Select all copy";
            this.selectAllCopyToolStripMenuItem.Click += new System.EventHandler(this.selectAllCopyToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo2.Location = new System.Drawing.Point(16, 432);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(396, 52);
            this.lblInfo2.TabIndex = 7;
            this.lblInfo2.Text = "Double click command to append to editor.\r\nInsert command into editor using butto" +
    "n below.";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(386, 337);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(364, 77);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Edit as normal, insert by making a line space\r\nand select from command.\r\nCtl+c co" +
    "pies to clipboard.";
            // 
            // tbShowCommands
            // 
            this.tbShowCommands.Location = new System.Drawing.Point(445, 429);
            this.tbShowCommands.Multiline = true;
            this.tbShowCommands.Name = "tbShowCommands";
            this.tbShowCommands.ReadOnly = true;
            this.tbShowCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShowCommands.Size = new System.Drawing.Size(271, 73);
            this.tbShowCommands.TabIndex = 9;
            // 
            // btnAppendDisplay
            // 
            this.btnAppendDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppendDisplay.Location = new System.Drawing.Point(37, 525);
            this.btnAppendDisplay.Name = "btnAppendDisplay";
            this.btnAppendDisplay.Size = new System.Drawing.Size(113, 58);
            this.btnAppendDisplay.TabIndex = 10;
            this.btnAppendDisplay.Text = "Insert in editor";
            this.btnAppendDisplay.UseVisualStyleBackColor = true;
            this.btnAppendDisplay.Click += new System.EventHandler(this.btnAppendDisplay_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(182, 525);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(113, 58);
            this.btnSaveFile.TabIndex = 11;
            this.btnSaveFile.Text = "Save to file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(321, 525);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(113, 58);
            this.btnClearDisplay.TabIndex = 12;
            this.btnClearDisplay.Text = "Clear editor";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(603, 534);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(352, 197);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(60, 50);
            this.lblPoint.TabIndex = 14;
            this.lblPoint.Text = ">>>>\r\n>>>>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 595);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAppendDisplay);
            this.Controls.Add(this.tbShowCommands);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.rtbxScript);
            this.Controls.Add(this.lblScriptEditor);
            this.Controls.Add(this.lbxConfigScript);
            this.Controls.Add(this.lblCmmdDisplay);
            this.Controls.Add(this.cmbxCmdScriptList);
            this.Controls.Add(this.lblPageTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mr Scriptor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.ComboBox cmbxCmdScriptList;
        private System.Windows.Forms.Label lblCmmdDisplay;
        private System.Windows.Forms.ListBox lbxConfigScript;
        private System.Windows.Forms.Label lblScriptEditor;
        private System.Windows.Forms.RichTextBox rtbxScript;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbShowCommands;
        private System.Windows.Forms.Button btnAppendDisplay;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPoint;
    }
}


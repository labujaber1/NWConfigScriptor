//##########################################//
//                                          //
// Project: Network Scriptor Config Creater //
// Author:  L. Abu-Jaber                    //
// Date:    09/05/2022                      //
// Control System: Github                   //
//                                          //
//##########################################//

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            searchAddTextFiles();
        }
        //search directory for text files
        //read into combo box cmbxCmdScriptList exclude .txt extension
        private void searchAddTextFiles()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory + "\\ConfigTextFiles\\");
            string fileName = "*.txt";
            try
            {
                string[] fi = Directory.GetFiles(filePath, fileName);
                foreach (var file in fi)
                {
                    cmbxCmdScriptList.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //read selected script into lbxConfigScript
        private void cmbxCmdScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxConfigScript.Items.Clear();
            string fileName = cmbxCmdScriptList.SelectedItem.ToString();
            tbShowCommands.Clear();
            showConfigScript(fileName);
        }

        //display config scripts in check list box clear previous selection
        //called by cmbxCmdScriptList_SelectedIndexChanged switch based method
        private void showConfigScript(string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory + "\\ConfigTextFiles\\", fileName);
            if (File.Exists(filePath))
            {
                lbxConfigScript.ClearSelected();
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.StartsWith("show"))
                        tbShowCommands.AppendText(line + "\r\n");
                    else
                        lbxConfigScript.Items.Add(line);
                }
            }
            else
                MessageBox.Show("File does not exist");
        }
        //copies commands to listbox editor
        private void lbxConfigScript_DoubleClick(object sender, EventArgs e)
        {
            rtbxScript.AppendText(lbxConfigScript.SelectedItem.ToString() + "\n");
        }

        //Bottom buttons
        //insert a command between commands at the cursor
        private void btnAppendDisplay_Click(object sender, EventArgs e)
        {
            //add to richtextbox at cursor
            rtbxScript.SelectedText = lbxConfigScript.SelectedItem.ToString();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            //get user input for folder path using explorer
            string title = "Configuration Script";
            FolderBrowserDialog fileBrowse = new FolderBrowserDialog();
            fileBrowse.ShowNewFolderButton = true;
            DialogResult res = fileBrowse.ShowDialog();
            try
            {
                if (res == DialogResult.OK)
                {
                    string filename = string.Format("\\ConfigScript_{0}.txt", DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")); //yyyy-MM-dd HH.mm.ss
                    string folderPath = fileBrowse.SelectedPath;
                    string fullPath = Path.Combine(folderPath + filename);
                    File.WriteAllLines(@fullPath, rtbxScript.Lines);
                    MessageBox.Show(string.Format("Saved as ConfigScript_(dt).txt to {0}", folderPath), title);
                }
                else
                {
                    MessageBox.Show("File not saved", title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            rtbxScript.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllToolStripMenuItem.Text == "Select all")
            {
                rtbxScript.Focus();
                rtbxScript.SelectAll();
            }
        }

        private void selectAllCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllCopyToolStripMenuItem.Text == "Select all copy")
            {
                rtbxScript.Focus();
                rtbxScript.SelectAll();
                rtbxScript.Copy();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copyToolStripMenuItem.Text == "Copy")
            {
                rtbxScript.Copy();
            }
        }
        //open readme.txt or make html page?
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (helpToolStripMenuItem.Text == "Help")
            {

            }
        }

        //could the files be distributed to devices, is it needed?
        private void updownTFTP()
        {
            WebClient client = new WebClient();
            client.UploadFile("upload to path", "path of file");
            client.DownloadFile("download to path", "path of file");
        }
    }
}

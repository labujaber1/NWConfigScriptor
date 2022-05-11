//###########################################//
/// <summary>                                //
/// Project: Network Scriptor Config Creater //
/// Author:  L. Abu-Jaber                    //
/// Date:    09/05/2022                      //
/// Control System: Github                   //
/// </summary>                               //
//###########################################//

using System;
//using System.Diagnostics;
using System.IO;
//using System.Linq;
using System.Net;
using System.Reflection;
//using System.Reflection;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    /// <summary>
    /// ConfigScriptorForm class
    /// </summary>
    public partial class ConfigScriptorForm : Form
    {
        /// <summary>
        /// Initialise ConfigScriptor form and search for text files to display in combo box on startup
        /// </summary>
        public ConfigScriptorForm()
        {
            InitializeComponent();
            searchAddTextFiles();
        }
        /// <summary>
        /// search directory for text files
        /// read into combo box cmbxCmdScriptList include .txt extension
        /// </summary>
        /// <return>returns, in a combo box, a list of all .txt files in debug\configtextfiles folder, 
        /// directory/file not found exception</return>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
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
        
        /// <summary>
        /// read selected script into lbxConfigScript
        /// </summary>
        /// <remarks>used in "searchAddTextFiles" method</remarks>
        private void cmbxCmdScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxConfigScript.Items.Clear();
            string fileName = cmbxCmdScriptList.SelectedItem.ToString();
            tbShowCommands.Clear();
            showConfigScript(fileName);
        }

        /// <summary>
        /// display config scripts in check list box clear previous selection
        /// called by cmbxCmdScriptList_SelectedIndexChanged switch based method
        /// </summary>
        /// <param name="fileName">created in "cmbxCmdScriptList_SelectedIndexChanged" method from user click event 
        /// and passed in to search for</param>
        /// <return>read all lines to a list box from a text file passed in if found, 
        /// file not exist message if not found.</return>
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
        /// <summary>
        /// copies commands to listbox editor
        /// </summary>
        private void lbxConfigScript_DoubleClick(object sender, EventArgs e)
        {
            rtbxScript.AppendText(lbxConfigScript.SelectedItem.ToString() + "\n");
        }


        /// <summary>
        /// insert a command in editor between commands at the cursor
        /// </summary>
        private void btnAppendDisplay_Click(object sender, EventArgs e)
        {
            //add to richtextbox at cursor
            rtbxScript.SelectedText = lbxConfigScript.SelectedItem.ToString();
        }

        /// <summary>
        /// save editor to file with date/time stamp. Browser opens for user to select
        /// save location and message box opens for confirmation.
        /// </summary>
        /// <return>saved to user selected location and file name,
        /// file not saved if user cancels, directory access denied exception, file compilation error</return>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileFormatException"></exception>
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
        /// <summary>
        /// clear all text in editor
        /// </summary>
        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            rtbxScript.Clear();
        }
        /// <summary>
        ///  exit program
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// select all text in editor 
        /// </summary>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllToolStripMenuItem.Text == "Select all")
            {
                rtbxScript.Focus();
                rtbxScript.SelectAll();
            }
        }
        /// <summary>
        ///  select all text in editor and copy to clipboard ready to paste
        /// </summary>
        private void selectAllCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllCopyToolStripMenuItem.Text == "Select all copy")
            {
                rtbxScript.Focus();
                rtbxScript.SelectAll();
                rtbxScript.Copy();
            }
        }
        /// <summary>
        /// copy selected text to clipboard ready to paste
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copyToolStripMenuItem.Text == "Copy")
            {
                rtbxScript.Copy();
            }
        }
        /// <summary>
        ///  open readme.txt or make html page? Create project doc like java
        /// </summary>
        /// <returns>Help file auto generated displayed in browser if found, file not found if not found </returns>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (helpToolStripMenuItem.Text == "Help")
            {
                try
                {
                    string filepath = Path.Combine(Directory.GetCurrentDirectory(), "HelpFile.txt");
                    MessageBox.Show(File.ReadAllText(filepath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message," File error");
                }
            }
        }

        /// <summary>
        /// could the files be distributed to devices, is it needed?
        /// </summary>
        private void updownTFTP()
        {
            WebClient client = new WebClient();
            client.UploadFile("upload to path", "path of file");
            client.DownloadFile("download to path", "path of file");
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}

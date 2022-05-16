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
using System.Net;
using System.Windows.Forms;

namespace NWConfigScriptor
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public partial class ConfigScriptorForm : Form
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
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
        /// <returns>returns, in a combo box, a list of all .txt files in debug\configtextfiles folder, 
        /// directory/file not found exception</returns>
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
        /// <remarks>Used in "searchAddTextFiles" method</remarks>
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
        /// <returns>read all lines to a list box from a text file passed in if found, 
        /// file not exist message if not found.</returns>
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

        private int getQuestionIndex()
        {
            int res = 0;

            return res;
        }
        /// <summary>
        /// copies commands to listbox editor with newline
        /// </summary>
        private void lbxConfigScript_DoubleClick(object sender, EventArgs e)
        {
            string command = lbxConfigScript.SelectedItem.ToString();
            if (command.Contains("?"))
            {
                int icomm = command.IndexOf("?");
                command = command.Remove(icomm);
                rtbxScript.AppendText(command + "\n");
            }
            else
            {
                rtbxScript.AppendText(command + "\n");
            }
        }
       
        /// <summary>
        /// insert a command in editor between commands at the cursor with no newline
        /// </summary>
        private void btnAppendDisplay_Click(object sender, EventArgs e)
        {
            string command = lbxConfigScript.SelectedItem.ToString();
            if (command.Contains("?"))
            {
                int icomm = command.IndexOf("?");
                command = command.Remove(icomm);
                rtbxScript.SelectedText = command;
            }
            else
            {
                rtbxScript.SelectedText = command;
            }
        }
        
        /// <summary>
        /// save editor contents to a text or richtext file in location of users choice.
        /// </summary>
        /// <returns>exception error, if correct then file saved message</returns>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileFormatException"></exception>
        private void saveToTextFile()
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Title = "Save file";
            savef.DefaultExt = "txt";
            savef.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savef.FilterIndex = 1;
            savef.InitialDirectory = @"C:\Documents\";
            savef.ShowDialog();
            savef.RestoreDirectory = true;
            try
            {
                FileInfo fi = new FileInfo(savef.FileName);
                string ext = fi.Extension;
                if(savef.FileName != "" && ext == ".txt")
                {
                    File.WriteAllLines(@savef.FileName, rtbxScript.Lines);
                }
                else
                {
                    MessageBox.Show("File not saved", savef.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, savef.Title);
            }
        }

        /// <summary>
        /// load file contents of txt or rtf to editor to append, adjust, or view
        /// </summary>
        /// <returns>exception error or file loaded successfully message</returns>
        /// <exception cref="FileFormatException"></exception>
        private void loadTextFile()
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.ShowDialog();
            openf.Title = "Load file";
            openf.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openf.FilterIndex = 1;
            openf.DefaultExt = "txt";
            openf.InitialDirectory = @"C:\Documents\";
            openf.RestoreDirectory = true;

            try
            {
                if(openf.FileName != "" && openf.FileName.EndsWith(".txt") )
                {
                    rtbxScript.Text = File.ReadAllText(openf.FileName);
                }
                else if(openf.FileName != "" && !openf.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Incorrect file format only .txt available", openf.Title);
                }
                else
                {
                    MessageBox.Show("File load cancelled", openf.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, openf.Title);
            }
        }

        /// <summary>
        /// save editor to file with date/time stamp. Browser opens for user to select
        /// save location and message box opens for confirmation.
        /// </summary>
        /// <returns>saved to user selected location and file name,
        /// file not saved if user cancels, directory access denied exception, file compilation error</returns>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileFormatException"></exception>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveToTextFile();
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
        /// select and highlight all text in editor 
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
        ///  select and highlight all text in editor and copy to clipboard ready to paste
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

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToTextFile();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTextFile();
        }

        /// <summary>
        /// Appending new commands to a file instead of opening and adding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appendToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openAppend = new OpenFileDialog();
            openAppend.Title = "Appending text to file";
            openAppend.ShowDialog();
            string path = openAppend.FileName;
            if (appendToFileToolStripMenuItem.Text == "Append to file")
            {
                try
                {
                    if (path.EndsWith(".txt"))
                    {
                        File.AppendAllText(path, rtbxScript.Text + "\n");
                        MessageBox.Show("Text added to textfile" + path, openAppend.Title);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect file format, only .txt available");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " File error");
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
        /// <summary>
        /// Display an about form with project details and a brief description
        /// </summary>
        private void lblAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        
    }
}

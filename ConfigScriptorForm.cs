//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  L. Abu-Jaber                    //
// Date:    09/05/2022                      //
// Control System: Github                   //
//                                          //
//##########################################//

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    public partial class ConfigScriptorForm : Form
    {
        /// <summary>
        /// Initialise ConfigScriptor form and search for text files to display in combo box on startup
        /// </summary>
        public ConfigScriptorForm()
        {
            InitializeComponent();
            SearchAddTextFiles();
        }
        private readonly string FilePath_template = Path.Combine(Application.StartupPath + @"ConfigTemplateFiles\");
        private readonly string FilePath_script = Path.Combine(Application.StartupPath + @"ConfigTextFiles\");
        /// <summary>
        /// search directory for text files
        /// read into combo box cmbxCmdScriptList include .txt extension
        /// </summary>
        /// <returns>returns, in a combo box, a list of all .txt files in debug\ConfigTemplateFiles folder, 
        /// directory/file not found exception</returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        private void SearchAddTextFiles()
        {
            //string filePath = Path.Combine(Application.StartupPath+ @"ConfigTemplateFiles\");
            string fileName = "*.txt";
            try
            {
                string[] fit = Directory.GetFiles(FilePath_template, fileName);
                foreach (var file in fit)
                {
                    CmbxCmdScriptList.Items.Add(Path.GetFileName(file));
                }
                string[] fis = Directory.GetFiles(FilePath_script, fileName);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// read selected script into command display
        /// </summary>
        /// <remarks>Used in "searchAddTextFiles" method</remarks>
        private void CmbxCmdScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbxConfigScript.Items.Clear();
            string fileName = CmbxCmdScriptList.SelectedItem.ToString();
            TbShowCommands.Clear();
            ShowConfigScript(fileName);
        }

        /// <summary>
        /// display command file names in check list box, clear previous selection
        /// called by cmbxCmdScriptList_SelectedIndexChanged switch based method
        /// </summary>
        /// <param name="fileName">created in "cmbxCmdScriptList_SelectedIndexChanged" method from user click event 
        /// and passed in to search for</param>
        /// <returns>read all lines to a list box from a text file passed in if found, 
        /// file not exist message if not found.</returns>
        private void ShowConfigScript(string fileName)
        {
            //string filePath = Path.Combine(Application.StartupPath + @"ConfigTemplateFiles\", fileName);
            string filePath1 = Path.Combine(FilePath_template, fileName);
            if (File.Exists(filePath1))
            {
                LbxConfigScript.ClearSelected();
                string[] lines = File.ReadAllLines(filePath1);
                foreach (string line in lines)
                {
                    if (line.StartsWith("show"))
                        TbShowCommands.AppendText(line + "\r\n");
                    else
                        LbxConfigScript.Items.Add(line);
                }
            }
            else
                MessageBox.Show("File does not exist");
        }

        /// <summary>
        /// copies commands to the editor with newline
        /// </summary>
        private void LbxConfigScript_DoubleClick(object sender, EventArgs e)
        {
            string command = LbxConfigScript.SelectedItem.ToString();
            if (command.Contains("?"))
            {
                int icomm = command.IndexOf("?");
                command = command.Remove(icomm);
                RtbxScript.AppendText(command + "\n");
            }
            else
            {
                RtbxScript.AppendText(command + "\n");
            }
        }

        /// <summary>
        /// save editor contents to a text file in location of users choice.
        /// </summary>
        /// <returns>exception error, if correct then file saved message</returns>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileFormatException"></exception>
        private void SaveToTextFile()
        {
            SaveFileDialog savef = new()
            {
                InitialDirectory = @"C:\Documents\",
                Title = "Save to file",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                //RestoreDirectory = true
            };
            try
            {
                savef.ShowDialog();
                FileInfo fi = new(savef.FileName);
                string ext = fi.Extension;
                if(savef.FileName != "" && ext == ".txt")
                {
                    File.WriteAllLines(@savef.FileName, RtbxScript.Lines);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, savef.Title);
                Debug.WriteLine(ex.Message, savef.Title);
            }
        }

        /// <summary>
        /// load file contents of .txt to the editor to append, adjust, or view
        /// </summary>
        /// <returns>exception error or file loaded successfully message</returns>
        /// <exception cref="FileFormatException"></exception>
        private void LoadTextFile()
        {
            OpenFileDialog openf = new()
            {
                InitialDirectory = @"C:\Documents\",
                Title = "Load file",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                DefaultExt = "txt",
                //RestoreDirectory = true
            };
            try
            {
                openf.ShowDialog();
                if (openf.FileName != "" && openf.FileName.EndsWith(".txt") )
                {
                    RtbxScript.Text = File.ReadAllText(openf.FileName);
                }
                if(openf.FileName != "" && !openf.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Incorrect file format only .txt available", openf.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, openf.Title);
            }
        }

        /// <summary>
        /// Add a command text file created by a user to the configtext folder in the application for continued use. 
        /// Becomes available to select from command script list.
        /// </summary>
        private void AddTextFile()
        {
            OpenFileDialog sf = new()
            {
                InitialDirectory = @"C:\Documents\",
                Title = "Add a new file",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                DefaultExt = "txt",
                //RestoreDirectory = true
            };
            sf.ShowDialog();
            string sellectedFilePath = sf.FileName;
            string sellectedFileName = Path.GetFileName(sellectedFilePath);
            //string newFilePath = Path.Combine(Application.StartupPath+ @"ConfigTemplateFiles\", sellectedFileName);
            string newFilePath = Path.Combine(FilePath_template, sellectedFileName);
            try
            {
                if (sf.FileName != "" && (sf.FileName.EndsWith(".txt")))
                {
                    File.Copy(sellectedFilePath, newFilePath,true);
                    MessageBox.Show("New command file "+ sellectedFileName+" added, command script list also updated");
                }
                if (sf.FileName != "" && !sf.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Incorrect file format only .txt available", sf.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, sf.Title);
            }
        }

        /// <summary>
        /// Open file browser and remove file from the application ConfigTemplateFiles folder
        /// </summary>
        private void DeleteFile()
        {
            OpenFileDialog df = new()
            {
                InitialDirectory = FilePath_template,
                Title = "Delete a file",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                DefaultExt = "txt",
                //RestoreDirectory = true
            };
            df.ShowDialog();
            string sellectedFilePath = df.FileName;
            string sellectedFileName = Path.GetFileName(sellectedFilePath);
            try
            {
                if (df.FileName != "" && (df.FileName.EndsWith(".txt")))
                {
                    File.Delete(sellectedFilePath);
                    MessageBox.Show("Command file " + sellectedFileName + " deleted, command script list also updated");
                }
                if (df.FileName != "" && !df.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Incorrect file format only .txt available", df.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, df.Title);
            }
        }

        // ########## BUTTONS ######### //

        

        /// <summary>
        /// save editor contents to a user named file and location for future reference.
        /// </summary>
        /// <returns>saved to user selected location and file name,
        /// file not saved if user cancels, directory access denied exception, file compilation error</returns>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileFormatException"></exception>
        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveToTextFile();
        }

        /// <summary>
        /// clear all the displayed text in the editor to start again
        /// </summary>
        private void BtnClearDisplay_Click(object sender, EventArgs e)
        {
            RtbxScript.Clear();
        }

        /// <summary>
        /// Add command text file to the application and include in the script list 
        /// </summary>
        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            AddTextFile();
            //reload script drop down list to include new file
            CmbxCmdScriptList.Items.Clear();
            SearchAddTextFiles();
        }

        /// <summary>
        /// Delete command file from ConfigTemplateFiles folder and update command dropdown list
        /// </summary>
        private void BtnDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
            //reload script drop down list to include new file
            CmbxCmdScriptList.Items.Clear();
            SearchAddTextFiles();
        }

        /// <summary>
        ///  exit program
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /// <summary>
        /// select and highlight all text in editor ready to copy to the clipboard.
        /// </summary>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllToolStripMenuItem.Text == "Select all")
            {
                RtbxScript.Focus();
                RtbxScript.SelectAll();
            }
        }

        /// <summary>
        ///  select and highlight all text in editor and copy to clipboard ready to paste to a CLI or file.
        /// </summary>
        private void SelectAllCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllCopyToolStripMenuItem.Text == "Select all copy")
            {
                RtbxScript.Focus();
                RtbxScript.SelectAll();
                RtbxScript.Copy();
            }
        }

        /// <summary>
        /// copy selected text to the clipboard ready to paste to a CLI or file.
        /// </summary>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CopyToolStripMenuItem.Text == "Copy")
            {
                RtbxScript.Copy();
            }
        }

        /// <summary>
        ///  open help.txt with directions on program usage.
        /// </summary>
        /// <returns>Help file auto generated displayed in browser if found, file not found if not found </returns>
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HelpToolStripMenuItem.Text == "Help")
            {
                try
                {
                    //string filepath = Path.Combine(Directory.GetCurrentDirectory(), "HelpFile.txt");
                    string filepath = Path.Combine(Application.StartupPath + @"HelpFile.txt");
                    MessageBox.Show(File.ReadAllText(filepath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message," File error");
                }
            }
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToTextFile();
        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTextFile();
        }

        /// <summary>
        /// Appending new commands to a file instead of opening and adding
        /// </summary>
        private void AppendToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openAppend = new();
            openAppend.Title = "Appending text to file";
            openAppend.ShowDialog();
            string path = openAppend.FileName;
            if (AppendToFileToolStripMenuItem.Text == "Append to file")
            {
                try
                {
                    if (path.EndsWith(".txt"))
                    {
                        File.AppendAllText(path, RtbxScript.Text + "\n");
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

        private void UpdateCommandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmbxCmdScriptList.Items.Clear();
            SearchAddTextFiles();
        }

        /// <summary>
        /// Display an about form with project details and a brief description
        /// </summary>
        private void LblAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new();
            about.ShowDialog();
        }

        private static ConfigScriptorForm instance;
        /// <summary>
        /// Open a single module form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>ConfigScriptorForm instance</returns>
        public static ConfigScriptorForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConfigScriptorForm
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        
        //private void updownTFTP()
        //{
        //    WebClient client = new WebClient();
        //    client.UploadFile("upload to path", "path of file");
        //    client.DownloadFile("download to path", "path of file");
        //}


    }
}

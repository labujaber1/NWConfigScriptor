//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  2018481                         //
// Date:    24/04/2023                      //
// Control version: Github                  //
//                                          //
//##########################################//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace NWConfigScriptor
{
    /// <summary>
    /// TFTP transfer GUI form
    /// </summary>
    public partial class VmTftpTransfer : Form
    {
        /// <summary>
        /// Initialise class
        /// </summary>
        public VmTftpTransfer()
        {
            InitializeComponent();
            DisplayTftpConfigFiles();
        }
        private string m_username { get { return Tbx_usernameTFTP.Text; } set { Tbx_usernameTFTP.Text = value; } }
        private string m_password { get { return Tbx_passwordTFTP.Text; } set { Tbx_passwordTFTP.Text = value; } }
        private string m_portnum { get { return Tbx_portNumTFTP.Text; } set { Tbx_portNumTFTP.Text = value; } }
        private string m_secpass { get { return Tbx_secretPassword.Text; } set { Tbx_secretPassword.Text = value; } }
        private string m_targetDeviceIP { get { return Tbx_TargetDeviceIP.Text; } set { Tbx_TargetDeviceIP.Text = value; } }
        private string m_targetServer { get { return Tbx_TargetServerIP.Text; } set { Tbx_TargetServerIP.Text = value; } }
        private string m_fileName { get { return Tbx_FileName.Text; } set { Tbx_FileName.Text = value; } }
        private string m_tftpConfigFiles { get { return Cklbx_TftpConfigFiles.SelectedItem.ToString(); } set { Cklbx_TftpConfigFiles.SelectedItem = value; } }
        private string m_editConfig { get { return Rtbx_EditConfig.Text; } set { Rtbx_EditConfig.Text = value; } }
        private TelnetConnection telconn;
        private List<string> script;
        private readonly string FilePath_configFiles = Path.Combine(Application.StartupPath + @"ConfigFiles\");
        private string m_saveFile;


        //---------------------------------------------------------------------//
        // Description                  | Method name                          //
        //---------------------------------------------------------------------//
        // update comms display         : updateOutputTbbx                     //
        // comms command method         : sendCommandToDevice                  //
        // config from router           : Btn_GetFromRouter_Click              //  
        // display config files         : DisplayTftpConfigFiles               //
        // change folder path display   : Btn_GetFilePath_Click                //
        // select only one config file  : Cklbx_TftpConfigFiles_ItemCheck      //
        // config to router             : Btn_SendToRouter_Click               //
        // change .file to .cfg         : ChangeFilesExtension                 //
        // display config selected file : Btn_EditConfigFile_Click             //
        // save edited config file      : Btn_Save_Click                       //
        // open tftpd64                 : Btn_OpenTftpd64_Click                //
        // exit VmTftpTransfer          : Btn_ExitVmTftpTransfer_Click         //
        //---------------------------------------------------------------------//

        /// <summary>
        /// Replace console print to send message to text box.
        /// </summary>
        /// <param name="message"></param>
        private void _updateOutputTtbx(String message)
        {
            Tbx_OutputDisplay.AppendText(message + Environment.NewLine);

        }

        /// <summary>
        /// Opens a socket and login to a device for transfer of config commands passed in via list.
        /// Used in button events to send and retrieve   config file.
        /// </summary>
        /// <param name="commscript"></param>
        private async void SendCommandToDevice(List<string> commscript)
        {
            try
            {
                _updateOutputTtbx("Initialising new socket please wait..");
                telconn = new TelnetConnection(m_targetDeviceIP, int.Parse(m_portnum));
                _updateOutputTtbx("Initialised socket sussessfully now logging in..");
                string s = telconn.Login(m_username, m_password, 100, m_secpass);
                Debug.Write(s);
                _updateOutputTtbx(s);
                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);

                if (prompt != "$" && prompt != ">" && prompt != "#")
                {
                    _updateOutputTtbx("Connection failed at prompt check");
                    throw new Exception("Connection failed at prompt check");
                }
                prompt = "";
                string temp = "";
                _updateOutputTtbx("Logged in starting command transfer");
                int counter = 0;
                if (telconn.IsConnected)
                {
                    foreach (var command in commscript)
                    {
                        // server output
                        Debug.Write(telconn.Read()); 
                        prompt = Console.ReadLine();
                        // sending command from text file to cli
                        telconn.WriteLine(command); 
                        temp = telconn.Read();
                        Debug.Write(temp);
                        _updateOutputTtbx(temp);
                        counter++;
                    }
                    Debug.Write(telconn.Read());
                    _updateOutputTtbx(telconn.Read());
                    _updateOutputTtbx("Finished transfer\nNumber of lines read = " + counter);
                    Debug.WriteLine("Disconnecting.Number of lines read = " + counter);
                }
                // check file transfered before closing
                DisplayTftpConfigFiles();
                // wait for file to be sent and received
                await Task.Delay(4000);
                temp = telconn.Read();
                _updateOutputTtbx(temp);
                telconn.Dispose();
                _updateOutputTtbx("Disconnected");
            }
            catch (Exception ex)
            {
                _updateOutputTtbx("Exception message: " + ex.Message);
                Debug.WriteLine(ex.ToString());
            }


        }
        /// <summary>
        /// Send commands using telnet to copy selected config file by TFTP to target server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetFromRouter_Click(object sender, EventArgs e)
        {

            // send copy config commands to router via telnet
            // return mes
            // copy tftp://192.168.1.2/router-config running-config
            // copy tftp://<server>/<name of copied file> startup-config
            string comm = "copy running-config tftp:";
            string space = "\r\n";
            script = new List<string>
            {
                comm,
                m_targetServer,
                m_fileName,
                space
            };
            SendCommandToDevice(script);
            DisplayTftpConfigFiles();
        }
                
        // use gns3 startup config file for now to test
        /// <summary>
        /// Display all files in the application 'ConfigFiles' folder to select for Tftp transfer or edit.
        /// </summary>
        public void DisplayTftpConfigFiles()
        {
            
            string fileName = "*.*"; 
            try
            {
                Cklbx_TftpConfigFiles.Items.Clear();
                string[] fi = Directory.GetFiles(FilePath_configFiles, fileName);
                foreach (var file in fi)
                {
                    Cklbx_TftpConfigFiles.Items.Add(Path.GetFileName(file));
                    if (file.Equals(m_fileName)) 
                    { 
                        _updateOutputTtbx("This file exists in the config folder");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open dialog box to select config folder path if default does not return config files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetFilePath_Click(object sender, EventArgs e)
        {
            //if default gns3 install file path not selected by user the config files will not appear in the list.
            //enable user to select path themselves.
            Lbl_FilesNotFoundError.Visible = false;
            FolderBrowserDialog folderSel = new FolderBrowserDialog();
            DialogResult result = folderSel.ShowDialog();
            string filename = "*.*";
            var folderpath = "";
            int count = 0;
            if (result == DialogResult.OK)
            {
                Cklbx_TftpConfigFiles.Items.Clear();
                folderpath = folderSel.SelectedPath;
                Environment.SpecialFolder folder = folderSel.RootFolder; 
            }
            try
            {
                string[] fi = Directory.GetFiles(folderpath, filename);
                foreach (var file in fi)
                {
                    Cklbx_TftpConfigFiles.Items.Add(Path.GetFileName(file));
                    count++;
                }
                if (count == 0)
                    Lbl_FilesNotFoundError.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Show file error");
            }
        }

        /// <summary>
        /// Enable ony one config file to be checked at one time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cklbx_TftpConfigFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // make only one selectable of checked config file.
            for (int ix = 0; ix < Cklbx_TftpConfigFiles.Items.Count; ++ix)
                if (ix != e.Index) Cklbx_TftpConfigFiles.SetItemChecked(ix, false);
        }

        /// <summary>
        /// Send a config file transfer command to a device.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SendToRouter_Click(object sender, EventArgs e)
        {

            // copy tftp://192.168.1.2/router-config running-config
            // copy tftp://<server>/<name of copied file> startup-config
            string enable = "enable";
            string password = m_secpass;
            string comm = "copy tftp://"+m_targetServer+"/"+m_tftpConfigFiles+ " running-config";
            string space = "\r\n";
            script = new List<string>
            {
                enable,
                password,
                comm,
                space
            };
            SendCommandToDevice(script);
            DisplayTftpConfigFiles();
        }

        /// <summary>
        /// search for files that do not have .config extension and rename
        /// </summary>
        private string ChangeFilesExtension(string file)
        {
            var folderPath = FilePath_configFiles;
            var selectedFile = Path.Combine(folderPath, file);
            string fileName = "*.*"; 
            try
            {
                string newFileConfig = "";
                string[] fi = Directory.GetFiles(folderPath, fileName);
                foreach (var fil in fi)
                {
                    if (fil.Equals(selectedFile) && !fil.EndsWith(".cfg"))
                    {
                        string changeFile = Path.Combine(folderPath, fil);
                        newFileConfig = Path.ChangeExtension(changeFile, ".cfg");
                        File.Move(changeFile, newFileConfig);
                        File.Delete(changeFile);
                        _updateOutputTtbx("File extension changed : " + newFileConfig);
                        DisplayTftpConfigFiles();
                        return newFileConfig;
                    }
                }
                return file;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change file extension : ");
                File.Delete(selectedFile);
                DisplayTftpConfigFiles();
                return ex.Message;
            }
        }

        /// <summary>
        /// Get selected config file, open and read content to the editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EditConfigFile_Click(object sender, EventArgs e)
        {
            string file = m_tftpConfigFiles;
            var filo = ChangeFilesExtension(file);
            var filePath = Path.Combine(FilePath_configFiles, filo);
            try
            {
                if (File.Exists(filePath)) 
                {
                    Rtbx_EditConfig.Clear();
                    var fileContent = File.ReadAllText(filePath);
                    m_editConfig = fileContent;
                    m_saveFile = filePath;
                    _updateOutputTtbx("File contents read : " + filePath);
                }
                else
                {
                    Debug.WriteLine("File does not exist");
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Error reading config file to rich text box: " + ex.Message);
                _updateOutputTtbx("Error reading config file to rich text box: " + ex.Message);
            }
        }

        /// <summary>
        /// Save and overwrite the checked config file with displayed config data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(this,"Are you sure you want to save and overwrite the existing configuration file?","Save check", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                // read richtextbox contents to saveFile, overwrite
                // store text var   // text in rich text box
                var configContent = m_editConfig;
                //MessageBox.Show(configContent);
                if (File.Exists(m_saveFile))
                {
                    // save var to selected checklist file
                    File.WriteAllText(m_saveFile, configContent);
                    //MessageBox.Show(File.ReadAllText(m_saveFile), "File saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("File saved successfully");
                }
                else
                {
                    MessageBox.Show("Error saving to file " + m_saveFile + ", check it exists and try again.");
                }
            }
            else 
            {
                MessageBox.Show("Save cancelled"); 
            }
 
        } 

        /// <summary>
        /// Open TFTP64 application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OpenTftpd64_Click(object sender, EventArgs e)
        {
            try
            {
                var opt = MessageBox.Show("Do you need to run as administrator to change settings?", "Open Tftpd64", MessageBoxButtons.YesNoCancel);
                if (opt == DialogResult.Cancel) { return; }
                Process pr = new Process();
                pr.StartInfo.FileName = Application.StartupPath + @"tftpd64.exe";
                if (opt == DialogResult.Yes)
                {
                    pr.StartInfo.UseShellExecute = true;
                    pr.StartInfo.Verb = "runas";
                    pr.Start();
                    Debug.WriteLine("Starting Tftpd64 as administrator");
                }
                else
                {
                    pr.Start();
                    Debug.WriteLine("Starting Tftpd64 without admin rights");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening TFTPD64.exe --> " + ex.Message, "Opening file");
            }
        }

        /// <summary>
        /// Close instance of TftpTransfer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExitVmTftpTransfer_Click(object sender, EventArgs e)
         {
            this.Close();
        }
        
        /// <summary>
        /// Instance using singleton pattern //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private static VmTftpTransfer instance;
        /// <summary>
        /// Open a single module form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>VmTftpTransfer instance</returns>
        public static VmTftpTransfer GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new VmTftpTransfer
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
    }
}

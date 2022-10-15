using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VmTftpTransfer : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public VmTftpTransfer()
        {
            InitializeComponent();
            DisplayTftpConfigFiles();
        }

        // use gns3 startup config file for now to test
        /// <summary>
        /// Display all files in the application 'ConfigScripts' folder to select for Tftp transfer
        /// </summary>
        public void DisplayTftpConfigFiles()
        {
            var folderPath = Path.Combine(Application.StartupPath + @"\\ConfigScripts");
            string fileName = "*.*"; // don't forget to change to *.cfg
            try
            {
                string[] fi = Directory.GetFiles(folderPath, fileName);
                foreach (var file in fi)
                {
                    Cklbx_TftpConfigFiles.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open dialog box to select config file path if default does not return config files.
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
            string filename = "*.cfg";
            var folderpath = "";
            int count = 0;
            if (result == DialogResult.OK)
            {
                Cklbx_TftpConfigFiles.Items.Clear();
                folderpath = folderSel.SelectedPath;
                Environment.SpecialFolder folder = folderSel.RootFolder; //????
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
        /// Test Tftp connection to target device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_TestTftpCon_Click(object sender, EventArgs e)
        {
            //send packet and wait for reply or ping

        }

        /// <summary>
        /// Send selected config file to target device via Tftp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SendTftp_Click(object sender, EventArgs e)
        {
            //use nuget packet I'm sure I've seen one
            //may need to identify packet tracer or gns3 or something
            var TargetIPAdd = TargetDeviceIP;
            var TargetDevGateway = TargetGateway;
            var TargetNW = TargetNWIP; //dont need variables as now included at bottom, may need to refornmat for ip address


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
                Process pr = new();
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

        private string TargetDeviceIP { get { return Tbx_TargetDeviceIP.Text; } set { Tbx_TargetDeviceIP.Text = value; } }
        private string TargetGateway { get { return Tbx_TargetDeviceGateway.Text; } set { Tbx_TargetDeviceGateway.Text = value; } }
        private string TargetNWIP { get { return Tbx_TargetNetworkIP.Text; } set { Tbx_TargetNetworkIP.Text = value; } }

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

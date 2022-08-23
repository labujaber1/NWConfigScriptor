using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    public partial class VmTftpTransfer : Form
    {
        public VmTftpTransfer()
        {
            InitializeComponent();
        }



       
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

        private void Btn_ExitVmTftpTransfer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

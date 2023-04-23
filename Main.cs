//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  2018481                         //
// Date:    24/04/2023                      //
// Control version: Github                  //
//                                          //
//##########################################//

using System;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly Main main;
        /// <summary>
        /// Main menu form for configscriptor
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open configscriptorform to create scripts and copy/paste to emulators such as Packet Tracer.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CreateScript_Click(object sender, EventArgs e)
        {
            ConfigScriptorForm cf = ConfigScriptorForm.GetInstance(main);
            cf.MdiParent = this;
            cf.Show();
           
        }

        /// <summary>
        /// Open form to replace network device config scripts within Gns3 simulator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Telnet_Click(object sender, EventArgs e)
        {
            //AddToGns3Form gns3 = AddToGns3Form.GetInstance(main);
            //gns3.MdiParent = this;
            //gns3.Show();

            TelnetToDevice telnet = TelnetToDevice.GetInstance(main);
            telnet.MdiParent = this;
            telnet.Show();

        }

        /// <summary>
        /// Open form to transfer scripts via Tftp within a VM enviroment such as Virtual box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_VmTftpTrans_Click(object sender, EventArgs e)
        {
            VmTftpTransfer tftp = VmTftpTransfer.GetInstance(main);
            tftp.MdiParent = this;
            tftp.Show();

        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}

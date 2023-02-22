//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  L. Abu-Jaber                    //
// Date:    09/05/2022                      //
// Control System: Github                   //
//                                          //
//##########################################//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NWConfigScriptor
{
    public partial class TelnetToDevice : Form
    {
        // asynchronous program (one at a time)
        // select NIC? user may not always use vmnet1
        // get telnet connection to device ip address (10.10.10.5), port number (23) and using passowrd
        // return results to rich text box
        // allow for line drop possible retry connection 2 times
        // select file and read to connection line by line
        // confirm each line? 
        // close clean connection
        private TelnetConnection telconn;
        
        private String m_nic;
        private String m_username;
        private String m_ipaddress;
        private String m_password;
        private String m_portNum;
        private String m_file;

        private String Nic() { m_nic = (string)Cmbx_AdaptorChoice.SelectedItem; return m_nic; }
        private String Username() { m_username = Tbx_Username.Text; return m_username; }
        private String Ipaddress() { m_ipaddress = Tbx_IPAddress.Text; return m_ipaddress; }
        private String Password() { m_password = Tbx_Password.Text; return m_password; }
        private String PortNum() { m_portNum = Tbx_PortNum.Text; return m_portNum; }
        private String CommFile() { m_file = Tbx_CommandFileDisplay.Text; return m_file; }
        
        public TelnetToDevice()
        {
            InitializeComponent();
            //ListNICs();
            
        }

        private void TelnetToDevice_Load(object sender, EventArgs e)
        {
            ListNICs();
        }
 
        public void ReadTextFile()
        {
            try
            {
                UpdateTtbx("Initialising new socket please wait may take some time..");
                telconn = new TelnetConnection(Ipaddress(), int.Parse(PortNum()));
                UpdateTtbx("Initialised socket sussessfully now logging in..");
                string s = telconn.Login(Username(), Password(), 100);
                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);

                if (prompt != "$" && prompt != ">")
                {
                    UpdateTtbx("Connection failed at prompt check");
                    throw new Exception("Connection failed at prompt check");
                }
                prompt = "";
                UpdateTtbx("Logged in starting command transfer");
                int counter = 0;
                foreach (string line in File.ReadLines(CommFile()))
                {

                    prompt = Console.ReadLine();
                    telconn.WriteLine(line);
                    Debug.WriteLine(line);
                    UpdateTtbx(line);
                    counter++;
                        
                }
                telconn.Dispose();
                UpdateTtbx("Finished transfer, disconnecting");
                UpdateTtbx("Number of lines read = " + counter);
                Debug.WriteLine("Disconnected. Number of lines read = " + counter);
            }
            catch (Exception ex)
            {
                UpdateTtbx("Exception message: "+ex.Message);
                Debug.WriteLine(ex.ToString());
            }
            //telconn.TelnetCheck(m_ipaddress, m_portNum);
            
        }

        /// <summary>
        /// List NICs on local pc
        /// </summary>
        private void ListNICs()
        { 
            List<string> AdapterList = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                AdapterList.Add(nic.Name);
            }
            foreach (var s in AdapterList)
            {
                Cmbx_AdaptorChoice.Items.Add(s);
                
            }
        }
        /// <summary>
        /// Check if fields have not all been filled in and make visible hash next to empty field.
        /// </summary>
        /// <returns></returns>
        private Boolean IsEmptyFields()
        {
            HashInvisible();
            if (Nic() == "" || Nic() == null) 
            {
                label5.Visible = true; 
                return false; 
            }
            if (Username() == "")
            {
                label3.Visible = true;
                return false;
            }
            if (Ipaddress() == "") 
            { 
                label6.Visible = true; 
                return false; 
            }
            if (PortNum() == "") 
            { 
                label7.Visible = true; 
                return false; 
            }
            if (Password() == "") 
            { 
                label8.Visible = true; 
                return false; 
            }
            if (CommFile() == "") 
            { 
                label9.Visible = true; 
                return false; 
            }
            else
            {
                return true;
            }
                
        }
        
        public void HashInvisible() 
        {
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
        }
        /// <summary>
        /// Clear all input fields.
        /// </summary>
        private void ClearFields()
        {
            Tbx_Username.Clear();
            Tbx_IPAddress.Clear();
            Tbx_PortNum.Clear();
            Tbx_Password.Clear();
            Tbx_CommandFileDisplay.Clear();
            Tbx_CommsDisplay.Clear();
            HashInvisible();


        }

        private void UpdateTtbx(String message)
        {
            Tbx_CommsDisplay.AppendText(message + Environment.NewLine);
            
        }

        // ######### BUTTONS #########
        /// <summary>
        /// Select text file for reading to device via telnet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CommandFileChooser_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SafeFileName))
                {
                    Tbx_CommandFileDisplay.Text = fbd.FileName;
                }
            }
        }

        /// <summary>
        /// Check all fields filled, get telnet connection and read file to device.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SendTelnet_Click(object sender, EventArgs e)
        {
            Tbx_CommsDisplay.Clear();
            UpdateTtbx("Starting comms");
            UpdateTtbx("Checking connection..");
            if (IsEmptyFields() != false)
            {
                UpdateTtbx("All fields filled");
                Debug.WriteLine("All fields filled");
                // call connection and read method
                //TelnetCheck(Ipaddress(),PortNum());
                ReadTextFile();
            }
            else
            {
                label11.Visible = true;
            }
            
        }

        /// <summary>
        /// Clear all fields of input data using isEmptyFields method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Close instance of this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExitTelnetPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  #####################################################

        private static TelnetToDevice instance;
        /// <summary>
        /// Singleton instance of this form
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns></returns>
        public static TelnetToDevice GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TelnetToDevice
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

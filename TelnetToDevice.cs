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
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NWConfigScriptor
{
    /// <summary>
    /// Creates a form for telnet connection to read and write text from a device. 
    /// </summary>
    public partial class TelnetToDevice : Form
    {
        private TelnetConnection telconn;
        private string m_nic;
        private string m_username;
        private string m_ipaddress;
        private string m_password;
        private string m_portNum;
        private string m_file;
        private string m_seretPassword;

        private string Nic() { m_nic = (string)Cmbx_AdaptorChoice.SelectedItem; return m_nic; }
        private string Username() { m_username = Tbx_Username.Text; return m_username; }
        private string Ipaddress() { m_ipaddress = Tbx_IPAddress.Text; return m_ipaddress; }
        private string Password() { m_password = Tbx_Password.Text; return m_password; }
        private string PortNum() { m_portNum = Tbx_PortNum.Text; return m_portNum; }
        private string SecretPassword() { m_seretPassword = Tbx_secretPassword.Text; return m_seretPassword; }
        private string CommFile() { m_file = Tbx_CommandFileDisplay.Text; return m_file; }
        
        /// <summary>
        /// Initialise form.
        /// </summary>
        public TelnetToDevice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls method to display all local interfaces in combo box to select on form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TelnetToDevice_Load(object sender, EventArgs e)
        {
            ListNICs();
        }

        /// <summary>
        /// On connection login and read text file commands to device's CLI. 
        /// Uses TelnetInterface to read and write to device via telnet connection.
        /// Passes CLI output to text area for user information and progress status.
        /// Will show incorrect commands in list for user to correct for next connection.
        /// </summary>
        public void ReadTextFile()
        {
            try
            {
                UpdateTtbx("Initialising new socket please wait..");
                telconn = new TelnetConnection(Ipaddress(), int.Parse(PortNum()));
                UpdateTtbx("Initialised socket sussessfully now logging in..");
                string s = telconn.Login(Username(), Password(), 100, SecretPassword());
                //Debug.Write(s);
                UpdateTtbx(s);
                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);

                if (prompt != "$" && prompt != ">" && prompt != "#")
                {
                    UpdateTtbx("Connection failed at prompt check");
                    throw new Exception("Connection failed at prompt check");
                }
                prompt = "";
                string temp = "";
                UpdateTtbx("Logged in starting command transfer");
                int counter = 0;
                if (telconn.IsConnected)
                {
                    foreach (string line in File.ReadLines(CommFile()))
                    {
                        prompt = Console.ReadLine();
                        // sending command from text file to device cli
                        telconn.WriteLine(line);
                        temp = telconn.Read();
                        // reading device cli to edi output
                        Debug.Write(temp);
                        // reading device cli to text area
                        UpdateTtbx(temp);               
                        counter++;
                    }
                    //telconn.Dispose();
                    UpdateTtbx("Finished transfer, disconnecting");
                    UpdateTtbx("Number of lines read = " + counter);

                    Debug.WriteLine("Disconnected. Number of lines read = " + counter);
                    
                }
                telconn.Dispose();
            }
            catch (Exception ex)
            {
                UpdateTtbx("Exception message: "+ex.Message);
                Debug.WriteLine(ex.ToString());
            }
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
        
        /// <summary>
        /// Resets all unfilled text box fields warning to invisible.
        /// </summary>
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

        /// <summary>
        /// Writes string message to text area instead of to console.
        /// </summary>
        /// <param name="message"></param>
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

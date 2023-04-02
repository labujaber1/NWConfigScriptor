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
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NWConfigScriptor
{
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
        
        /*
        private String m_nic { get { return Cmbx_AdaptorChoice.SelectedItem.ToString(); } }
        private String m_username { get { return Tbx_Username.Text; } } //set { Tbx_Username.Text = value; }
        private String m_ipaddress { get { return Tbx_IPAddress.Text; } } //set { Tbx_IPAddress.Text = value; }
        private String m_password { get { return Tbx_Password.Text; } } //set { Tbx_Password.Text = value; }
        private String m_portNum { get { return Tbx_PortNum.Text; } } //set { Tbx_PortNum.Text = value; }
        private String m_commFile { get { return Tbx_CommandFileDisplay.Text; } } //set { Tbx_CommandFileDisplay.Text = value; }
        */
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
                UpdateTtbx("Initialising new socket please wait..");
                telconn = new TelnetConnection(Ipaddress(), int.Parse(PortNum()));
                UpdateTtbx("Initialised socket sussessfully now logging in..");
                string s = telconn.Login(Username(), Password(), 100, SecretPassword());
                Debug.Write(s);
                UpdateTtbx(s);
                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);

                if (prompt != "$" && prompt != ">" && prompt != "#")
                {
                    UpdateTtbx("Connection failed at prompt check");
                    throw new Exception("Connection failed at prompt check");
                }
                prompt = "";
                UpdateTtbx("Logged in starting command transfer");
                int counter = 0;
                if (telconn.IsConnected)
                {
                    foreach (string line in File.ReadLines(CommFile()))
                    {
                        //Debug.Write(telconn.Read());  // server output
                        
                        prompt = Console.ReadLine();
                        telconn.WriteLine(line);        // sending command from text file to device cli
                        Debug.Write(telconn.Read());    // reading device cli to edi output
                        UpdateTtbx(line);               // view line from file in app
                        //UpdateTtbx(telconn.Read());     
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

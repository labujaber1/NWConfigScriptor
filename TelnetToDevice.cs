using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
        // get telnet connection to device ip address (10.10.10.5), port number (23) and using passowrd (not active yet)
        // return results to rich text box
        // allow for line drop possible retry connection 2 times
        // select file and read to connection line by line
        // confirm each line? 
        // close clean connection

        

        public TelnetToDevice()
        {
            InitializeComponent();
            //ListNICs();
        }

        private String m_nic, m_ipaddress, m_password, m_port, m_file;

        public String nic() { m_nic = Cmbx_AdaptorChoice.SelectedItem.ToString(); return m_nic; }
        public String ipaddress() { m_ipaddress = Tbx_IPAddress.Text; return m_ipaddress; }
        public String password() { m_password = Tbx_Password.Text; return m_password; }
        public String portNum() {m_port = Tbx_PortNum.Text; return m_port; }
        public String file() { m_file = Tbx_PortNum.Text.ToString(); return m_file; }

        private void TelnetToDevice_Load(object sender, EventArgs e)
        {
            ListNICs();
        }

        private Socket clientSocket;
        private IPAddress hostAddress;
        //h ttp://www.ultradevelopers.net/en-us/blog/how-to-telnet-a-remote-service-using-c-12 
        /// <summary>
        /// Create ip and port sockets from data in input fields.
        /// </summary>
        public void TelnetCheck()
        {
            try
            {
                if (string.IsNullOrEmpty(Tbx_IPAddress.Text))
                    return;

                if (string.IsNullOrEmpty(Tbx_PortNum.Text))
                    return;

                int port;
                hostAddress = Dns.GetHostEntry(Tbx_IPAddress.Text).AddressList[0];
                int.TryParse(Tbx_PortNum.Text, out port);

                if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                else if (hostAddress.AddressFamily == AddressFamily.InterNetworkV6)
                    clientSocket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);

                SocketAsyncEventArgs telnetSocketAsyncEventArgs = new SocketAsyncEventArgs();
                telnetSocketAsyncEventArgs.RemoteEndPoint = new IPEndPoint(hostAddress, port);
                telnetSocketAsyncEventArgs.Completed += new
                    EventHandler<SocketAsyncEventArgs>(telnetSocketAsyncEventArgs_Completed);

                clientSocket.ConnectAsync(telnetSocketAsyncEventArgs);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Service Is not Running",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        // h ttp://www.ultradevelopers.net/en-us/blog/how-to-telnet-a-remote-service-using-c-12 
        /// <summary>
        /// Confirm socket running or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void telnetSocketAsyncEventArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            try
            {
                if (e.SocketError == SocketError.Success)
                {
                    if (e.LastOperation == SocketAsyncOperation.Connect)
                    {
                        MessageBox.Show("Service Is Running", hostAddress.ToString(),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Service Is not Running", e.SocketError.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Service Is not Running",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void readTextFile()
        {
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines(Tbx_CommandFileDisplay.Text))
            {
                Debug.WriteLine(line);
                counter++;
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
        private Boolean isEmptyFields()
        {
            if (Cmbx_AdaptorChoice.Text == "") { label5.Visible = true; return false; }
            if (Tbx_IPAddress.Text == "") { label6.Visible = true; return false; }
            if (Tbx_PortNum.Text == "") { label7.Visible = true; return false; }
            if (password() == "") { label8.Visible = true; return false; }
            if (Tbx_CommandFileDisplay.Text == "") { label9.Visible = true; return false; }
            return true;
        }
        
        /// <summary>
        /// Clear all input fields.
        /// </summary>
        private void clearFields()
        {
            
            Tbx_IPAddress.Clear();
            Tbx_PortNum.Clear();
            Tbx_Password.Clear();
            Tbx_CommandFileDisplay.Clear();
            Rtbx_ViewComms.Clear();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
           
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
            //if (isEmptyFields() != false)
            //{
            //    Debug.WriteLine("All fields filled");
            //    // call connection and read method
            //    TelnetCheck();
            //}
            //else
            //{
            //    label11.Visible = true;
            //}
            readTextFile();
        }

        /// <summary>
        /// Clear all fields of input data using isEmptyFields method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
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

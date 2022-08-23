using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AddToGns3Form : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public AddToGns3Form()
        {
            InitializeComponent();
            DisplayConfigScripts();
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

        }

        /// <summary>
        /// Display all files in the application 'ConfigScripts' folder to select and replace Gns3 device config file.
        /// </summary>
        public void DisplayConfigScripts()
        {
            var folderPath = Path.Combine(Application.StartupPath + @"\\ConfigScripts");
            var Gns3Path = ProjectPath();
            string fileName = "*.*";
            try
            {
                string[] fi = Directory.GetFiles(folderPath, fileName);
                foreach (var filei in fi)
                {
                    Cklbx_ScriptList.Items.Add(Path.GetFileName(filei));
                }
                Tbx_UserPath.Text = Gns3Path;
                string[] fo = Directory.GetFiles(Gns3Path, fileName);
                foreach (var fileo in fo)
                {
                    Cklbx_Gns3Configs.Items.Add(Path.GetFileName(fileo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ProjectPath()
        {
            
            var PLACEHOLDER = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var cpath = $"{PLACEHOLDER}\\Gns3\\Configs\\";

            if (cpath != null)
            {
               //MessageBox.Show(cpath);
                return cpath;
            }
            else
                return "no path";
        }

        private void Btn_ExitGns3Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //################################################################

        private static AddToGns3Form instance;
        /// <summary>
        /// Open a single module form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>AddToGns3Form instance</returns>
        public static AddToGns3Form GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddToGns3Form
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

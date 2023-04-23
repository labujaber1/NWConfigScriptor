using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace NWConfigScriptor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddToGns3Form : Form
    {
        /// <summary>
        /// Initialises Gns3 form and calls 'DisplayConfigScripts()' to display lists in checkbox lists on load.
        /// </summary>
        public AddToGns3Form()
        {
            InitializeComponent();
            DisplayConfigTextScripts();
            ProjectPath();
        }

        /// <summary>
        /// Return local user profile path combined with Gns3 project path. 
        /// Set as default folder on start-up. 
        /// </summary>
        /// <returns>User profile path</returns>
        private void ProjectPath()
        {
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var cpath = $"{userPath}\\Gns3\\Projects\\";
            if (cpath != null)
                Tbx_UserPath.Text = cpath;
            else
                Tbx_UserPath.Text = "no path found";
            DisplayProjects();
        }

        /// <summary>
        /// Display all files in the application 'ConfigScripts' folder and 
        /// saved Gns3 projects to select and replace Gns3 device config file.
        /// </summary>
        private void DisplayConfigTextScripts()
        {
            var folderPath = Path.Combine(Application.StartupPath + @"ConfigScripts");
            string fileName = "*.*";
            try
            {
                string[] fi = Directory.GetFiles(folderPath, fileName);
                foreach (var file in fi)
                {
                    Cklbx_ScriptList.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayProjects()
        {
            var Gns3Path = Tbx_UserPath.Text.ToString();
            string[] fo = Directory.GetDirectories(Gns3Path);
            foreach (var dir in fo)
            {
                Cklbx_Gns3Projects.Items.Add(Path.GetFullPath(dir));
            }
        }
        
        /// <summary>
        /// Select different app/project path than default Gns3 installed path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SelectAppPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSel = new FolderBrowserDialog();
            DialogResult result = folderSel.ShowDialog();
            var folderpath = "";
            if (result == DialogResult.OK)
            {
                ClearAll();
                folderpath = folderSel.SelectedPath;
                Tbx_UserPath.Text = folderpath;
                Debug.WriteLine(folderpath);
            }
            DisplayProjects();
        }

        /// <summary>
        /// Clear all checklist boxes of items to be refilled with new list
        /// </summary>
        private void ClearAll()
        {
            Cklbx_Gns3Projects.Items.Clear();
            Cklbx_ProjectDevices.Items.Clear();
        }

        //h ttps://grabthiscode.com/csharp/c-winforms-select-folder-dialogue
        /// <summary>
        /// Select config scripts from another folder. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OtherConfigFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string fileName2 = "*.txt";
                    string[] files = Directory.GetFiles(fbd.SelectedPath,fileName2);
                    Cklbx_ScriptList.Items.Clear();
                    foreach (var file in files)
                    {
                        Cklbx_ScriptList.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        /// <summary>
        /// Convert selected text file to working config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ConvertTxtToConfig_Click(object sender, EventArgs e)  // TO DO
        {
            //put the text file selected through a converter to construct config to replace existing startup-config

        }


        /// <summary>
        /// Search and display all routers in Cklbx_ProjectDevices for selected project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cklbx_Gns3Projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cklbx_ProjectDevices.Items.Clear();
            var project = Cklbx_Gns3Projects.SelectedItem.ToString();
            var configFileName = "*.cfg";
            //search through all remaining subdirectories for .cfg files.
            //About 5 deep from selected path, each device has seperate folder.
            string[] fi = Directory.GetFiles(project, configFileName,SearchOption.AllDirectories);
            foreach (var file in fi)
            {
                
                Cklbx_ProjectDevices.Items.Add(Path.GetFileName(file));
            }
        }

        /// <summary>
        /// Append text file to selected router start-up config file. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Append_Click(object sender, EventArgs e)  // TO DO
        {
            // 
            // call append method to add text file contents to an existing config file

        }
        /// <summary>
        /// Replace the selected routers' start-up config file with the text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ReplaceConfig_Click(object sender, EventArgs e)    // TO DO
        {
            // change currently displayed list to project routers.
            // call replace method to convert text file to config file and replace 
        }
                

        /// <summary>
        /// Close instance of Gns3form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExitGns3Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ################################################################

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

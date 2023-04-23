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
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}

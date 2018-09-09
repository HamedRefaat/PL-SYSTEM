using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PLSystems
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <include file='Base.cs' path='[@name="IsWFF"]'/>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm1());
        }
    }
}

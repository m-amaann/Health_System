using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System
{
    internal static class Program
    {
        static string username = ""; 
        static string role = "";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());


            //in here, i have provid the check user logged In
            bool isLoggedIn = CheckUserLoggedIn();

            if (isLoggedIn)
            {
                // User already logged in, show dashboard 
                Application.Run(new Main(username, role));
            }
            else
            {
                // User is not logged in, show login form
                Application.Run(new Login());
            }
        }

        static bool CheckUserLoggedIn()
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(role);
        }
    }
}

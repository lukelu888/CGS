using CGS_Windows_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            //Application.Run(new loginSql());
            //Application.Run(new Login());
            //Application.Run(new CuratorSql());
            // Application.Run(new ArtistSql());
            //Application.Run(new ArtPieceSql());
            //Application.Run(new MainForm());
            // Application.Run(new sellForm());
             Application.Run(new SellFormSql());
        }
    }
}

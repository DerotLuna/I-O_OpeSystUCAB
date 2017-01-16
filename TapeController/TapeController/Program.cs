using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TapeController
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string project_Route = Path.Combine(Application.StartupPath, ""); /* Absorbe el ruta del proyecto */
            string route = project_Route.Replace("bin\\Debug", "Data");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TapeController(route));
        }
    }
}

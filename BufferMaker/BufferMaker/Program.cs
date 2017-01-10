using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferMaker
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
            string route = project_Route.Replace("BufferMaker\\BufferMaker\\bin\\Debug", "");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BufferMaker(route));
        }
    }
}

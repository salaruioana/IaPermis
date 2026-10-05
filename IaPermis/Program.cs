/*************************************************************************
* Fișier:          Program.cs
* Autor:           Șalaru Ioana
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Punctul principal de pornire al aplicației.
*                  Inițializează interfața grafică și deschide FormMain.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IaPermis
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
            Application.Run(new FormMain());
        }
    }
}

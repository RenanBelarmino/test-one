using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace fluxodecaixa
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var db = new DatabaseContexto())
            {
                db.Database.Migrate();
            }

            Application.Run(new FormLogin());
        }
    }
}

using ButterFly;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterFly
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbPath = Path.Combine(Application.StartupPath, "databasefile.db");
            if (!File.Exists(dbPath))
            {
                new DB($"Data Source={dbPath};Version=3;").InitializeDatabase();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}

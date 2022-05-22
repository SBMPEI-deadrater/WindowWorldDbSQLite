using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Views;
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingsDatabase settingsDb = new SettingsDatabase();
         
            using (_ContextDb db = new _ContextDb(settingsDb.GetDbContextOptions()))
            {
                DBInit dBIni = new DBInit(db);
                dBIni.DefaultGeneration();
            }

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new authForm());
        }
    }
}
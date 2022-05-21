using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Views;

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
            using (_ContextDb db = new _ContextDb())
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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Services.Interfaces;

namespace WindowWorldDbSQLite.Services
{
    internal class SettingsDatabase : ISettingsDatabase
    {
        // Объект настройки БД
        public DbContextOptions<_ContextDb> GetDbContextOptions()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("Config\\appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<_ContextDb>();
            var options = optionsBuilder.UseSqlite(connectionString).Options;
            return options;
        }

        public bool BackupSQLiteDbToDesktop(string _path)
        {
            throw new NotImplementedException();
        }

        // Объект настройки БД
        //public string GetDbConnectionString()
        //{
        //    var builder = new ConfigurationBuilder();
        //    // установка пути к текущему каталогу
        //    builder.SetBasePath(Directory.GetCurrentDirectory());
        //    // получаем конфигурацию из файла appsettings.json
        //    builder.AddJsonFile("appsettings.json");
        //    // создаем конфигурацию
        //    var config = builder.Build();
        //    // получаем строку подключения
        //    string connectionString = config.GetConnectionString("DefaultConnection");

        //    return connectionString;
        //}

        public void Dispose()
        {
        }
    }
}

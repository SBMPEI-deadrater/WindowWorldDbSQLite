using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindowWorldDbSQLite.Database.Models;

namespace WindowWorldDbSQLite.Database
{
    public class _ContextDb: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<OrderedService> OrderedServices { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Service> Services { get; set; }

        public _ContextDb(DbContextOptions<_ContextDb> options) : base(options)
        {
            //Проверка существования БД
            try
            {
                Database.EnsureCreated();
            }
            catch
            {
                //MessageBox.Show("Похоже что-то пошло не так.\nПроверьте базу данных.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw new Exception("ХЕРНЯ С БД! ШОТА С ПУТЕМ!");
                //Environment.Exit(0);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Уникализация поля UserName
            modelBuilder.Entity<User>().HasAlternateKey(u => u.UserName);
        }
    }
}

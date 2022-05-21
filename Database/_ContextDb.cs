﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public _ContextDb()
        {
            //Проверка существования БД
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQLite
            optionsBuilder.UseSqlite("Data Source=sqlite_window_world.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Уникализация поля UserName
            modelBuilder.Entity<User>().HasAlternateKey(u => u.UserName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite.Database
{
    public interface IDBInit
    {
        void DefaultGeneration();
    }
    public class DBInit : IDBInit
    {
        private readonly _ContextDb _context;

        public DBInit(_ContextDb context)
        {
            _context = context;
        }

        public void DefaultGeneration()
        {
            if (!_context.Users.Any())
            {
                var items = new User[]
                {
                    new User
                    {
                        Id=1,
                        UserName = "admin",
                        Password = "admin",
                        Role = "admin",
                    },
                    new User
                    {
                        Id=2,
                        UserName = "user",
                        Password = "user",
                        Role = "user",
                    }
                };

                _context.Users.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Goods.Any())
            {
                var items = new Good[]
                {
                    new Good
                    {
                        Id = 1,
                        Name = "Окно 2-хстворчатое BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Окно",
                        Price = 9599.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 2,
                        Name = "Окно 3-хстворчатое BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Окно",
                        Price = 13499.50M,
                        PhotoUrl = "https://st14.stblizko.ru/images/product/242/110/416_large.jpg",
                        IsActive = false,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 3,
                        Name = "Балконный блок BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Балконный блок",
                        Price = 16399.50M,
                        PhotoUrl = "https://izhevsk.ru/forums/icons/forum_pictures/asyncupload/188778/2017/6/27/1498548967U188778TUeA3595106026_orig.jpg",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 4,
                        Name = "Окно 2-хстворчатое GRAZIO",
                        Company = "GRAZIO",
                        TypeGood = "Окно",
                        Price = 14899.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 5,
                        Name = "Окно 3-хстворчатое GRAZIO",
                        Company = "GRAZIO",
                        TypeGood = "Окно",
                        Price = 20999.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 6,
                        Name = "Балконный блок GRAZIO",
                        Company = "GRAZIO",
                        TypeGood = "Окно",
                        Price = 24299.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = false,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 7,
                        Name = "Окно 2-хстворчатое DELIGHTE",
                        Company = "DELIGHTE",
                        TypeGood = "Окно",
                        Price = 15299.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = false,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 8,
                        Name = "Окно 3-хстворчатое DELIGHTE",
                        Company = "DELIGHTE",
                        TypeGood = "Окно",
                        Price = 21399.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 9,
                        Name = "Балконный блок DELIGHTE",
                        Company = "DELIGHTE",
                        TypeGood = "Балконный блок",
                        Price = 30499.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 10,
                        Name = "Пластиковая дверь с полным остеклением без перегородки BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Дверь балконная",
                        Price = 7799.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 11,
                        Name = "Пластиковая дверь с полным остеклением c перегородкой BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Дверь балконная",
                        Price = 8999.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 12,
                        Name = "Пластиковая дверь с сэндвич-панелью и стеклопакетом BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Дверь балконная",
                        Price = 7499.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = false,
                        Progress = false
                    },
                    new Good
                    {
                        Id = 13,
                        Name = "Пластиковая дверь без остекления с перегородкой BLITZ",
                        Company = "BLITZ",
                        TypeGood = "Дверь балконная",
                        Price = 7499.50M,
                        PhotoUrl = "https://orel.tzskokna.ru/upload/iblock/714/7149d3a12d4e9cc425ab6c9688fab273.png",
                        IsActive = true,
                        Progress = false
                    }
                };
                _context.Goods.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Services.Any())
            {
                var items = new Service[]
                {
                    new Service
                    {
                        Id = 1,
                        TypeService = "",
                        Price = 1M,
                        Progress = true
                    },
                };

                _context.Services.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Customers.Any())
            {
                var items = new Customer[]
                {
                    new Customer
                    {
                        Id = 1,
                        LastName = "",
                        FirstName = "",
                        MiddleName = "",
                        Adress = "",
                        PhoneNumber = "+7(999)999-99-99"
                    }
                };

                _context.Customers.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Orders.Any())
            {
                var items = new Orders[]
                {
                    new Orders
                    {
                        Id = 1,
                        GoodId = 1,
                        DateOrder = new DateTime(2022, 05, 22),
                        CustomerId = 1,
                        ProvisionalReleaseDate = new DateTime(2022, 05, 22),
                        ReleaseDate = new DateTime(2022, 05, 22),
                        OrderPrice = 1M,
                        IsPayed = true,
                        OrderProgress = true
                    },
                };

                _context.Orders.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.OrderedServices.Any())
            {
                var items = new OrderedService[]
                {
                    new OrderedService
                    {
                        Id =1,
                        ServiceId = 1,
                        OrderedDate = new DateTime(2022, 05, 22),
                        CustomerId = 1,
                        ProvisionalReleaseDate = new DateTime(2022, 05, 22),
                        ReleaseDate = new DateTime(2022, 05, 22),
                        Price = 1M,
                        IsPayed = true,
                        Progress = true
                    },
                };

                _context.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}

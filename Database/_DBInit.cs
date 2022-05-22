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
                        TypeService = "Установка окна",
                        Price = 3999.50M,
                        Progress = false
                    },
                    new Service
                    {
                        Id = 2,
                        TypeService = "Установка двери",
                        Price = 1999.50M,
                        Progress = false
                    },
                    new Service
                    {
                        Id = 3,
                        TypeService = "Остекление балкона",
                        Price = 7999.50M,
                        Progress = false
                    },
                    new Service
                    {
                        Id = 4,
                        TypeService = "Замер",
                        Price = 499.50M,
                        Progress = false
                    },
                    new Service
                    {
                        Id = 5,
                        TypeService = "Доставка по городу",
                        Price = 999.50M,
                        Progress = false
                    }
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
                        LastName = "Ветров",
                        FirstName = "Дмитрий",
                        MiddleName = "Александрович",
                        Adress = "Смоленск, ул. Чехова, 71",
                        PhoneNumber = "+7 (900) 111-11-11"
                    },
                    new Customer
                    {
                        Id = 2,
                        LastName = "Воротилова",
                        FirstName = "Маргарита",
                        MiddleName = "Юрьевна",
                        Adress = "Смоленск, ул. Жюля Верна, 59",
                        PhoneNumber = "+7 (900) 222-22-22"
                    },
                    new Customer
                    {
                        Id = 3,
                        LastName = "Дружинина",
                        FirstName = "Валерия",
                        MiddleName = "Андреевна",
                        Adress = "Смоленск, шоссе Достоевского, 72",
                        PhoneNumber = "+7 (900) 333-33-33"
                    },
                    new Customer
                    {
                        Id = 4,
                        LastName = "Зинкевич",
                        FirstName = "Никита",
                        MiddleName = "Сергеевич",
                        Adress = "Смоленск, шоссе Блока, 66",
                        PhoneNumber = "+7 (900) 444-44-44"
                    },
                    new Customer
                    {
                        Id = 5,
                        LastName = "Избанова",
                        FirstName = "Ольга",
                        MiddleName = "Евгеньевна",
                        Adress = "Рудня, спуск Бианки, 49",
                        PhoneNumber = "+7 (900) 555-55-55"
                    },
                    new Customer
                    {
                        Id = 6,
                        LastName = "Кулакова",
                        FirstName = "Яна",
                        MiddleName = "Алексеевна",
                        Adress = "Смоленск, ул. Рыленкова, 49а",
                        PhoneNumber = "+7 (900) 666-66-66"
                    },
                    new Customer
                    {
                        Id = 7,
                        LastName = "Михайлова",
                        FirstName = "Ангелина",
                        MiddleName = "Дмитриевна",
                        Adress = "Смоленск, пр. Пушкина, 37",
                        PhoneNumber = "+7 (900) 777-77-77"
                    },
                    new Customer
                    {
                        Id = 8,
                        LastName = "Оноприенко",
                        FirstName = "Анастасия",
                        MiddleName = "Геннадьевна",
                        Adress = "Рославль, пер. Джека Лондона, 47",
                        PhoneNumber = "+7 (900) 888-88-88"
                    },
                    new Customer
                    {
                        Id = 9,
                        LastName = "Лазарев",
                        FirstName = "Алексей",
                        MiddleName = "Игоревич",
                        Adress = "Смоленск, пр. Островского, 76",
                        PhoneNumber = "+7 (900) 999-99-99"
                    },
                    new Customer
                    {
                        Id = 10,
                        LastName = "Протаскина",
                        FirstName = "Оксана",
                        MiddleName = "Юрьевна",
                        Adress = "Смоленск, ул. Гоголя, 15",
                        PhoneNumber = "+7 (900) 100-10-10"
                    },
                    new Customer
                    {
                        Id = 11,
                        LastName = "Трофимов",
                        FirstName = "Александр",
                        MiddleName = "Александрович",
                        Adress = "Починок, наб. Толстого, 74",
                        PhoneNumber = "+7 (900) 110-11-11"
                    },
                    new Customer
                    {
                        Id = 12,
                        LastName = "Харламов",
                        FirstName = "Павел",
                        MiddleName = "Сергеевич",
                        Adress = "Смоленск, пл. Ломоносова, 39",
                        PhoneNumber = "+7 (900) 120-12-12"
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
                        GoodId = 3,
                        DateOrder = new DateTime(2022, 02, 01),
                        CustomerId = 1,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 05),
                        ReleaseDate = new DateTime(2022, 02, 07),
                        OrderPrice = 16399.50M,
                        IsPayed = true,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 2,
                        GoodId = 4,
                        DateOrder = new DateTime(2022, 02, 02),
                        CustomerId = 2,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 06),
                        ReleaseDate = new DateTime(2022, 02, 07),
                        OrderPrice = 14899.50M,
                        IsPayed = true,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 3,
                        GoodId = 11,
                        DateOrder = new DateTime(2022, 02, 02),
                        CustomerId = 6,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 06),
                        ReleaseDate = new DateTime(2022, 02, 07),
                        OrderPrice = 8999.50M,
                        IsPayed = false,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 4,
                        GoodId = 1,
                        DateOrder = new DateTime(2022, 02, 03),
                        CustomerId = 1,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 07),
                        ReleaseDate = new DateTime(2022, 02, 07),
                        OrderPrice = 9599.50M,
                        IsPayed = false,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 5,
                        GoodId = 9,
                        DateOrder = new DateTime(2022, 02, 04),
                        CustomerId = 11,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 08),
                        ReleaseDate = new DateTime(2022, 02, 08),
                        OrderPrice = 30499.50M,
                        IsPayed = true,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 6,
                        GoodId = 10,
                        DateOrder = new DateTime(2022, 02, 04),
                        CustomerId = 7,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 08),
                        ReleaseDate = new DateTime(2022, 02, 08),
                        OrderPrice = 7799.50M,
                        IsPayed = true,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 7,
                        GoodId = 5,
                        DateOrder = new DateTime(2022, 02, 07),
                        CustomerId = 9,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 10),
                        ReleaseDate = new DateTime(2022, 02, 11),
                        OrderPrice = 20999.50M,
                        IsPayed = false,
                        OrderProgress = false
                    },
                    new Orders
                    {
                        Id = 8,
                        GoodId = 1,
                        DateOrder = new DateTime(2022, 02, 09),
                        CustomerId = 6,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 12),
                        ReleaseDate = new DateTime(2022, 02, 12),
                        OrderPrice = 21399.50M,
                        IsPayed = false,
                        OrderProgress = false
                    }
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
                        Id = 1,
                        ServiceId = 1,
                        OrderedDate = new DateTime(2022, 02, 02),
                        CustomerId = 3,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 07),
                        ReleaseDate = new DateTime(2022, 02, 06),
                        Price = 3999.50M,
                        IsPayed = true,
                        Progress = false
                    },
                    new OrderedService
                    {
                        Id = 2,
                        ServiceId = 1,
                        OrderedDate = new DateTime(2022, 02, 03),
                        CustomerId = 1,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 07),
                        ReleaseDate = new DateTime(2022, 02, 07),
                        Price = 3999.50M,
                        IsPayed = true,
                        Progress = false
                    },
                    new OrderedService
                    {
                        Id = 3,
                        ServiceId = 1,
                        OrderedDate = new DateTime(2022, 02, 07),
                        CustomerId = 9,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 11),
                        ReleaseDate = new DateTime(2022, 02, 10),
                        Price = 3999.50M,
                        IsPayed = true,
                        Progress = false
                    },
                    new OrderedService
                    {
                        Id = 4,
                        ServiceId = 2,
                        OrderedDate = new DateTime(2022, 02, 08),
                        CustomerId = 12,
                        ProvisionalReleaseDate = new DateTime(2022, 02, 11),
                        ReleaseDate = new DateTime(2022, 02, 11),
                        Price = 1999.50M,
                        IsPayed = false,
                        Progress = false
                    }
                };

                _context.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}

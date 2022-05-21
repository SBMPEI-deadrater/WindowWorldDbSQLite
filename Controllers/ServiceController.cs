﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;

namespace WindowWorldDbSQLite.Controllers
{
    public class ServiceController
    {
        public List<Service> GetAllServicesByFilter(string search = "", string field = "")
        {
            List<Service> services = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    if(search != "")
                    {
                        services = db.Services.OrderBy(s => s.TypeService).ToList();
                    }
                    else
                    {
                        var list = db.Services.OrderBy(s => s.TypeService).ToList();
                        switch (field)
                        {
                            case "common":
                                services = list
                                    .Where(
                                        s => s.TypeService.ToString().ToLower().Contains(search.ToLower())
                                        || s.Price.ToString().ToLower().Contains(field.ToLower())
                                    ).ToList();
                                break;

                            case "type":
                                services = list
                                    .Where(
                                        s => s.TypeService.ToString().ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "price":
                                services = list
                                    .Where(
                                        s => s.Price.ToString().ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return services;
        }

        public Service GetSingleService(int _id)
        {
            Service service = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    service = db.Services.FirstOrDefault(s => s.Id == _id);
                }
            }
            catch
            {
                return null;
            }

            return service;
        }

        public bool AddSingleNewService(Service obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    db.Services.Add(obj);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool DeleteSingleService(Service obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    db.Services.Remove(obj);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }
    }
}
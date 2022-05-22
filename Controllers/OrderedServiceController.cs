﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite.Controllers
{
    public class OrderedServiceController
    {
        private SettingsDatabase settingsDatabase = new SettingsDatabase();
        public List<OrderedService> GetAllOrderedServiceByFilter(string search = "", string field = "")
        {
            List<OrderedService> orderedServiceList = null;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(search == "")
                    {
                        orderedServiceList = db.OrderedServices.OrderBy(os => os.Price).ToList();
                    }
                    else
                    {
                        var list = db.OrderedServices.ToList();
                        switch (field)
                        {
                            default:
                                list = list.OrderBy(os => os.Price).ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return orderedServiceList;
        }

        public OrderedService GetSingleOrderedService(int _id)
        {
            OrderedService orderedService = null;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    orderedService = db.OrderedServices.FirstOrDefault(os => os.Id == _id);
                }
            }
            catch
            {
                return null;
            }

            return orderedService;
        }

        public bool AddSingleNewOrderedService(OrderedService obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    db.OrderedServices.Add(obj);
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

        public bool DeleteSingleOrderedService(OrderedService obj)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.OrderedServices.Any(os => os.Id == obj.Id))
                    {
                        db.OrderedServices.Remove(obj);
                        db.SaveChanges();
                        result = true;
                    }
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

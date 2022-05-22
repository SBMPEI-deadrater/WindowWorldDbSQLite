using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite.Controllers
{
    public class OrdersController
    {
        private SettingsDatabase settingsDatabase = new SettingsDatabase();
        public List<Orders> GetAllOrders(string search = "", string field = "")
        {
            List<Orders> orders = null;
            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    orders = db.Orders.OrderBy(o => o.OrderPrice).ToList();
                }
            }
            catch
            {
                return null;
            }

            return orders;
        }

        public Orders GetSingleOrders(int _id)
        {
            Orders order = null;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    order = db.Orders.FirstOrDefault(o => o.Id == _id);
                }
            }
            catch
            {
                return null;
            }

            return order;
        }

        public bool AddSingleNewOrder(Orders obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    db.Orders.Add(obj);
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

        public bool DeleteSingleOrder(Orders obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.Orders.Any(o => o.Id == obj.Id))
                    {
                        db.Orders.Remove(obj);
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

        public bool UpdateSingleOrder(Orders obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.Orders.Any(o => o.Id == obj.Id))
                    {
                        db.Orders.Update(obj);
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

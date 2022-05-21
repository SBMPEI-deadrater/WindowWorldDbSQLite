using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;

namespace WindowWorldDbSQLite.Controllers
{
    public class OrdersController
    {
        public List<Orders> GetAllOrders(string search = "", string field = "")
        {
            List<Orders> orders = null;
            try
            {
                using(_ContextDb db = new _ContextDb())
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
                using(_ContextDb db = new _ContextDb())
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
                using(_ContextDb db = new _ContextDb())
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
                using(_ContextDb db = new _ContextDb())
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
    }
}

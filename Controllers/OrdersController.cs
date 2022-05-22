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
        public List<Orders> GetAllOrders()
        {
            List<Orders> orders = null;
            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    orders = db.Orders.OrderBy(o => o.DateOrder).ToList();
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

        public List<OrdersForDocx> GetOrdersForDocx(DateTime start, DateTime end)
        {
            List<OrdersForDocx> result = new List<OrdersForDocx>();
            List<Orders> myList = null;

            try
            {
                GoodController goodController = new GoodController();
                CustomerContrller customerContrller = new CustomerContrller();

                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    var list = db.Orders.ToList();
                    myList = list
                        .Where(
                            o => (o.DateOrder >= start && o.DateOrder <= end)
                        ).OrderBy(o => o.DateOrder).ToList();
                }

                if(myList != null && myList.Count > 0)
                {
                    foreach (var order in myList)
                    {
                        var good = goodController.GetSingleGood(order.GoodId);
                        var customer = customerContrller.GetSingleCustomer(order.CustomerId);

                        result.Add(new OrdersForDocx
                        {
                            GoodItem = good,
                            DateOrder = order.DateOrder,
                            CustomerItem = customer,
                            ProvisionalReleaseDate = order.ProvisionalReleaseDate,
                            ReleaseDate = order.ReleaseDate,
                            OrderPrice = order.OrderPrice,
                            IsPayed = order.IsPayed,
                            OrderProgress = order.OrderProgress
                        });
                    }
                }
            }
            catch
            {
                return null;
            }

            return result;
        }
        
        public Dictionary<string, decimal> GetListOrdersMaxProfit()
        {
            var result = new Dictionary<string, decimal>();

            try
            {
                GoodController goodController = new GoodController();
                var goods = goodController.GetAllGoodByFilter();

                var listOrders = new List<Orders>();

                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    listOrders = db.Orders.ToList();
                }

                if(listOrders != null && listOrders.Count > 0)
                {
                    foreach (var good in goods)
                    {
                        decimal sum = 0M;
                        foreach(var order in listOrders)
                        {
                            if(good.Id == order.GoodId)
                            {
                                sum += order.OrderPrice;
                            }
                        }
                        result.Add(good.Name, sum);
                    }

                    result.OrderBy(r => r.Value);
                }
            }
            catch
            {
                return null;
            }

            return result;
        }
    }
}

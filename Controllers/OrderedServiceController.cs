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
                    var list = db.OrderedServices.ToList();
                    if (search == "")
                    {
                        orderedServiceList = list.OrderBy(os => os.OrderedDate).ToList();
                    }
                    else
                    {
                        switch (field)
                        {
                            default:
                                orderedServiceList = list.OrderBy(os => os.OrderedDate).ToList();
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

        public bool UpdateSingleOrderedService(OrderedService obj)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.OrderedServices.Any(os => os.Id == obj.Id))
                    {
                        db.OrderedServices.Update(obj);
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

        public List<OrderedServiceForMaxProfit> GetOrderedServicesMaxProfitForDocx(DateTime start, DateTime end)
        {
            List<OrderedServiceForMaxProfit> result = new List<OrderedServiceForMaxProfit>();
            List<OrderedService> myList = null;

            try
            {
                CustomerContrller customerContrller = new CustomerContrller();
                ServiceController serviceController = new ServiceController();

                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    var list = db.OrderedServices.ToList();
                    myList = list
                        .Where(
                            os => (os.OrderedDate >= start && os.OrderedDate <= end) && (os.ReleaseDate > os.ProvisionalReleaseDate)
                        ).OrderBy(os => os.OrderedDate).ToList();
                }

                if(myList != null && myList.Count > 0)
                {
                    foreach(var item in myList)
                    {
                        var service = serviceController.GetSingleService(item.ServiceId);
                        var customer = customerContrller.GetSingleCustomer(item.CustomerId);

                        result.Add(new OrderedServiceForMaxProfit
                        {
                            ServiceItem = service,
                            OrderedDate = item.OrderedDate,
                            CustomerItem = customer,
                            ProvisionalReleaseDate = item.ProvisionalReleaseDate,
                            ReleaseDate = item.ReleaseDate,
                            Price = item.Price,
                            IsPayed = item.IsPayed,
                            Progress = item.Progress
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
    }
}

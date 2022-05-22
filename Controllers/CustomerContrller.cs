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
    public class CustomerContrller
    {
        private SettingsDatabase settingsDatabase = new SettingsDatabase();
        public List<Customer> GetAllCustomers(string search = "", string field = "")
        {
            List<Customer> customers = null;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (search != "")
                    {
                        customers = db.Customers.ToList();
                    }
                    else
                    {
                        var list = db.Customers.ToList();
                        switch (field)
                        {
                            case "common":
                                customers = list
                                    .Where(
                                        c => c.LastName.ToString().ToLower().Contains(search.ToLower())
                                        || c.FirstName.ToString().ToLower().Contains(search.ToLower())
                                        || c.MiddleName.ToString().ToLower().Contains(search.ToLower())
                                        || c.Adress.ToString().ToLower().Contains(search.ToLower())
                                        || c.PhoneNumber.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(c => c.LastName).ToList();
                                break;

                            case "adress":
                                customers = list
                                    .Where(
                                        c => c.Adress.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(c => c.LastName).ToList();
                                break;

                            case "phone":
                                customers = list
                                    .Where(
                                        c => c.PhoneNumber.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(c => c.LastName).ToList();
                                break;

                            default:
                                customers = db.Customers.ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return customers;
        }

        public Customer GetSingleCustomer(int _id)
        {
            Customer customer = null;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.Customers.Any(c => c.Id == _id))
                    {
                        customer = db.Customers.FirstOrDefault(c => c.Id == _id);
                    }
                }
            }
            catch
            {
                return null;
            }

            return customer;
        }

        public bool AddSingleNewCustomer(Customer obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    db.Customers.Add(obj);
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

        public bool DeleteSingleCustomer(Customer obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.Customers.Any(c => c.Id == obj.Id))
                    {
                        db.Customers.Remove(obj);
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

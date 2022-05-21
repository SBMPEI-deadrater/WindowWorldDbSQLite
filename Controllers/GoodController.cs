using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;

namespace WindowWorldDbSQLite.Controllers
{
    public class GoodController
    {
        public List<Good> GetAllGoodByFilter(string search = "", string field = "")
        {
            List<Good> goods = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    if (search == "")
                    {
                        goods = db.Goods.OrderBy(g => g.Name).ToList();
                    }
                    else
                    {
                        var list = db.Goods.ToList();
                        switch (field)
                        {
                            case "common":
                                goods = list
                                    .Where(
                                        g => g.Name.ToString().ToLower().Contains(search.ToLower())
                                        || g.Company.ToString().ToLower().Contains(search.ToLower())
                                        || g.TypeGood.ToString().ToLower().Contains(search.ToLower())
                                        || g.Name.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "company":
                                goods = list
                                    .Where(
                                        g => g.Company.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "type":
                                goods = list
                                    .Where(
                                        g => g.TypeGood.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "price":
                                goods = list
                                    .Where(
                                        g => g.Price.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "name":
                                goods = list
                                    .Where(
                                        g => g.Name.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            default:
                                goods = list.OrderBy(g => g.Name).ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return goods;
        }

        public Good GetSingleGood(int _id)
        {
            Good good = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    if (db.Goods.Any(g => g.Id == _id))
                    {
                        good = db.Goods.FirstOrDefault(g => g.Id == _id);
                    }
                }
            }
            catch
            {
                return null;
            }

            return good;
        }

        public bool AddSingleNewGood(Good obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    db.Goods.Add(obj);
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

        public bool DeleteSingleGood(Good obj)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    if(db.Goods.Any(g => g.Id == obj.Id))
                    {
                        db.Goods.Remove(obj);
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

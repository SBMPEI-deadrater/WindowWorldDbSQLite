using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services.Interfaces;
using Novacode;

namespace WindowWorldDbSQLite.Services
{
    public class WordService : IWordService
    {
        private StringBuilder GetPathForFile(string _fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string guidCode = Guid.NewGuid().ToString();
            string shortDate = DateTime.Now.ToShortDateString();

            StringBuilder filePath = new StringBuilder();

            filePath.Append(path + "\\" + _fileName + "_" + shortDate + "_" + guidCode + ".docx");

            return filePath;
        }

        public bool CreateDocMaxProfit(List<OrderedServiceForMaxProfit> _list)
        {
            bool result = false;

            try
            {
                StringBuilder path = GetPathForFile("Максимальная_прибыль");
                if(_list == null)
                {
                    throw new Exception();
                }

                using (var document = DocX.Create(path.ToString()))
                {
                    foreach (var item in _list)
                    {
                        string service = item.ServiceItem.TypeService + "(цена: " + Math.Round(item.ServiceItem.Price).ToString() + ")";
                        document.InsertParagraph(service);

                        document.InsertParagraph("Дата заказа: " + item.OrderedDate);

                        string customer = item.CustomerItem.LastName + " " + item.CustomerItem.FirstName + " " + item.CustomerItem.MiddleName + " (ном. тел.: " + item.CustomerItem.PhoneNumber + ")";
                        document.InsertParagraph("Заказчик: " + customer);

                        document.InsertParagraph("Дата предполагаемого выполнения: " + item.ProvisionalReleaseDate.ToString());

                        document.InsertParagraph("Дата фактического выполнения: " + item.ReleaseDate.ToString());

                        document.InsertParagraph("Стоимость заказа: " + Math.Round(item.Price, 2).ToString());

                        document.InsertParagraph("Оплачено: " + (item.IsPayed ? "да" : "нет").ToString());

                        document.InsertParagraph("В работе: " + (item.Progress ? "да" : "нет").ToString());

                        document.InsertParagraph("#########################################");
                        document.InsertParagraph();
                    }
                    document.Save();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool CreateDocOrders(List<OrdersForDocx> _list)
        {
            bool result = false;

            try
            {
                StringBuilder path = GetPathForFile("Список_заказов_за_период");
                if (_list == null)
                {
                    throw new Exception();
                }

                using (var document = DocX.Create(path.ToString()))
                {
                    foreach(var item in _list)
                    {
                        string good = item.GoodItem.Name + ", цена: " + item.GoodItem.Price + "; компания: " + item.GoodItem.Price;
                        document.InsertParagraph("Изделие -- " + good);

                        document.InsertParagraph("Дата заказа: " + item.DateOrder);

                        string customer = item.CustomerItem.LastName + " " + item.CustomerItem.FirstName + " " + item.CustomerItem.MiddleName + " (ном. тел.: " + item.CustomerItem.PhoneNumber + ")";
                        document.InsertParagraph("Заказчик: " + customer);

                        document.InsertParagraph("Дата предполагаемого выполнения: " + item.ProvisionalReleaseDate.ToString());

                        document.InsertParagraph("Дата фактического выполнения: " + item.ReleaseDate.ToString());

                        document.InsertParagraph("Стоимость заказа: " + Math.Round(item.OrderPrice, 2).ToString());

                        document.InsertParagraph("Оплачено: " + (item.IsPayed ? "да" : "нет").ToString());

                        document.InsertParagraph("В работе: " + (item.OrderProgress ? "да" : "нет").ToString());

                        document.InsertParagraph("#########################################");
                        document.InsertParagraph();
                    }
                    document.Save();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public void Dispose()
        {
        }
    }
}

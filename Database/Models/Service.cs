using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WindowWorldDbSQLite.Database.Base;
using WindowWorldDbSQLite.Database.Models;


namespace WindowWorldDbSQLite.Database.Models
{
    public class Service : BaseEntity
    {
        [Column("type_service", Order = 1)]
        public string TypeService { get; set; }

        [Column("price", Order = 2)]
        public decimal Price { get; set; }

        [Column("progress", Order = 3)]
        public bool Progress { get; set; }
    }
}

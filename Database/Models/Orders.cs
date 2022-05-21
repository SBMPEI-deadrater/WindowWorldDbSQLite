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
    [Table("orders")]
    public class Orders: BaseEntity
    {
        [Column("order_id", Order = 1)]
        public int OrderId { get; set; }

        //ДОПОЛНИТЬ
    }
}

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
        [Column("good_id", Order = 1)]
        public int GoodId { get; set; }
        public Good Good { get; set; }

        [Column("date_order", Order = 2)]
        public DateTime DateOrder { get; set; }

        [Column("customer_id", Order = 3)]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("provisional_release_date", Order = 4)]
        public DateTime ProvisionalReleaseDate { get; set; }

        [Column("release_date", Order = 5)]
        public DateTime ReleaseDate { get; set; }

        [Column("order_price", Order = 6)]
        public decimal OrderPrice { get; set; }

        [Column("is_payed", Order = 7)]
        public bool IsPayed { get; set; }

        [Column("order_progress", Order = 8)]
        public bool OrderProgress { get; set; }
    }

    [NotMapped]
    public class OrdersForDocx
    {
        public Good GoodItem { get; set; }
        public DateTime DateOrder { get; set; }
        public Customer CustomerItem { get; set; }
        public DateTime ProvisionalReleaseDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal OrderPrice { get; set; }
        public bool IsPayed { get; set; }
        public bool OrderProgress { get; set; }
    }
}

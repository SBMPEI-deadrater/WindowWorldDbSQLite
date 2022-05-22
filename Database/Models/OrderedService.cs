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
    [Table("ordered_service")]
    public class OrderedService : BaseEntity
    {
        [Column("service_id", Order = 1)]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Column("ordered_date", Order = 2)]
        public DateTime OrderedDate { get; set; }

        [Column("customer_id", Order = 3)]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("provisional_release_date", Order = 4)]
        public DateTime ProvisionalReleaseDate { get; set; }

        [Column("release_date", Order = 5)]
        public DateTime ReleaseDate { get; set; }

        [Column("price", Order = 6)]
        public decimal Price { get; set; }

        [Column("is_payed", Order = 7)]
        public bool IsPayed { get; set; }

        [Column("progress", Order = 8)]
        public bool Progress { get; set; }
    }

    [NotMapped]
    public class OrderedServiceForMaxProfit
    {
        public Service ServiceItem { get; set; }
        public DateTime OrderedDate { get; set; }
        public Customer CustomerItem { get; set; }
        public DateTime ProvisionalReleaseDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public bool IsPayed { get; set; }
        public bool Progress { get; set; }
    }
}

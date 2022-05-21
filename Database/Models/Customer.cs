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
    [Table("customers")]
    public class Customer : BaseEntity
    {
        [Column("last_name", Order = 1)]
        public string LastName { get; set; }

        [Column("first_name", Order = 2)]
        public string FirstName { get; set; }

        [Column("middle_name", Order = 3)]
        public string MiddleName { get; set; }

        [Column("adress", Order = 4)]
        public string Adress { get; set; }

        [Column("phone_number", Order = 5)]
        public string PhoneNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowWorldDbSQLite.Database.Base
{
    public class BaseEntity
    {
        [Column("id", Order = 0)]
        [Key]
        public int Id { get; set; }
    }
}

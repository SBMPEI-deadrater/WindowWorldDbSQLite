using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowWorldDbSQLite.Database.Base
{
    public class BaseEntity: AuditableEntity
    {
        [Column("id", Order = 0)]
        [Key]
        public int Id { get; set; }
    }
}

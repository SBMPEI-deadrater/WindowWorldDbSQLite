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
    /*public class AuditableEntity: IFaceAuditableEntity
    {
        [Column("created_by", Order = 101)]
        [MaxLength(256)]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("updated_by", Order = 103)]
        [MaxLength(256)]
        public string UpdatedBy { get; set; } = string.Empty;

        [Column("created_at", Order = 102)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 104)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }*/
}

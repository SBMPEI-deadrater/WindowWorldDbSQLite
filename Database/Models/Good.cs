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
    [Table("goods")]
    public class Good : BaseEntity
    {
        [Column("name", Order = 1)]
        public string Name { get; set; }
        
        [Column("company", Order = 2)]
        public string Company { get; set; }
        
        [Column("type_good", Order = 3)]
        public string TypeGood { get; set; }
        
        [Column("price", Order = 4)]
        public decimal Price { get; set; }
        
        [Column("photo_url", Order = 5)]
        public string PhotoUrl { get; set; }
        
        [Column("is_active", Order = 6)]
        public bool IsActive { get; set; }
        
        [Column("progress", Order = 7)]
        public bool Progress { get; set; } 
    }
}

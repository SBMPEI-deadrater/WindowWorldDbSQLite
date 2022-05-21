using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Database.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowWorldDbSQLite.Database.Models
{
    /// <summary>
    /// Таблица пользователей
    /// </summary>
    [Table("Users")]
    public class User: BaseEntity
    {
        [Column("username", Order = 1)]
        [MaxLength(256)]
        [Required]
        public string UserName { get; set; }

        [Column("password", Order = 2)]
        [MaxLength(256)]
        [Required]
        public string Password { get; set; }

        [Column("role", Order = 3)]
        [MaxLength(50)]
        [Required]
        public string Role { get; set; }
    }
}

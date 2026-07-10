using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026.EFCore.ModelFirst;
[Table("Tbl_User")]
public class UserEntity
{
    [Key]
    [Column("Id")]
    public int UserId { get; set; }
    [Column("Username")]
    required public string Username { get; set; }
    [Column("Password")]
    required public string Password { get; set; }
    [Column("Bio")]
    required public string Bio { get; set; }
}

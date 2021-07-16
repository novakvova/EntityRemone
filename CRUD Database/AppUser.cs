using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Database
{
    [Table("tbl_users")]
    public class AppUser
    {
        [Key]
        public int Id { get; protected set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }

        public override string ToString()
        {
            string str = $"Id: {Id}\n" +
                $"Name: {LastName} {FirstName}\n";
            str += $"Email: {Email}\n";
            str += $"Phone: {Phone}";
            return str;
        }
    }
}

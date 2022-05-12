using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace manager_artefaktow.Data.Models
{
    public class User
    {
        //public int UserId { get; set; }
        [Key]
        public string UserName { get; set; }

        //string _password;
        //[Required]
        public string Password { get; set; }
            /*
        { 
            get
            {
                return _password;
            }
            set
            {
                _password = BCrypt.Net.BCrypt.HashPassword(value);
            } 
        }
        */
        
        public string RoleName { get; set; } // Role PK

        [ForeignKey(nameof(RoleName))]
        public Role Role { get; set; } // Role Reference
    }
}

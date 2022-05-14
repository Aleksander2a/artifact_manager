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
        public string UserName { get; set; } // PK

        //[Required]
        public string Password { get; set; }
        
        public string RoleName { get; set; } // Role PK

        public Role Role { get; set; } // Role Reference
    }
}

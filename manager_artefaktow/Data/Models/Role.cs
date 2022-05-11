using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserRole> Users { get; set; }
        public ICollection<RolePermition> Permitions { get; set; }
    }
}

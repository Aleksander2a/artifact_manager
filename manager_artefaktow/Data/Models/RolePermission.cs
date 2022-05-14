using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class RolePermission
    {
        public string RoleName { get; set; } // Role PK
        public Role Role { get; set; } // Role Refference
        public string PermissionName { get; set; } // Permission PK
        public Permission Permission { get; set; } // Permission Refference
    }
}

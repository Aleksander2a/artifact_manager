using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace manager_artefaktow.Data.Models
{
    public class Permission
    {
        //public int PermitionId { get; set; }
        public string PermissionName { get; set; } // PK
        public string Description { get; set; }
        public ICollection<RolePermission> Roles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class Permition
    {
        public int PermitionId { get; set; }
        public string PermitionName { get; set; }
        public ICollection<RolePermition> Roles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace manager_artefaktow.Data.Models
{
    // useless - not in DbContext
    public class UserRole
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}

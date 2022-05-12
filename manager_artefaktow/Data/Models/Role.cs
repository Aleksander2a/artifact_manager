﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace manager_artefaktow.Data.Models
{
    public class Role
    {
        [Key]
        [MinLength(1)]
        public string RoleName { get; set; }
        //public ICollection<UserRole> Users { get; set; }
        public ICollection<RolePermission> Permissions { get; set; }
    }
}

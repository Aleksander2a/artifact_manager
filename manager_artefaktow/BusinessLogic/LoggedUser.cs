using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class LoggedUser
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string RoleName { get; set; }
        //public static ICollection<UserRole> Roles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class RoleManagement
    {

        public static List<String> findPermissionsForRoleName(string roleName)
        {
            var dbContext = new ManagerContext();
            var permissions = (from p 
                               in dbContext.RolePermissions
                               where p.RoleName == roleName
                               select p.PermissionName).ToList();
            return permissions;
        }
    }
}

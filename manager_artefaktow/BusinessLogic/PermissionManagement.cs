using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class PermissionManagement
    {
        public static List<String> getAllPermissionsNames()
        {
            var dbContext = new ManagerContext();
            return (from p in dbContext.Permissions select p.PermissionName).ToList();
        }
    }
}

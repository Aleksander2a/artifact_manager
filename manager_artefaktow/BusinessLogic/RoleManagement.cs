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

        public static bool RoleExists(string roleName)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    Role role = dbContext.Roles.Find(roleName);
                    if (role != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Exception while checking if role exists");
            }
        }

        public static void AddRoleOnlyRoleName(string roleName)
        {
            Role role = new Role();
            role.RoleName = roleName;
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    dbContext.Roles.Add(role);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static void SetPermissionsToRole(string roleName, List<string> permissionsNames)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    Role role = dbContext.Roles.Find(roleName);
                    if (role != null)
                    {
                        var previousPermissions = (from p in dbContext.RolePermissions
                                                   where p.RoleName == roleName
                                                   select p).ToList();
                        if (previousPermissions.Count() > 0)
                        {
                            foreach (var previous in previousPermissions)
                            {
                                dbContext.Remove(previous);
                                dbContext.SaveChanges();
                            }
                        }
                        foreach (var permission in permissionsNames)
                        {
                            RolePermission rolePermission = new RolePermission();
                            rolePermission.RoleName = roleName;
                            rolePermission.PermissionName = permission;
                            dbContext.RolePermissions.Add(rolePermission);
                            dbContext.SaveChanges();
                        }
                    }
                    else
                    {
                        throw new Exception("Role does not exist");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static bool CanDeleteRole(string roleName)
        {
            var dbContext = new ManagerContext();
            int roleCount = dbContext.Roles.Count();
            if (roleCount <= 2 || roleName == "Admin")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void SetRandomDefaultRRoleExcept(string roleName)
        {
            var dbContext = new ManagerContext();
            var roles = (from r in dbContext.Roles
                         select r.RoleName).ToList();
            foreach (var role in roles)
            {
                if (role != "Admin" && role != roleName)
                {
                    AppPropertiesManagement.SetOrCreatePropertyWithValue("DefaultRole", role);
                    return;
                }
            }
        }

        public static List<string> GetAllRolesNames()
        {
            var dbContext = new ManagerContext();
            var roles = (from r in dbContext.Roles
                         select r.RoleName).ToList();
            return roles;
        }
    }
}

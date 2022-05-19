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
        public static string type_create = "Create";
        public static string type_update = "Update";
        public static string type_delete = "Delete";

        public static string subject_categories = "Categories";
        public static string subject_instances = "Instances";

        public static string scopes_all = "All";

        public static string owner_all = "All";
        public static string owner_own = "Own";

        public static List<String> getAllPermissionsNames()
        {
            var dbContext = new ManagerContext();
            return (from p in dbContext.Permissions select p.PermissionName).ToList();
        }

        public static List<string> GetAllPermissionTypes()
        {
            return new List<string> { type_create, type_update, type_delete };
        }

        public static List<string> GetAllPermissionSubjects()
        {
            return new List<string> { subject_categories, subject_instances };
        }

        public static List<string> GetAllPermissionScopesForSubject(string subject)
        {
            List<string> scopes = new List<string>() { scopes_all};
            if (subject == subject_categories)
            {
                scopes.AddRange(CategoryManagement.FindAllCategories());
                return scopes;
            }
            else if (subject == subject_instances)
            {
                scopes.AddRange(InstanceManagement.FindAllInstancesNames());
                return scopes;
            }
            return new List<string>();
        }

        public static List<string> GetAllPermissionOwners()
        {
            return new List<string>() { owner_all , owner_own };
        }

        public static bool PermissionExists(string permissionName)
        {
            var dbContext = new ManagerContext();
            Permission permission = dbContext.Permissions.Find(permissionName);
            if (permissionName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddPermission(string permissionName, string description)
        {
            var dbContext = new ManagerContext();
            Permission permission = new Permission();
            permission.PermissionName = permissionName;
            permission.Description = description;
            dbContext.Permissions.Add(permission);
            dbContext.SaveChanges();
        }



    }
}

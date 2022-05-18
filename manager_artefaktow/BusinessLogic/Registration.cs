using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BCryptNet = BCrypt.Net.BCrypt;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class Registration
    {
        public static readonly string SuccessMessage = "You registered successfully!";
        public static readonly string InvalidFormMessage = "Incorectly completed form, try again";
        public static readonly string UserAlreadyExistsMessage = "User with this name already exists";
        


        public static string Register(string name, string password, string confirmPassword)
        {
            if(FormIsValid(name, password, confirmPassword))
            {
                if(!UserExists(name))
                {
                    LoggedUser.UserName = name;
                    if (name == "Admin")
                    {
                        if (RoleManagement.RoleExists(name))
                        {
                            AddUser(name, password, name);
                        }
                        else
                        {
                            RoleManagement.AddRoleOnlyRoleName(name);
                            AddUser(name, password, name);
                        }
                        
                        LoggedUser.RoleName = "Admin";
                    }
                    else
                    {
                        string role = AppPropertiesManagement.GetPropertyValue("DefaultRole");
                        if (RoleManagement.RoleExists(role))
                        {
                            AddUser(name, password, role);
                        }
                        else
                        {
                            RoleManagement.AddRoleOnlyRoleName(role);
                            AddUser(name, password, role);
                        }
                        LoggedUser.RoleName = role;
                    }
                    return SuccessMessage;
                }
                else
                {
                    return UserAlreadyExistsMessage;
                }
            }
            else
            {
                return InvalidFormMessage;
            }
        }

        public static bool FormIsValid(string name, string password, string confirmPassword)
        {
            if ((password == confirmPassword) && (name!="") && (password!=""))
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        public static bool UserExists(string name)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    User user = dbContext.Users.Find(name);
                    if (user != null)
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
                throw new Exception("Exception while checking if user exists");
            }
        }

        private static void AddUser(string name, string password, string role)
        {
            User user = new User();
            user.UserName = name;
            user.Password = BCrypt.Net.BCrypt.HashPassword(password);
            user.RoleName = role;
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

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
    public static class UserManagement
    {
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

        public static User FindUser(string username)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    User user = dbContext.Users.Find(username);
                        return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Exception while checking if user exists");
            }
        }

        public static List<string> GetAllUserNames()
        {
            var dbContext = new ManagerContext();
            var users = (from u in dbContext.Users
                         select u.UserName).ToList();
            return users;
        }

        public static void EditUser(string oldUserName, string userName, string password, string roleName)
        {
            var dbContext = new ManagerContext();
            User user = FindUser(oldUserName);
            user.UserName = userName;
            user.Password = password;
            user.RoleName = roleName;
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }

        public static void AddUser(string username, string password, string role)
        {
            var dbContext = new ManagerContext();
            User user = new User();
            user.UserName = username;
            user.Password = password;
            user.RoleName = role;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public static void ChangeUserPassword(string userName, string password)
        {
            var dbContext = new ManagerContext();
            User user = dbContext.Users.Find(userName);
            user.Password = encryptPassword(password);
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }

        public static string encryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}

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

        public static string encryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}

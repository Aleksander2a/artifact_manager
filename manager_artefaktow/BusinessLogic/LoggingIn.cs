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
    public static class LoggingIn
    {
        public static readonly string SuccessMessage = "You loggd in successfully!";
        public static readonly string UserDoesNotExistMessage = "User with this name does not exist";
        public static readonly string IncorrectPasswordMessage = "The password is incorrect for this user";


        public static string LogIn(string name, string password)
        {
            if (UserExists(name))
            {
                if (UserPasswordIsCorrect(name, password))
                {
                    LoggedUser.UserName = name;
                    return SuccessMessage;
                }
                else
                {
                    return IncorrectPasswordMessage;
                }
            }
            else
            {
                return UserDoesNotExistMessage;
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

        public static bool UserPasswordIsCorrect(string name, string password)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    User user = dbContext.Users.Find(name);
                    if (user != null)
                    {
                        if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                        {
                            return true;
                        }
                        else 
                        {
                            return false;
                        }
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
    }
}

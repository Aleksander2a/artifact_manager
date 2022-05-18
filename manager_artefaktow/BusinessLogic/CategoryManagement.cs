using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class CategoryManagement
    {
        public static List<String> FindPropertiesForCategoryName(string categoryName)
        {
            var dbContext = new ManagerContext();
            var propertiesNames = (from p
                               in dbContext.CategoryProperties
                               where p.CategoryName == categoryName
                                   select p.PropertyName).ToList();
            return propertiesNames;
        }

        public static bool CategoryExists(string categoryName)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    Category category = dbContext.Categories.Find(categoryName);
                    if (category != null)
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
                throw new Exception("Exception while checking if category exists");
            }
        }

        public static void AddCategory(string categoryName, string creatorName)
        {
            Category category = new Category();
            category.CategoryName = categoryName;
            category.CreatorName = creatorName;
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    dbContext.Categories.Add(category);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static void AddPropertyToCategory(string propertyName, string categoryName)
        {
            var dbContext = new ManagerContext();
            CategoryProperty categoryProperty = new CategoryProperty();
            categoryProperty.PropertyName = propertyName;
            categoryProperty.CategoryName = categoryName;
            dbContext.CategoryProperties.Add(categoryProperty);
            dbContext.SaveChanges();
            return;
        }

        public static void RemovePropertiesFromCategory(List<string> propertiesNames, string categoryName)
        {
            var dbContext = new ManagerContext();
            var properties = (from cp in dbContext.CategoryProperties
                              where cp.CategoryName == categoryName
                              select cp).ToList();
            dbContext.CategoryProperties.RemoveRange(properties);
            dbContext.SaveChanges();
            return;
        }
    }
}

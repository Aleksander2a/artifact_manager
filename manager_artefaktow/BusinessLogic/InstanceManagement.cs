using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.BusinessLogic
{
    public static class InstanceManagement
    {

        public static bool InstanceExists(string instanceName)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    Instance instance = dbContext.Instances.Find(instanceName);
                    if (instance != null)
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
                throw new Exception("Exception while checking if instance exists");
            }
        }

        public static Instance FindInstanceByName(string instanceName)
        {
            var dbContext = new ManagerContext();
            Instance instance = dbContext.Instances.Find(instanceName);
            return instance;
        }

        public static string FindInstanceCreator(string instanceName)
        {
            var dbContext = new ManagerContext();
            return dbContext.Instances.Find(instanceName).CreatorName;
        }

        public static List<string> FindAllInstancesNames()
        {
            var dbContext = new ManagerContext();
            var instances = (from i in dbContext.Instances
                             select i.InstanceName).ToList();
            return instances;
        }

        public static void AddOrUpdateInstance(Instance instance)
        {
            var dbContext = new ManagerContext();
            if (InstanceExists(instance.InstanceName))
            {
                dbContext.Instances.Update(instance);
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Instances.Add(instance);
                dbContext.SaveChanges();
            }
        }

        public static bool InstancePropertyValueExists(string instanceName, string propertyName, string propertyValue)
        {
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    InstancePropertyValue instancePropertyValue = dbContext.InstanceProperties.Find(propertyValue, propertyName, instanceName);
                    if (instancePropertyValue != null)
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
                throw new Exception("Exception while checking if instance property value exists");
            }
        }

        public static void AddInstanceOnly(string instanceName, string creatorName, string categoryName, int overall)
        {
            Instance instance = new Instance();
            instance.InstanceName = instanceName;
            instance.CategoryName = categoryName;
            instance.CreatorName = creatorName;
            instance.Overall = overall;
            try
            {
                using (var dbContext = new ManagerContext())
                {
                    dbContext.Instances.Add(instance);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static List<string> GetPropertyValuesFromInstance(string instanceName)
        {
            var dbContext = new ManagerContext();
            Instance instance = dbContext.Instances.Find(instanceName);
            var neededProperties = (from cp in dbContext.CategoryProperties
                                    where cp.CategoryName == instance.CategoryName
                                    select cp.PropertyName).ToList();
            return neededProperties;
        }

        public static void AddPropertyValueToInstance(string instanceName, string propertyName, string propertyValue)
        {
            var dbContext = new ManagerContext();
            if (GetPropertyValuesFromInstance(instanceName).Contains(propertyName))
            {
                InstancePropertyValue instancePropertyValue = new InstancePropertyValue();
                instancePropertyValue.InstanceName = instanceName;
                instancePropertyValue.PropertyName = propertyName;
                instancePropertyValue.PropertyValue = propertyValue;

                dbContext.InstanceProperties.Add(instancePropertyValue);
                dbContext.SaveChanges();
            }
        }

        public static void RemovePropertyValueFromInstance(string instanceName, string propertyName, string propertyValue)
        {
            var dbContext = new ManagerContext();
            InstancePropertyValue instancePropertyValue = dbContext.InstanceProperties.Find(propertyValue, propertyName, instanceName);
            dbContext.InstanceProperties.Remove(instancePropertyValue);
            dbContext.SaveChanges();
        }

        public static void RemoveAllPropertyValuesForInstanceName(string instanceName)
        {
            var dbContext = new ManagerContext();
            var propVals = (from ipv in dbContext.InstanceProperties
                            where ipv.InstanceName == instanceName
                            select ipv).ToList();
            dbContext.InstanceProperties.RemoveRange(propVals);
            dbContext.SaveChanges();
        }

        public static string GetValueByInstancePropertyNames(string instanceName, string propertyName)
        {
            var dbContext = new ManagerContext();
            var value = (from ipv in dbContext.InstanceProperties
                            where ipv.InstanceName == instanceName && ipv.PropertyName == propertyName
                            select ipv.PropertyValue).ToList();
            if (value.Count > 0)
            {
                return value[0];
            }
            else
            {
                return "";
            }
        }
    }
}

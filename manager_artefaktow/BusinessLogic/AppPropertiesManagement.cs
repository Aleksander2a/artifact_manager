using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.BusinessLogic
{
    public static class AppPropertiesManagement
    {
        private static Dictionary<string, string> PropertiesValues = new Dictionary<string, string>();
        private static readonly string PropertiesFilePath = "../../AppProperties.txt";


        public static void LoadPropertiesFromFile()
        {
            string[] records = System.IO.File.ReadAllLines(PropertiesFilePath);
            foreach (string record in records)
            {
                string[] elements = record.Split(':');
                //if (!PropertiesValues.ContainsKey(elements[0]))
                //{
                    PropertiesValues[elements[0]] = elements[1];
                //}
            }
        }

        public static bool PropertyExists(string propertyName)
        {
            LoadPropertiesFromFile();
            if(PropertiesValues.ContainsKey(propertyName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetPropertyValue(string propertyName)
        {
            LoadPropertiesFromFile();
            if (PropertiesValues.ContainsKey(propertyName))
            {
                return PropertiesValues[propertyName];
            }
            else
            {
                throw new Exception("This property does not exist");
            }
        }

        public static void SetOrCreatePropertyWithValue(string propertyName, string value)
        {
            LoadPropertiesFromFile();
            PropertiesValues[propertyName] = value;
            //string[] properties = new string[PropertiesValues.Count];
            //int index = 0;
            StreamWriter sw = new StreamWriter(PropertiesFilePath);
            foreach (var prop in PropertiesValues.Keys)
            {
                //properties[index++] = propertyName + ":" + PropertiesValues[prop];
                sw.WriteLine(propertyName + ":" + PropertiesValues[prop]);
            }
            sw.Close();
            //StreamWriter sw = File.WriteAllLines(PropertiesFilePath, properties);
        }
    }
}

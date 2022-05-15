using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class InstancePropertyValue
    {
        public string PropertyValue { get; set; } // PK
        public string PropertyName { get; set; } // PK
        public string InstanceName {  get; set; } // PK / Instance PK
        public Instance Instance { get; set; } // Instance Reference
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class Instance
    {
        public string InstanceName { get; set; } // PK
        public int Overall { get; set; } // Mandatory field of general power points of instance
        public string CategoryName { get; set; } // Category PK
        public Category Category { get; set; } // Category Reference
        public string CreatorName { get; set; } // User PK
        public User Creator { get; set; } // User Reference 
        public ICollection<InstancePropertyValue> PropertyValues { get; set; }
    }
}

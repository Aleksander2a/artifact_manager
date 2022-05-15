using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace manager_artefaktow.Data.Models
{
    public class Category
    {
        public string CategoryName { get; set; } // PK
        public string AncestoresNames { get; set; } // eg. Root/Parent1/Parent2
        public string CreatorName { get; set; } // User PK
        public User Creator { get; set; } // User Reference 
        public ICollection<Instance> Instances { get; set; }
        public ICollection<CategoryProperty> Properties { get; set; }
    }
}

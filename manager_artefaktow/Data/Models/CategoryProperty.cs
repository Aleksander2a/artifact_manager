using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_artefaktow.Data.Models
{
    public class CategoryProperty
    {
        public string PropertyName { get; set; } // PK
        public string CategoryName { get; set; } // PK / Category PK
        public Category Category { get; set; } // Category Reference
    }
}

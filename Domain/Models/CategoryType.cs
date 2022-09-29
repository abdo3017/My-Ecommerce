using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CategoryType
    {
        public int IdCategory { get; set; }
        public int IdType { get; set; }
        public Type Type { get; set; }
        public Category Category { get; set; }

    }
}

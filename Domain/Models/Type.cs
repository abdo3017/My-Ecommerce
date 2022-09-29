using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemCount { get; set; }

        public ICollection<BrandType> BrandTypes { get; set; }
        public ICollection<CategoryType> CategoryTypes { get; set; }
    }
}

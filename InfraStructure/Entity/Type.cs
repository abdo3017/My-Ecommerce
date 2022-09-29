using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Entity
{
    public class Type
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public int ItemCount { get; set; }
        public ICollection<Product> Products { get; set; }

        public ICollection<BrandType> BrandTypes { get; set; }
        public ICollection<CategoryType> CategoryTypes { get; set; }
    }
}

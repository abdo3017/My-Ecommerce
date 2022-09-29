using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace InfraStructure.Entity
{
    public class Brand
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<BrandType> BrandTypes { get; set; }


    }
}

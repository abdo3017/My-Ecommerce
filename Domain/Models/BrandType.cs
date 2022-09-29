using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BrandType
    {
        public int IdBrand { get; set; }
        public Brand Brand { get; set; }

        public int IdType { get; set; }
        public Type Type { get; set; }
    }
}

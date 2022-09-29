using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Entity
{
    public class Color
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public Product Product { get; set; }
    }
}

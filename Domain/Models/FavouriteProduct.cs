using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FavouriteProduct
    {
        public int IdProduct { get; set; }
        public Product Product { get; set; }

        public string IdUser { get; set; }
        public User User { get; set; }
    }
}

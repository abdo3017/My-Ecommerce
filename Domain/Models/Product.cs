using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int IdBrand { get; set; }
        public Brand Brand { get; set; }

        public int IdType { get; set; }
        public Type Type { get; set; }

        public int IdCategory { get; set; }
        public Category Category { get; set; }

        public ICollection<Image> Images { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<Size> Sizes { get; set; }

        public ICollection<FavouriteProduct> FavouriteProducts { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}

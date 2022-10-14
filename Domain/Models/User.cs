using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public ICollection<FavouriteProduct> FavouriteProducts { get; set; }

        public ICollection<CartItem> CartItems { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Entity
{
    public class User
    {
        [Key]
        [ForeignKey("identityUser")]
        public string Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }

        public IdentityUser identityUser{ get; set; }
        public ICollection<FavouriteProduct> FavouriteProducts { get; set; }
        public ICollection<CartItem> CartItems { get; set; }

    }
}

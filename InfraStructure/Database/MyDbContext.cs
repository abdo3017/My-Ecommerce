using InfraStructure.Configration;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = InfraStructure.Entity.Type;

namespace InfraStructure.Database
{
    public class MyDbContext: IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(CartItemConfig).Assembly);
            base.OnModelCreating(builder);  
        }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categorys { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<FavouriteProduct> FavouriteProducts { get; set; }

        public DbSet<Product> Products { get; set; }


        public DbSet<Type> Types { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

using InfraStructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Configration
{
    public class FavouriteProductsConfig : IEntityTypeConfiguration<FavouriteProduct>
    {
        public void Configure(EntityTypeBuilder<FavouriteProduct> builder)
        {
            //relation
            builder.HasKey(bc => new { bc.IdProduct, bc.IdUser });

            builder.HasOne(bc => bc.Product)
                .WithMany(b => b.FavouriteProducts)
                .HasForeignKey(bc => bc.IdProduct);
            builder.HasOne(bc => bc.User)
                .WithMany(c => c.FavouriteProducts)
                .HasForeignKey(bc => bc.IdUser);


        }
    
    }
}

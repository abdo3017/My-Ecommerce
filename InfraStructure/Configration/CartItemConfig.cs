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
    internal class CartItemConfig : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            //relation
            builder.HasKey(b => b.Id);
            builder.HasOne(c => c.User)
            .WithMany(e => e.CartItems).HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder
            .HasOne(c => c.Product)
            .WithMany(e => e.CartItems)
            .HasForeignKey(c => c.ProductId)
            .OnDelete(DeleteBehavior.Cascade);




        }
    }
}

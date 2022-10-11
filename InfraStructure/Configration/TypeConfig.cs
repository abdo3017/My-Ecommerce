using InfraStructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = InfraStructure.Entity.Type;

namespace InfraStructure.Configration
{
    public class TypeConfig : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            //relation
            builder.HasKey(b => b.Id);
            builder.HasMany(c => c.Products)
            .WithOne(e => e.Type)
            .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Category)
			.WithMany(e => e.Types)
			.HasForeignKey(c => c.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);



        }
    }
}

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
    public class CategoryTypeConfig : IEntityTypeConfiguration<CategoryType>
    {
        public void Configure(EntityTypeBuilder<CategoryType> builder)
        {
            //relation
            builder.HasKey(bc => new { bc.IdType, bc.IdCategory });
            builder.HasOne(bc => bc.Category)
                .WithMany(b => b.CategoryTypes)
                .HasForeignKey(bc => bc.IdCategory);
            builder.HasOne(bc => bc.Type)
                .WithMany(c => c.CategoryTypes)
                .HasForeignKey(bc => bc.IdType);


        }
    }
}

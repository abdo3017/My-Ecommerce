using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraStructure.Entity;

namespace InfraStructure.Configration
{
    public class BrandTypeConfig : IEntityTypeConfiguration<BrandType>
    {
        public void Configure(EntityTypeBuilder<BrandType> builder)
        {
            //relation
            builder.HasKey(bc => new { bc.IdType, bc.IdBrand });
            builder.HasOne(bc => bc.Brand)
                .WithMany(b => b.BrandTypes)
                .HasForeignKey(bc => bc.IdBrand);
            builder.HasOne(bc => bc.Type)
                .WithMany(c => c.BrandTypes)
                .HasForeignKey(bc => bc.IdType);


        }

    }
}

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
    internal class SizeConfig : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            //relation
            builder.HasKey(b => new { b.Id, b.IdProduct });
            builder
            .HasOne(c => c.Product)
            .WithMany(e => e.Sizes).HasForeignKey(c => c.IdProduct);
        }
    
    }
}

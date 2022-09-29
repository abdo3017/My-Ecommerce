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
    internal class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            //relation
            builder.HasKey(b => new { b.Id, b.IdProduct });
            builder
            .HasOne(c => c.Product)
            .WithMany(e => e.Images).HasForeignKey(c => c.IdProduct);
        }
    }
}

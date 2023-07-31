using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.ToTable("Provincia");
            builder.Property(r => r.Id)
                .HasColumnName("idProvincia");
            builder.Property(r => r.Nombre)
                .HasColumnName("nombreProvincia");
            builder.Property(r => r.Region)
                .HasColumnName("idRegion")
                .IsRequired();
            
            builder.HasOne(r => r.Region)
                .WithMany(r => r.Provincias)
                .HasForeignKey(r => r.IdRegion);
        }
    }
}
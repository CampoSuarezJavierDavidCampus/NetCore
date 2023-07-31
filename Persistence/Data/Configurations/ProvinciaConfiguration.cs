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
                .HasColumnName("idProvincia")
                .IsRequired()
                .HasMaxLength(12);


            builder.Property(r => r.Nombre)
                .HasColumnName("nombreProvincia")
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(r => r.Region)
                .HasColumnName("idRegion")
                .IsRequired()
                .HasMaxLength(12);
            
            builder.HasOne(r => r.Region)
                .WithMany(r => r.Provincias)
                .HasForeignKey(r => r.IdRegion);
        }
    }
}
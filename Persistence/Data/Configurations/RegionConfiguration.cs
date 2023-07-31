using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Region");
        builder.Property(r => r.Id)
            .HasColumnName("idRegion");
        builder.Property(r => r.Nombre)
            .HasColumnName("nombreRegion");
        builder.Property(r => r.IdPais)
            .HasColumnName("idPais")
            .IsRequired();
        
        builder.HasOne(r => r.Pais)
            .WithMany(r => r.Regions)
            .HasForeignKey(r => r.IdPais);
    }
}
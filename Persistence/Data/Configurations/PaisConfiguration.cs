using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais");
        builder.Property(m => m.Id)
            .HasColumnName("idPais");
        builder.Property(m => m.Nombre)
            .IsRequired()
            .HasColumnName("nombrePais");        
    }
}
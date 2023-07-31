using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marca");
        builder.Property(m => m.Id)
            .HasColumnName("idMarca");
        builder.Property(m => m.Descipcion)
            .HasColumnName("idDescipcion");
    }
}
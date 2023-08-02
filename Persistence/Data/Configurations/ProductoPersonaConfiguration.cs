using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ProductoPersonaConfiguration : IEntityTypeConfiguration<PersonaProducto>
{
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        builder.ToTable("ProductoPersona");
        builder.Property(pp => pp.IdProducto)
            .HasColumnName("idProducto")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(pp => pp.IdPersona)
            .HasColumnName("idPersona")
            .IsRequired()
            .HasMaxLength(12);

        builder.HasOne(pp => pp.Producto)
            .WithMany(p => p.PersonaProductos)
            .HasForeignKey(p => p.IdProducto);

        builder.HasOne(pp => pp.Persona)
            .WithMany(p => p.PersonaProductos)
            .HasForeignKey(p => p.IdPersona);
    }
}
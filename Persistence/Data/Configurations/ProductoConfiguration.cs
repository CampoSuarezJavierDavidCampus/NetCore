using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Producto");
        builder.Property(p => p.Id)
            .IsRequired()
            .HasColumnName("idProducto");
        builder.Property(p => p.Descipcion)
            .IsRequired()
            .HasColumnName("DescipcionProducto");
        builder.Property(p => p.IdMarca)
            .IsRequired()
            .HasColumnName("IdMarca");

        builder.HasOne(p => p.Marca)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdMarca);

    }
}
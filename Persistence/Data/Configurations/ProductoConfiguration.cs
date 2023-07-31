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
            .HasColumnName("idProducto")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(p => p.Descipcion)
            .HasColumnName("DescipcionProducto")
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);

        builder.Property(p => p.IdMarca)            
            .HasColumnName("IdMarca")
            .IsRequired()
            .HasMaxLength(12);;

        builder.HasOne(p => p.Marca)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdMarca);

    }
}
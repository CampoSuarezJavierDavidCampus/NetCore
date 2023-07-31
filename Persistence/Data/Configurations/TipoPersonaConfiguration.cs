using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("TipoPersona");
        builder.Property(tp => tp.Id)
            .IsRequired()
            .HasColumnName("idTIpoPersona");
        builder.Property(tp => tp.Descipcion)
            .IsRequired()
            .HasColumnName("desciptionTIpoPersona");
    }
}
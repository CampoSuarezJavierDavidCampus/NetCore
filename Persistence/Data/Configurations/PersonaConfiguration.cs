using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
            builder.Property(p => p.Id)
                .HasColumnName("idPersona")
                .IsRequired();
            builder.Property(p => p.Nombre)
                .HasColumnName("nombrePersona")
                .IsRequired();
            builder.Property(p => p.Apellido)
                .HasColumnName("apellidoPersona")
                .IsRequired();
            builder.Property(p => p.Edad)
                .HasColumnName("edadPersona");
            builder.Property(p => p.Edad)
                .HasColumnName("edadPersona");
            builder.Property(p => p.IdProvincia)
                .HasColumnName("idProv")
                .IsRequired();                
            builder.Property(p => p.IdTipoPersona)
                .HasColumnName("idTipPer")
                .IsRequired();
            builder.HasOne(p => p.Provincia)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdProvincia);
            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoPersona);
        }
    }
}
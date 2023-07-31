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
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(p => p.Nombre)
                .HasColumnName("nombrePersona")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();;

            builder.Property(p => p.Apellido)
                .HasColumnName("apellidoPersona")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();;

            builder.Property(p => p.Edad)
                .HasColumnName("edadPersona")                
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .HasColumnName("idProv")                
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(p => p.IdTipoPersona)
                .HasColumnName("idTipPer")
                .HasMaxLength(12)
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
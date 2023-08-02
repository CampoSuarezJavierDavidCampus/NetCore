namespace Domain.Entity;
public class TipoPersona:EntityGenericA{
    public ICollection<Persona>? Personas { get; set; }
}
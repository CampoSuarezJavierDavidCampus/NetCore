namespace Domain.Entity;
public class Provincia:EntityGenericB{ 
    public int IdRegion { get; set;}
    public Region? Region { get; set; }

    public ICollection<Persona>? Personas { get; set; }
}
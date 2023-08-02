namespace Domain.Entity;
public class Pais:EntityGenericB{
    public ICollection<Region>? Regions { get; set; }
}
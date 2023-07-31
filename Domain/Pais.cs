namespace Domain;
public class Pais:EntityGenericB{
    public ICollection<Region>? Regions { get; set; }
}
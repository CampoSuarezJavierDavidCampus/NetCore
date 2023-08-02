namespace Domain.Entity;
public class Region:EntityGenericB{
    public int IdPais { get; set;} 
    public Pais? Pais { get; set; }

    public ICollection<Provincia>? Provincias { get; set; }
}
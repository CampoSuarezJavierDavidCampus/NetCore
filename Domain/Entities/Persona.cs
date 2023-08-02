namespace Domain.Entity;
public class Persona:EntityGenericB{
    public string? Apellido { get; set;}    
    public int Edad { get; set;}    

    public int IdProvincia { get; set;}        
    public Provincia? Provincia { get; set; }

    public int IdTipoPersona { get; set;}    
    public TipoPersona? TipoPersona { get; set; }
    

    public ICollection<PersonaProducto>? PersonaProductos { get; set; }

}
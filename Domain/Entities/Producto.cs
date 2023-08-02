namespace Domain.Entity;
public class Producto:EntityGenericA{ 
    public string? Referencia { get; set;}            
    public double? Precio { get; set;}

    public int? IdMarca { get; set;}
    public Marca? Marca { get; set; }


    public ICollection<PersonaProducto>? PersonaProductos { get; set; }
}
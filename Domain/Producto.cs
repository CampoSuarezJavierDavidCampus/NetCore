namespace Domain;
public class Producto:EntityGenericA{ 
    public string? Referencia { get; set;}            
    public double? Precio { get; set;}

    public double? IdMarca { get; set;}
    public Marca? Marca { get; set; }


    public ICollection<PersonaProducto>? PersonaProductos { get; set; }
}
namespace Domain;
public class Marca:EntityGenericA{
    public ICollection<Producto>? Productos { get; set; }
}
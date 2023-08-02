namespace Domain.Entity;
public class Marca:EntityGenericA{
    public ICollection<Producto>? Productos { get; set; }
}
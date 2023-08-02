using Aplicacion.Repository;
using Domain.Entity;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class PaisRepository : GenericRepository<Pais>, IPais
{    
    public PaisRepository(ShopContext context) : base(context){}
}

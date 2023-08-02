using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.Model.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private PaisRepository _pais = null!;
    private readonly ShopContext _context;

    public UnitOfWork(ShopContext context)=>_context = context;

    //public IPais Paises => _pais??=new(_context);
    public IPais Paises{
        get{ 
            if (_pais is null)
            {
                _pais = new(_context);
            }
            return _pais;
        }
    }
}

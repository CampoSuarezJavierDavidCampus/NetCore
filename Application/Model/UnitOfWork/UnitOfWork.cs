using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.Model.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private PaisRepository _pais = null!;
    private readonly ShopContext _context;

    public UnitOfWork(ShopContext context)=>_context = context;

    public IPais Paises => _pais??=new(_context);
}

using MediatR;
using Domain.Entity;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Model;
public class Consultas{
    public class ListaPais : IRequest<List<Pais>>{}
    public class Manejador: IRequestHandler<ListaPais,List<Pais>>{
        private readonly ShopContext _context;
        public Manejador(ShopContext context)=>_context = context;        
        public async Task<List<Pais>> Handle(ListaPais request, CancellationToken cancellationToken)
        {
            var paises = await _context.Paises.ToListAsync(cancellationToken: cancellationToken);
            return paises;
        }
    }
}
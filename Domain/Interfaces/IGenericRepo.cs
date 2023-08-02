using System.Linq.Expressions;
using Domain.Entity;

namespace Domain.Interfaces;
public interface IGenericRepo<T> where T: EntityGenericC{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    IEnumerable<T> Find(Expression<Func<T,bool>> expression);

    void Add(T Entity);
    void AddRange(IEnumerable<T> Entities);

    void Remove(T Entity);
    void RemoveRange(IEnumerable<T> Entities);

    void Update(T Entity);
}
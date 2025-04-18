using System.Linq.Expressions;

namespace TermsManagement.Domain.Repository;

public interface IGenericRepository<TKey, T> where T : class
{
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression);
    T GetById(TKey id);
    bool Create(T Entity);
    bool Delete(T Entity);
    bool ExistBy(Expression<Func<T, bool>> expression);
    bool Save();
}

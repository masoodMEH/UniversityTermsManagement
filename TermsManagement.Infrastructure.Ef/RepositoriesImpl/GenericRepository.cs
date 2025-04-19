using System.Linq.Expressions;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

public class GenericRepository<TKey, T> : IGenericRepository<TKey, T> where T : class
{
    private readonly TermsManagement_Context _context;

    public GenericRepository(TermsManagement_Context context)
    {
        _context = context;
    }

    public bool Create(T Entity)
    {
        _context.Add(Entity);
        return Save();
    }

    public bool Delete(T Entity)
    {
        _context.Remove<T>(Entity);
        return Save();
    }

    public bool ExistBy(Expression<Func<T, bool>> expression) =>
        _context.Set<T>().Any(expression);

    public IEnumerable<T> GetAll() =>
        _context.Set<T>().ToList();

    public IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression) =>
        _context.Set<T>().Where(expression).ToList();

    public IQueryable<T> GetAllQuery() =>
        _context.Set<T>();

    public IQueryable<T> GetAllByQuery(Expression<Func<T, bool>> expression) =>
        _context.Set<T>().Where(expression);

    public T GetById(TKey id) =>
        _context.Find<T>(id);

    public bool Save() =>
        _context.SaveChanges() >= 0 ? true : false;
}
using System.Linq.Expressions;

namespace SoftX.Facade.Repository;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    TEntity Get(object id);
    IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    IQueryable<TEntity> SelectAll();
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(object id);
    void Delete(TEntity entity);
    int SaveChanges();
}

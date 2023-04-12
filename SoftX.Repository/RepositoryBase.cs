using Microsoft.EntityFrameworkCore;
using SoftX.Facade.Repository;
using SoftX.Repository.Date;
using System.Linq.Expressions;

namespace SoftX.Repository;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    protected readonly SoftXDbContext _context;

    protected RepositoryBase(SoftXDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        //_context.Database.EnsureCreated();
    }

    public virtual TEntity Get(object id) =>
        _context.Set<TEntity>().Find(id) ?? throw new KeyNotFoundException($"Record with key {id} not found");

    public virtual IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate) =>
        _context.Set<TEntity>().Where(predicate);

    public virtual IQueryable<TEntity> SelectAll() =>
        _context.Set<TEntity>();

    public virtual void Insert(TEntity entity) =>
        _context.Add(entity);

    public virtual void Update(TEntity entity)
    {
        _context.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public virtual void Delete(object id) =>
        Delete(Get(id));

    public virtual void Delete(TEntity entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            _context.Attach(entity);
        }
        _context.Remove(entity);
    }

    public int SaveChanges() =>
        _context.SaveChanges();
}

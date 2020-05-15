using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity<int>;
        int SaveChanges();
    }
}

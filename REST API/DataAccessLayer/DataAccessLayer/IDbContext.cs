using DataAccessLayer.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataAccessLayer
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity<int>;
        int SaveChanges();
    }
}

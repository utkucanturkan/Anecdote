using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContext context;
        private Dictionary<Type, dynamic> repositories;
        private bool disposed;

        public UnitOfWork(IDbContext _context)
        {
            context = _context;
            repositories = new Dictionary<Type, dynamic>();
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity<int>
        {
            return new Repository<TEntity>(context);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (context != null)
                    {
                        context.Dispose();
                        context = null;
                    }

                    if (repositories != null)
                        repositories = null;
                }
                disposed = true;
            }
        }
    }
}

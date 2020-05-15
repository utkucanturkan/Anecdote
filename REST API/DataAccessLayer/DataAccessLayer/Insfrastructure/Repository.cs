using DataAccessLayer.Entities;
using Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Insfrastructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly IDbContext context;
        protected readonly DbSet<TEntity> dbSet;

        protected const int TakedItemCount = 30;

        public Repository(IDbContext _context)
        {
            context = _context;
            dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(int id) { }

        public virtual void Update(TEntity entity) { }

        public TEntity Get(int id)
        {
            TEntity entity = dbSet.Where(x => x.Id == id).FirstOrDefault();
            if (entity == null)
            {
                throw new AnecdoteException(string.Format("Entity was not found with this '{0}'", id), System.Net.HttpStatusCode.NotFound);
            }
            return entity;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).AsEnumerable();
        }
    }
}

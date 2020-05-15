using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Insfrastructure
{
    public interface IRepository<TEntity> where TEntity : BaseEntity<int>
    {

        TEntity Get(int id);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}

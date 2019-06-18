using DAL.Models.Interfaces;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SoftDeleteRepository<TEntity> : Repository<TEntity> where TEntity : class, ISoftDeleteEntity
    {
        public SoftDeleteRepository(DbContext context) 
            : base(context)
        {
        }

        public override void Add(TEntity entity)
        {
            entity.IsDeleted = false;
            _entities.Add(entity);
        }

        public Task AddAsync(TEntity entity)
        {
            entity.IsDeleted = false;
            return _entities.AddAsync(entity);
        }

        public override void AddRange(IEnumerable<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.IsDeleted = false;
            }
            _entities.AddRange(entities);
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.IsDeleted = false;
            }
            return _entities.AddRangeAsync(entities);
        }


        public override void Remove(TEntity entity)
        {
            entity.IsDeleted = true;
            _entities.Update(entity);
        }

        public override void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.IsDeleted = true;
            }
            _entities.UpdateRange(entities);
        }
    }
}
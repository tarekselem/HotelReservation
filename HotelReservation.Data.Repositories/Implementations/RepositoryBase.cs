using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelReservation.Data.Common;

namespace HotelReservation.Data.Repositories.Implementations
{
    public class RepositoryBase<TEntity> : IRepository<TEntity>
    {
        public void Dispose()
        {
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, IList<Expression<Func<TEntity, object>>> includedProperties = null, int? pageIndex = null,
            int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, IList<Expression<Func<TEntity, object>>> includedProperties = null, int? pageIndex = null,
            int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsyncById(object id)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> BulkInsert(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<TEntity, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public void BulkDelete(IQueryable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Detach(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

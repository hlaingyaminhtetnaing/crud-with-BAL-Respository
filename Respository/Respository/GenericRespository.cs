using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebapiThetys.Model;

namespace WebapiThetys.Respository
{
    public class GenericRespository<TEntity> : IGenericRespository<TEntity> where TEntity : class
    {
        private readonly ShoppingDBContext _dBContext;

        public GenericRespository(ShoppingDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<bool> Create(TEntity entity)
        {
            try
            {
                await _dBContext.Set<TEntity>().AddAsync(entity);
                _dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var entity = await GetById(id);
                _dBContext.Set<TEntity>().Remove(entity);
                _dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<TEntity> Get()
        {
            return _dBContext.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> GetByExp(Expression<Func<TEntity, bool>> predicate)
        {
            return _dBContext.Set<TEntity>().Where(predicate).AsNoTracking();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return  _dBContext.Set<TEntity>().Find(id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            try
            {
               _dBContext.Set<TEntity>().Update(entity);
               _dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebapiThetys.Respository;

namespace WebapiThetys.BAL
{
    public class GenericBAL<TEntity> : IGenericBAL<TEntity> where TEntity : class
    {
        private readonly IGenericRespository<TEntity> _genericRespository;
        public GenericBAL(IGenericRespository<TEntity> genericRespository) 
        {
            _genericRespository = genericRespository;
        }
        public Task<bool> Create(TEntity entity)
        {
            try
            {
                return _genericRespository.Create(entity);
            }
            catch
            {
                throw;
            }
        }

        public Task<bool> Delete(Guid id)
        {
            try
            {
                return _genericRespository.Delete(id);
            }
            catch
            {
                throw;
            }
        }

        public IQueryable<TEntity> Get()
        {
            try
            {
                return _genericRespository.Get();
            }
            catch
            {
                throw;
            }
        }

        public Task<TEntity> GetByExp(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(Guid id)
        {
            try
            {
                return _genericRespository.GetById(id);
            }
            catch
            {
                throw;
            }
        }

        public Task<bool> Update(TEntity entity)
        {
            try
            {
                return _genericRespository.Update(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}

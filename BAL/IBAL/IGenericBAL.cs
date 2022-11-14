using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebapiThetys.BAL
{
   public interface IGenericBAL<TEntity> where TEntity:class
    {
        IQueryable<TEntity> Get();
        Task<TEntity> GetById(Guid id);
        Task<bool> Create(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<bool> Update(TEntity entity);
        
    }
}

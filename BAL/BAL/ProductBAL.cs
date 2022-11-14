using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebapiThetys.Model;
using WebapiThetys.Respository;

namespace WebapiThetys.BAL
{
    public class ProductBAL : GenericBAL<Products>, IProductBAL
    {
        private readonly IGenericRespository<Products> _genericRespository;
        public ProductBAL(IGenericRespository<Products> genericRespository)
            :base(genericRespository)
        {
            _genericRespository = genericRespository;
        }
        public async Task<bool> AddProduct(Products entity)
        {
            
            var result = await _genericRespository.Create(entity);
            return result;
        }

        public IQueryable<Products> GetAll()
        {
            var result = _genericRespository.Get();
            return result;
        }

        public IQueryable<Products> GetID(Guid id)
        {
            var result = _genericRespository.GetByExp(x => x.Id == id);
            return result;
        }

        public async Task<bool> Modify(Products entity)
        {
            var result = await _genericRespository.Update(entity);
            return result;
        }

        public async Task<bool> Remove(Guid id)
        {
            var result =await _genericRespository.Delete(id);
            return result;
        }
    }
}

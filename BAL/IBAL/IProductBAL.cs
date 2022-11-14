using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebapiThetys.Model;

namespace WebapiThetys.BAL
{
    public interface IProductBAL:IGenericBAL<Products>
    {
        IQueryable<Products> GetAll();
        IQueryable<Products> GetID(Guid id);
        Task<bool> AddProduct(Products entity);
        Task<bool> Remove(Guid id);
        Task<bool> Modify(Products entity);
    }
}

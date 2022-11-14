using System;
using System.Collections.Generic;
using System.Text;
using WebapiThetys.Model;

namespace WebapiThetys.Respository
{
    public class ProductRespository : GenericRespository<Products>,IProductRespository
    {
        private readonly ShoppingDBContext _dBContext;
        public ProductRespository(ShoppingDBContext dBContext):base(dBContext)
        {
            _dBContext = dBContext;
        }
    }
}

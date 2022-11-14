using System;
using System.Collections.Generic;
using System.Text;
using WebapiThetys.Model;

namespace WebapiThetys.Respository
{
   public class ItemRespository:GenericRespository<Item>,IItemRespository
    {
        public readonly ShoppingDBContext _dBContext;
        public ItemRespository(ShoppingDBContext dBContext):base(dBContext)
        {
            _dBContext = dBContext;
        }
    }
}

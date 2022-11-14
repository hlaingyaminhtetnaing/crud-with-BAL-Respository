using System;
using System.Collections.Generic;

namespace WebapiThetys.Model
{
    public partial class Products
    {
        public Guid Id { get; set; }
        public string Pname { get; set; }
        public string Pcategory { get; set; }
        public int? Price { get; set; }
        public string Details { get; set; }
    }
    public class ProductRequest {
        public string Pname { get; set; }
        public string Pcategory { get; set; }
        public int? Price { get; set; }
        public string Details { get; set; }
    }

}

using System;
using System.Collections.Generic;

namespace WebapiThetys.Model
{
    public partial class Item
    {
        public Guid Id { get; set; }
        public string Iname { get; set; }
        public string Icategory { get; set; }
        public int? Iprice { get; set; }
        public string Idetails { get; set; }
    }
}

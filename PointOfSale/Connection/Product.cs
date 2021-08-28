using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Connection
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public float QuantityStorage { get; set; }
        public string ProductBrand { get; set; }
        public string ProductFamily { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubCategory { get; set; }
        public DateTime Creation { get; set; }
        public int UserID { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool ProductActive { get; set; }
    }
}

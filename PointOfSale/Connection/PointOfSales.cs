using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Connection
{
    public class PointOfSales
    {
        public int ID { get; set; }
        public float SalePrice { get; set; }
        public float SalePayPrice { get; set; }
        public float SaleChange { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserID { get; set; }
        public int SaleCutID { get; set; }
    }

    public class PointOfSale_Product
    {
        public int ID { get; set; }
        public int PoSID { get; set; }
        public int ProductID { get; set; }
        public int ProductQty { get; set; }
        public float ProductsPrices { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class Data
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public int Avaible { get; set; }
        public int Used { get; set; }
        public DateTime Creation { get; set; }
        public DateTime LastPay { get; set; }
    }
}

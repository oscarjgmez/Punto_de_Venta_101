using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Connection
{
    public class CutSale
    {
        public int ID { get; set; }
        //Pesos
        public int AmountBills1000p { get; set; }
        public int AmountBills500p { get; set; }
        public int AmountBills200p { get; set; }
        public int AmountBills100p { get; set; }
        public int AmountBills50p { get; set; }
        public int AmountBills20p { get; set; }
        public int AmountCoins100p { get; set; }
        public int AmountCoins20p { get; set; }
        public int AmountCoins10p { get; set; }
        public int AmountCoins5p { get; set; }
        public int AmountCoins2p { get; set; }
        public int AmountCoins1p { get; set; }
        public int AmountCoins50cp { get; set; }
        //Dollars
        public int AmountBills100d { get; set; }
        public int AmountBills50d { get; set; }
        public int AmountBills20d { get; set; }
        public int AmountBills10d { get; set; }
        public int AmountBills5d { get; set; }
        public int AmountBills2d { get; set; }
        public int AmountBills1d { get; set; }
        public int AmountCoins1000d { get; set; }
        public int AmountCoins50d { get; set; }
        public int AmountCoins25d { get; set; }
        public int AmountCoins10d { get; set; }
        public int AmountCoins5d { get; set; }
        public int AmountCoins1d { get; set; }
        public DateTime CutDate { get; set; }
        public double totalD {get;set;}
        public double totalP {get;set; }
        public int UserID { get; set; }
    }
}

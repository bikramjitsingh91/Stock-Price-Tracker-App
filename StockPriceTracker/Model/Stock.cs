using System;
using System.Collections.Generic;
using System.Text;

namespace StockPriceTracker.Model
{
    public class Stock
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double MaxPrice { get; set; }
        public double MinPrice { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StockPriceTracker.Model
{
    public class StockEventArgs : EventArgs
    {
        public Stock stock { get; set; }
        public DateTime timeChanged { get; set; }
    }
}

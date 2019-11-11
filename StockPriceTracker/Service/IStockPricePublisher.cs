using StockPriceTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockPriceTracker.Service
{
    public interface IStockPricePublisher
    {
        event EventHandler<StockEventArgs> StockPricePublished;
        void PublishStockPrice(Stock stock);
    }
}

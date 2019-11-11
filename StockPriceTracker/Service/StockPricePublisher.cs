using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using StockPriceTracker.Model;

namespace StockPriceTracker.Service
{
    public class StockPricePublisher : IStockPricePublisher
    {
        public event EventHandler<StockEventArgs> StockPricePublished;

        public void PublishStockPrice(Stock stock)
        {
            while (true)
            {
                Thread.Sleep(1500);
                Random random = new Random();
                stock.CurrentPrice = random.NextDouble() * (stock.MaxPrice - stock.MinPrice) + stock.MinPrice;
                onStockPricePublished(stock, DateTime.Now);
            }
        }

        protected virtual void onStockPricePublished(Stock stock, DateTime dateTime)
        {
            if (StockPricePublished != null)
            {
                StockPricePublished(this, new StockEventArgs() { stock = stock, timeChanged = dateTime });
            }
        }
    }
}

using StockPriceTracker.ClientModule;
using StockPriceTracker.Model;
using StockPriceTracker.Service;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StockPriceTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            StockPriceSubscribe spSubscribe = new StockPriceSubscribe(new StockPricePublisher(), new Stock
            {
                Name = "Stock1",
                CurrentPrice = 240,
                MaxPrice = 240,
                MinPrice = 270
            });

            StockPriceSubscribe spSubscribe2 = new StockPriceSubscribe(new StockPricePublisher(), new Stock
            {
                Name = "Stock2",
                CurrentPrice = 180,
                MaxPrice = 180,
                MinPrice = 210
            });

            Task.Run(() => spSubscribe.Subscribe());

            Task.Run(() => spSubscribe2.Subscribe());

            Thread.Sleep(4500);
            spSubscribe.Unsubscribe();
            Thread.Sleep(2500);
            spSubscribe2.Unsubscribe();

        }
    }
}

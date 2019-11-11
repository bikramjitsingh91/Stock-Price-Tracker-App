using StockPriceTracker.Model;
using StockPriceTracker.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockPriceTracker.ClientModule
{
    public class StockPriceSubscribe
    {
        private IStockPricePublisher _stockPricePublisher;
        private Stock _stock;

        public StockPriceSubscribe(IStockPricePublisher stockPricePublisher, Stock stock)
        {
            _stockPricePublisher = stockPricePublisher;
            _stock = stock;
        }

        public void Subscribe()
        {
            _stockPricePublisher.StockPricePublished += StockPricePublished;
            _stockPricePublisher.PublishStockPrice(_stock);
        }

        public void Unsubscribe()
        {
            Console.WriteLine("Unsubscribing for {0}", _stock.Name);
            _stockPricePublisher.StockPricePublished -= StockPricePublished;
        }

        public void StockPricePublished(Object source, StockEventArgs e)
        {
            Console.WriteLine("Stock price changed, Stock price of {0} is {1} at {2}", e.stock.Name, e.stock.CurrentPrice, e.timeChanged);
        }
    }
}

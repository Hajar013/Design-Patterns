using System;

namespace Observer
{
    public class PriceChangedEventArgs : EventArgs
    {
        public string Symbol { get; }
        public double Price { get; }

        public PriceChangedEventArgs(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }
    }
}


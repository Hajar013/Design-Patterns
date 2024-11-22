using System;
using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Stock_D
    {
        private string symbol;
        private double price;
        //1
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        //

        private List<IInvestor_D> investors = new List<IInvestor_D>();
        // Constructor
        public Stock_D(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }
      
        // Gets or sets the price
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    //2
                    OnPriceChanged(new PriceChangedEventArgs(symbol, price));
                }
            }
        }
        //3
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        // Gets the symbol
        public string Symbol
        {
            get { return symbol; }
        }
    }
}


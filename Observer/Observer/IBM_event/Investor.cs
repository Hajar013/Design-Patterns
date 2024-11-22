using System;
using System.Globalization;

namespace Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    
        public class Investor_D:IInvestor_D
        {
            private string name;

            public Investor_D(string name)
            {
                this.name = name;
            }

            public void OnPriceChanged(object sender, PriceChangedEventArgs e)
            {
                Console.WriteLine("Notified {0} of {1}'s change to {2:C}", name, e.Symbol, e.Price);
            }

        
    }
}



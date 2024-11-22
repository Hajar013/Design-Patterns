
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            IInvestor investor1 = new Investor("Sorros");
            IInvestor investor2 = new Investor("Berkshire");

            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(investor1);
            ibm.Attach(investor2);

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            //
            Console.WriteLine( "===============================" );

            ibm.Detach(investor2);
            ibm.Price = 120.50;
            ibm.Price = 120.75;*/

            //==================================================================

            // Create IBM stock and attach investors
            IBM_D ibm = new IBM_D("IBM", 120.00);

            Investor_D sorros = new Investor_D("Sorros");
            Investor_D berkshire = new Investor_D("Berkshire");

            ibm.PriceChanged += sorros.OnPriceChanged;
            ibm.PriceChanged += berkshire.OnPriceChanged;

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

        }
        }
}


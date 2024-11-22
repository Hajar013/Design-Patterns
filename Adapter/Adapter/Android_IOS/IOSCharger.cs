using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class IOSCharger : iIOS
    {
        public void Charge()
        {
            Console.WriteLine("IOS Charger");
        }
    }
}
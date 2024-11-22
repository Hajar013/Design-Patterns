using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class AndeoidCharger : iAndroid
    {
        public void Charge()
        {
            Console.WriteLine("Android Charger");
            
        }
    }
}
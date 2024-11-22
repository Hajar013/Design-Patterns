using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.after
{ 
    public class IceCreamWithFruitMix : IceCream
    {
        public override string Description => $"{base.Description} + Fruit Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .60m;
    }
}
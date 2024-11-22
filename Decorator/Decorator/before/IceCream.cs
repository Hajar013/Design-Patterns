using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.before
{
    public class IceCream
    {
        public virtual string Description => "Ice cream";
        public virtual decimal CalculateCost() => 3.5m;

        public override string ToString()
        {
            return $"{Description} (${CalculateCost().ToString()})";
        }
    }
}

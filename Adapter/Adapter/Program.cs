using Adapter.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // The Client Code

             LegacySorter legacySorter=new LegacySorter();
             // Let's add a couple circles to our Legacy Sorter.
             legacySorter.AddSortedItem(new Circle(5));
             legacySorter.AddSortedItem(new Circle(2));

             // Create our adaptee object.
             Square square = new Square(6);

             // Adapt our square to the iCircle interface.
             iCircle adaptedSquare = new SquareAdapter(square);

             // And finally, we can now add our square to the legacy item sorter.
             legacySorter.AddSortedItem(adaptedSquare);*/

            //----------------------------------------------------

            //charge ios use Android Charger
            Adapter_IOS_From_Android adapter_IOS_From_Android = new Adapter_IOS_From_Android(new AndeoidCharger());
            adapter_IOS_From_Android.Charge();
        }
    }
}

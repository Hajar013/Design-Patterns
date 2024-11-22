using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Problem
{
     class LegacySorter
    {
        static List<iCircle> _circles = new List<iCircle>();
        public  List<iCircle> Circles => _circles;
        public  void AddSortedItem(iCircle circle)
        {
            _circles.Add(circle);
            _circles = _circles.OrderBy(o => o.Radius).ToList();
            printList();
        }
        static void printList()
        {
            StringBuilder strBuilder = new StringBuilder();
            foreach (iCircle circle in _circles)
            {
                strBuilder.Append($"{circle.Radius},");
            }
            Console.WriteLine(strBuilder);
        }
    }

}

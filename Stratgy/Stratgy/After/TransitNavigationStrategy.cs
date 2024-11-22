using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After
{

    public class TransitNavigationStrategy : INavigationStrategy
    {
        public Route Navigate(string origin, string destination)
        {
            // complex logic to find the shortest path for the selected mode
            return new Route
            {
                Title = "Greyhound",
                DistanceInKM = 598,
                Duration = TimeSpan.FromHours(9).Add(TimeSpan.FromMinutes(20)),
                Directions = new List<string>()
            {
                origin,
                "Montreal Greyhound",
                "Port Authority Bus Terminal (9 hr 20 min)",
                destination
            }
            };
        }
    }
}

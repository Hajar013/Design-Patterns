using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After
{
    public class FlightNavigationStrategy : INavigationStrategy
    {
        public Route Navigate(string origin, string destination)
        {
            // complex logic to find the shortest path for the selected mode
            return new Route
            {
                Title = "Montreal QC - NEW York, USA",
                DistanceInKM = 538,
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(20)),
                Directions = new List<string>()
            {
                origin,
                "Montréal-Pierre Elliott Trudeau International Airport (YUL)",
                "John F. Kennedy International Airport (JFK)",
                destination
            }
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After
{

    public class NavigationContext
    {
        private INavigationStrategy _navigationStrategy;

        public NavigationContext(INavigationStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy;
        }

        public void SwitchNavigationStrategy(INavigationStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy;
        }

        public Route Navigate(string origin, string destination)
        {
            return _navigationStrategy.Navigate(origin, destination);
        }
    }
}

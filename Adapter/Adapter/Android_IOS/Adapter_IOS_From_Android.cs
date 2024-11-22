using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Adapter_IOS_From_Android : iIOS
    {
        private AndeoidCharger andeoidCharger;
        public Adapter_IOS_From_Android(AndeoidCharger andeoidCharger) { 
        this.andeoidCharger= andeoidCharger;
        }
        public void Charge()
        {
            andeoidCharger.Charge();
        }
    }
}
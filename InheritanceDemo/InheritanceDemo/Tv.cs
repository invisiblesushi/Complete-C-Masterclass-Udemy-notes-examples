using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Tv : ElectricalDevice
    {

        public Tv(bool isOn, string brand):base(isOn, brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }



        //Method listen to radio
        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching Tv");
            }
            else
            {
                Console.WriteLine("Tv is off");
            }
        }
    }
}

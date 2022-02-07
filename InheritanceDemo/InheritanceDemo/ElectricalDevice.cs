using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //Parent class - Base class
    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //Method switch on/off radio
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}

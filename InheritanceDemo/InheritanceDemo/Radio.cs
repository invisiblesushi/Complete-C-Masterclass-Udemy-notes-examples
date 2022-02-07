using System;

namespace InheritanceDemo
{
    // Child class
    class Radio : ElectricalDevice
    {
        //Pass it over to electricaldevice prop 
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        //Method listen to radio
        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off");
            }
        }

    }
}

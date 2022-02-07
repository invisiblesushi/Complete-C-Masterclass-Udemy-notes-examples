using System;
using System.Collections.Generic;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };


            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIdInfo(1234, "Dennis");
            audiA3.SetCarIdInfo(1235, "Frank");
            bmwZ3.GetCarIdInfo();
            audiA3.GetCarIdInfo();

            BMW bmwM5 = new BMW(330, "White", "M5");
            bmwM5.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo whatever");
            myM3.Repair();

        }
    }
}

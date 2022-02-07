using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    //Sealed class seals the class for further inheritance
    //sealed class BMW : Car

    //a BMW is a Car
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        //Constructor that uses base constructor of base Car
        public BMW(int hp, string color, string model):base(hp, color)
        {
            //this.HP = hp;
            //this.Color = color;
            this.Model = model;
        }



        // new does not override, but prioritizes it
        // If create object of BMW, use new method, else use method of car
        public new void ShowDetails()
        {
            Console.WriteLine("Brand {2} Hp : {0}, Color : {1}", HP, Color, brand);
        }

        // can only seal override methods, not virtual methods
        public sealed override void Repair()
        {
            Console.WriteLine("Thge BMW {0} was repaired", Model);
        }


    }
}

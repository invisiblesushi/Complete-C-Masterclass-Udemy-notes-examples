using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        //Constructor that uses base constructor of base Car
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            //this.HP = hp;
            //this.Color = color;
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand {2} Hp : {0}, Color : {1}", HP, Color, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("Thge Audi {0} was repaired", Model);
        }
    }
}

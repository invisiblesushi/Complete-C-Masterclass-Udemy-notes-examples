using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Chair : Furniture, IDestroyable
    {

        public string DestructionSound { get; set;}

        public Chair(string color, string material) {
            this.Color = color;
            this.Color = material;

            //
            DestructionSound = "ChariDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine("The {0} chair was destroyed", Color);
            Console.WriteLine("Playing sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");


        }



    }
}

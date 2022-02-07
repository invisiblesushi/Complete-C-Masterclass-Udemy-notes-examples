using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            //initialize the interfaces property with a value in constructor
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        //Implement interfaces method
        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            //Go through each destroyable objet nearby and vall its destroy method
            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }


    }
}

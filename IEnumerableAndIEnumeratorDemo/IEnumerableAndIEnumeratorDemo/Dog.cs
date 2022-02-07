using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberofTreats);
        }


    }
}

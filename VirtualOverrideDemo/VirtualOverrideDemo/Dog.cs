using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age){
            IsHappy = true;
        }

        // Override of the virtual method Eat
        public override void Eat()
        {
            // To call eat method from base class
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf!.");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }

    }
}

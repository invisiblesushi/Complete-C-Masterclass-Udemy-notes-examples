using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
 * The abstract modifier can be used with classes, methods, properties, indexers, and events. 
 * Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, 
 * not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.
 */
namespace AbstractClassesC
{
    abstract class Shape
    {
        public string Name { get; set; }


        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        //Not going to implement it here
        //Once a class wants to inherit from Shape it need to implement a functionality for Volume()
        public abstract double Volume();

    }
}

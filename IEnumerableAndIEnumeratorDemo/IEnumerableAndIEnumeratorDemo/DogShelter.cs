using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    //Class DogShelter class contains a generic collection fo type Dog
    //objects of this class cant be used inside a for each loop because it lacks an implementation of the IEnumerable itnerface
    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            //Init the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        //Gerneric
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            //throw new NotImplementedException();
            return dogs.GetEnumerator();
        }

        //Non generic
        //Need to implement, even when not in use
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

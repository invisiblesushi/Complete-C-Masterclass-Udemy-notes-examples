using System;

namespace IEnumerableAndIEnumeratorDemo
{
    class Program
    {
        // 1.IEnumerable <T> for generic collecitons : List<T>, Dictionary<T>, Queue<T>, Stack<T> etc...
        // 2.IEnumerable for non generic collections : ArrayList, SortedList, Stack, Queue etc...


        /// <summary>
        /// IEnumerable contains a single method that you must implement when implementing this interface
        /// GetEnumerable(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property thet points at the object we are currently at in the collection
        /// </summary>
        /// 

        // When it is reccommended to use the IEnumerable interface


        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }
}

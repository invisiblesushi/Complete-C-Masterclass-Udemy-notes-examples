using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring arraylist with undefined amount of object
            ArrayList myArrayList = new ArrayList();

            //Declaring arraylist with defiend amount of object
            ArrayList arrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            //delete element with spesific value (only first occurance will be deleted)
            myArrayList.Remove(13);

            //delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine("ArrayList count: {0}", myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToInt32(obj);
                }
                else if(obj is double){
                    
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);


        }
    }
}

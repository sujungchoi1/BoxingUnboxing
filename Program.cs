using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<object> newObj = new List<object>();
            newObj.Add(7);
            newObj.Add(28);
            newObj.Add(-1);
            newObj.Add(true);
            newObj.Add("chair");

            // iterate using type inference
            foreach (var entry in newObj)
            {
                Console.WriteLine(entry);
            }
            
            // Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (var entry in newObj)
            {
                if (entry is int)
                {
                    sum = sum + (int)entry;
                }
            }
            Console.WriteLine(sum);
        }   

    }
}


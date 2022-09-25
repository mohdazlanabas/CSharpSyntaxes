using System;

namespace AlgoSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // not specific to a particular data type
            // add <T> to: classes, methids, fields, etc
            // allow for code reusablity for diff data type

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.2, 2.2, 3.3 };
            string[] stringArray = { "A", "B", "C" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

        }
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
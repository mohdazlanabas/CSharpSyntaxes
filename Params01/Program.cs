using System.Security.AccessControl;

namespace Params01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            UseParams1(1, 2, 3, 4);
            UseParams2(1, "a", "test");
            // UseParams2;

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams1(myIntArray);
            object[] myObjArray = { 2, "b", "test", "again" };
            UseParams2(myObjArray);
        }
        public static void UseParams1(params int[] list)
        {
            for ( int i  = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
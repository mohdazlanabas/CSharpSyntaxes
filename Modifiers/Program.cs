namespace Modifiers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Access Modifiers");
                Demo1();
                Demo2();
                Demo3();
                Demo4();
                Demo5();
                Demo6();
                Demo7();
                //  Demo8();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured");
            }
        }

        static void Demo1()
        {
            Console.WriteLine("Static Void - Accessible Everywhere with static");
        }

        public static void Demo2()
        {
            Console.WriteLine("Public Static Void - Accessible Everywhere with static");
        }
        private static void Demo3()
        {
            Console.WriteLine("Private Static Voi - Accessible Within Class with staticd");
        }
        protected static void Demo4()
        {
            Console.WriteLine("Protected Static Void - Accesible any Project in solution with Inheritance");
        }
        internal static void Demo5()
        {
            Console.WriteLine("Internal Static Void - Within Project");
        }
        private protected static void Demo6()
        {
            Console.WriteLine("Private Protected Static Void - Within Class and Project");
        }

        protected internal static void Demo7()
        {
            Console.WriteLine("Protected Internal Static Void -  Accesible within Project in solution with Inheritance");
        }
    }
}
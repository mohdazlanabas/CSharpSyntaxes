namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var sc = new SealedClass();
            sc.a = 110;
            sc.b = 150;
            Console.WriteLine($"x = {sc.a}. y = {sc.b}");
 
        }
        sealed class SealedClass
        { 
            public int a;
            public int b;
        }
        class X
        {
            protected virtual void F1()
            { Console.WriteLine("X,F1"); }
            protected virtual void F2()
            { Console.WriteLine("X,F2"); }
        }

        class Y : X
        {
            sealed protected override void F1() 
            { Console.WriteLine("Y,F1"); }
            protected override void F2()
            { Console.WriteLine("Y,F2"); }
        }
        class Z : Y
        {
            protected override void F2()
            { Console.WriteLine("Z,F2"); }
        }


    }
}
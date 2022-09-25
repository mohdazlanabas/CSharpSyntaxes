namespace HarryPorter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Class01 class1 = new Class01();
            class1.title = "Harry Porter";
            Console.WriteLine(class1.title);

            Class02 class2 = new Class02();
            class2.author = "JK Rowling";
            Console.WriteLine(class2.author);

            int answer = cube(5);
            Console.WriteLine(answer);
        }
        internal class Class02
        {
            public string author;
        }
        static int cube (int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
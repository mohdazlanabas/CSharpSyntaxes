namespace NullFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClass mc;
            mc = null;
            mc = new MyClass();
            mc.MyMethod();
            mc = null;

            string s = null;
            string t = String.Empty;
            bool b = (t.Equals(s));
            Console.WriteLine("Empty string {0} null string", s == t ? "equals" : "does not equal");
            Console.WriteLine("null == null is {0}", null == null);
            int? i = null;
            Console.WriteLine("Press any key to exit.");
        }
        class MyClass
        {
            public void MyMethod() { }
        }
    }
}
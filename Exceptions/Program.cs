namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double x;
            double y;
            double results;

            try
            {
                Console.WriteLine("Enter the first numner:  ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second numner:  ");
                y = Convert.ToDouble(Console.ReadLine());
                results = x / y;
                Console.WriteLine("The results is: " + results);
            }
            catch (Exception e)
            {
                Console.WriteLine("The erro is: " + e);
            } 
            finally
            {
                Console.WriteLine("\n Enter Only Numbers! \n");
            }
        }
    }
}
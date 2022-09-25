using System;

namespace Await01
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Write(" Hello :");
            await Task.Delay(5000);
            Console.Write(": There ");
        }
    }
}

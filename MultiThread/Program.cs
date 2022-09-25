﻿using System;
using System.Threading;

namespace AlgoSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            // Console.WriteLine(mainThread.Name);
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            // CountDown();
            // CountUp();
            Console.WriteLine(mainThread.Name);
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("TImer #1 is complete!");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("TImer #2 is complete!");
        }
    }
}

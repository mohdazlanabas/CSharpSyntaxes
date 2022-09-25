using System;

namespace Syntaxes
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // ISampleInterface obj = new ImplementationClass();
            // obj.SampleMethod();
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();
            Hawk hawk = new Hawk();
            hawk.Hunt();
            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();
        }
        // interface ISampleInterface
        // {void SampleMethod();}
        // class ImplementationClass : ISampleInterface
        // { void ISampleInterface.SampleMethod()
        // { System.Console.WriteLine("Interface");}

        interface iPrey
        {
            void Flee();
        }
        interface iPredator
        {
            void Hunt();
        }

        class Rabbit : iPrey
        {
            public void Flee()
            {
                Console.WriteLine("The Rabbit Runs Away!");
            }
        }
        class Hawk : iPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The Hawak is Searching For Food!");
            }
        }

        class Fish : iPrey, iPredator
        {
            public void Flee()
            {
                Console.WriteLine("The Small Fish Runs Away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The Big Fish is Searching For Food!");
            }
        }

    }
}







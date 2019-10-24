using System;
using HelloObjects;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.Greet("Karol");
            greeter.Greet("Peter");
            Console.ReadKey();

        }
    }
}

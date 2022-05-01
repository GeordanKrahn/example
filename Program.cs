using System;
using System.Collections.Generic;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfScoop = 2;
            IceCream doubleIceCream = new IceCream(IceCream.ConeType.chocolateDip, numberOfScoop);
            IceCream empty = new();
            
            Console.WriteLine($"{empty.ToString()}\n");
            Console.WriteLine($"{doubleIceCream}\n\n");

            IceCreamSundae sundae = new();
            doubleIceCream.DoSomething(IceCream.Toppings.sprinkles);
            sundae.DoSomething(IceCream.Toppings.hotFudge);

            Console.WriteLine($"{doubleIceCream}\n");
            Console.WriteLine($"{sundae}\n\n");

            sundae.DoSomething(IceCream.Toppings.cherry);
            Console.WriteLine($"{sundae}\n");
        }
    }
}

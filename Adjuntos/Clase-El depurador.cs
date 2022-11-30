using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase17
    {
        public static void Main()
        {
            string fizzBuzzValue = "";

            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}

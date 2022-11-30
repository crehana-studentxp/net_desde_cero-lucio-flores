using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Class14
    {
        public static void Main(string[] args)
        {
            int rect(int m, int x, int b)
            {
                int y = (m * x) + b;
                return y;
            }

            int y = rect(10, 5, 3);
            Console.WriteLine($"valor de y: {y}");

            //función sin retorno
            void PrintTable(int x)
            {
                for (int y = 1; y <= 10; y++)
                    Console.WriteLine($"{x}x{y} = {x * y}");
            }

            float velocity = 60.89f;

            float calculateDistance(int hours)
            {
                {
                    var operation = "Multiplicación";
                    Console.WriteLine(operation);
                }

                //Console.WriteLine(operation);
                return velocity * hours;
            }

            float calculateHours(int distance)
            {

                return velocity / distance;
            }

            var distance = calculateDistance(3);
            Console.WriteLine(distance);
            var hours = calculateHours(100);
            Console.WriteLine(hours);
        }
    }
}

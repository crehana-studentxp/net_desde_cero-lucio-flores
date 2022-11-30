using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase09
    {
        public static void Main()
        {
            //operadores unarios
            int a = 1;
            int b = 0;

            b = a++;
            //b = ++a;
            //b = a--;
            //b = --a;
            Console.WriteLine($"b = a++; a ={a} b = {b}");

            //operadores arítmeticos
            a = 1;
            b = 1;
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a % b = {a % b}");

            //operadores de asignación
            a = 1;
            b = 0;
            b += a;
            //b -= a;
            //b *= a;
            //b /= a;
            Console.WriteLine($"b +=a; a ={a} b = {b}");

            //operadores lógicos
            //prueba a cambiar los valores
            bool aBool = true;
            bool bBool = false;
            Console.WriteLine($"aBool && bBool = {aBool && bBool}");
            Console.WriteLine($"a && b = {a & b}");

            Console.WriteLine($"aBool || bBool = {aBool || bBool}");
            Console.WriteLine($"a | b = {a | b}");

            Console.WriteLine($"aBool ^ bBool = {aBool ^ bBool}");
            Console.WriteLine($"a ^ b = {a ^ b}");

            //operadores de comparación

            a = 5;
            b = 4;
            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a > b = {a >= b}");
            Console.WriteLine($"a > b = {a < b}");
            Console.WriteLine($"a > b = {a >= b}");
            Console.WriteLine($"a > b = {a == b}");
            Console.WriteLine($"a > b = {a != b}");
        }
    }
}

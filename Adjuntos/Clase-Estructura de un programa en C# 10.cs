using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase05
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!"); //el ; inidica el fin de una instrucción
            {
                Console.WriteLine("bloque anonimo");
            }
            {
                Console.WriteLine("bloque anonimo 2");
            }

            //comentario para no olvidar que hace esta parte del código

            /*
             * podemos escribir
             * comentarios
             * en varias líneas
             * este es un bloque multilinea de comentarios.
             * 
             */

            string myEmail = "myEmail@dot.net";
            char atSymbol = myEmail[7];
            Console.WriteLine(atSymbol);
            const int value = 0;
            Console.WriteLine(value);  
        }
    }
}

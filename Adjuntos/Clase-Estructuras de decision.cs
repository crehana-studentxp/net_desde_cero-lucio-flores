using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase10
    {
        public static void Main()
        {
            if (1 == 1)
            {
                Console.WriteLine("1 es igual a 1");
                Console.WriteLine("Siguiente instrucción en el bloque");
            }

            if (1 == 1) Console.WriteLine("1 es igual a 1");
            Console.WriteLine("Siguiente instrucción. Ya no está dentro del bloque if");

            if ("Inception" == "Inception" && 2010 == 2010)
            {
                Console.WriteLine("Ejemplo de dos condiciones en el IF");
            }
            if (!("Inception" == "Inception" && 2010 == 2010))
            {
                Console.WriteLine("Ejemplo de negación del IF");
            }

            var age = 20;
            if (age > 18 && age < 65)
            {
                Console.WriteLine("La condición de la edad se cumple");
            }

            age = 10;
            if (!(age > 18 && age < 65))
            {
                Console.WriteLine("La condición negada de la edad se cumple");
            }

            if (age > 18 && age < 30)
            {
                Console.WriteLine("La persona tiene entre 19 y 29 años");
            }
            else
            {
                Console.WriteLine("La persona tiene es menor de 19 años o mayor a 29");
            }

            var bornCity = "CDMX";
            if ((age == 18 && bornCity == "CMDX") || (age == 21 && bornCity == "NYC"))
                Console.WriteLine("La persona es mayor de edad");

            var bornCountry = "Mexico";
            if (bornCountry == "Mexico")
            {
                if (age > 18) Console.WriteLine("La persona es mayor de edad");
            }

            var score = 7.6f;
            if (score == 10) Console.WriteLine("Puntuación perfecta");
            else if (score >= 8 && score <= 10) Console.WriteLine("Buen trabajo!");
            else if (score >= 7 && score <= 8) Console.WriteLine("Suficiente pero puedes hacerlo mejor");
            else if (score >= 6 && score <= 7) Console.WriteLine("No alcanzas el puntaje mínimo.");
            else Console.WriteLine("Tu puntuación sale de las gráficas");

            var selectedOption = 0;
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("Has seleccionado la búsqueda por nombre");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado la búsqueda por año");
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado la búsqueda por actor/actriz");
                    break;
                default:
                    Console.WriteLine("Por favor selecciona una opción válida");
                    break;
            }

            //if en una línea
            var movieName = "The Dark Knight";
            var moreThan10Characters = movieName.Length > 10 ? true : false;
            if (moreThan10Characters) Console.WriteLine($"{movieName} tiene más de 10 letras");
            else Console.WriteLine($"{movieName} tiene menos de 10 letras");

            //switch transformación
            var finalMessage = "mensaje";
            var mySwitchResult = finalMessage switch
            {
                "mensaje" => "tipo de switch dos",
                "mensaje 2" => "otro valor para el switch",
                "mensaje 3" => "otro posible valor.",
                _ => "default value"
            };

            Console.WriteLine(mySwitchResult);
        }
    }
}

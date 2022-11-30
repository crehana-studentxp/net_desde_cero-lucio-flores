using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase08
    {
        public static void Main()
        {
            Console.WriteLine("Escribe el nombre de la película: ");
            string movieName = Console.ReadLine();
            Console.WriteLine("Escribe el año de la película: ");
            string movieYear = Console.ReadLine();
            Console.WriteLine($"La película {movieName} fue lanzanda en el {movieYear}");

            TextFieldParser parser = new TextFieldParser("IMDB-Movie-Data.csv", System.Text.Encoding.UTF7);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[] result = parser.ReadFields();
                Console.WriteLine($"Columna 0: {result[0]}, Columna 1: {result[1]}, Columna[2]:{result[2]}");
            }
        }
    }
}

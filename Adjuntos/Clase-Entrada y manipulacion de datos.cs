using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase07
    {
        public static void Main()
        {
            //aparecerá el cursor esperando una entrada de datos
            //escribe algo y presiona enter
            var line = Console.ReadLine();
            Console.WriteLine($"line: {line}");

            //presiona una tecla cualquiera
            var key = Console.ReadKey();
            Console.WriteLine($"line: {key.KeyChar}");
            var text = System.IO.File.ReadAllText("IMDB-Movie-Data.csv");
            Console.WriteLine($"ReadAllText: {text}");

            var allLinesAtOnce = System.IO.File.ReadAllLines("IMDB-Movie-Data.csv");
            Console.WriteLine($"ReadAllLines: {allLinesAtOnce}");

            var allLinesOneByOne = System.IO.File.ReadLines("IMDB-Movie-Data.csv");
            Console.WriteLine($"ReadLines: {allLinesOneByOne}");

            //es necesario agregar la biblioteca Microsoft.VisualBasic.FileIO;
            //revisa la línea 1 de este código
            TextFieldParser parser = new TextFieldParser("IMDB-Movie-Data.csv", System.Text.Encoding.UTF8);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[]? result = parser.ReadFields();
                Console.WriteLine(result?[1]);
            }

            System.IO.File.WriteAllText("file.txt", "Content");
            System.IO.File.WriteAllLines("file.txt", new string[] { "Line 1", "Line 2", "Line 3" });
            System.IO.File.AppendAllText("file.txt", "New text");
            System.IO.File.AppendAllLines("file.txt", new string[] { "Line 4", "Line 5", "Line 6" });
        }
    }
}

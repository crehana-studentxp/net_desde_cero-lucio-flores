using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Escribe el nombre de la película: ");
string movieName = Console.ReadLine();
Console.WriteLine("Escribe el año de la película: ");
string movieYear = Console.ReadLine();
Console.WriteLine($"La película {movieName} fue lanzanda en el {movieYear}");

int years = DateTime.Now.Year - System.Convert.ToInt16(movieYear);
Console.WriteLine($"Han pasado {years} desde que estrenada.");


var text = System.IO.File.ReadAllText("ExampleTxt.txt");
Console.WriteLine($"Contenido del archivo txt: {text}");

var textAllLines = System.IO.File.ReadAllLines("ExampleTxt.txt");

var textLines = System.IO.File.ReadLines("ExampleTxt.txt");

TextFieldParser parser = new TextFieldParser("IMDB-Movie-Data.csv", System.Text.Encoding.UTF7);
parser.TextFieldType = FieldType.Delimited;
parser.SetDelimiters(",");
while (!parser.EndOfData)
{
    string[] result = parser.ReadFields();
    Console.WriteLine(result[1]);
}
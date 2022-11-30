using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase06
    {
        public static void Main()
        {
            int myVariable = 0;
            Console.WriteLine($"myVariable: {myVariable}");
            int x = 1, y = 2, z = 3;
            Console.WriteLine($"x: {x}, y = {y}, z = {z}");
            int myNumber = new int();
            Console.WriteLine($"myNumber: {myNumber}");
            var myNumberString = myNumber.ToString();
            Console.WriteLine($"myNumber: {myNumberString}");
            string movieName = new string("");
            Console.WriteLine($"movieName: {movieName}");
            var anotherNumber = 100;
            Console.WriteLine($"anotherNumber: {anotherNumber}");
            const int currentYear = 2022;
            Console.WriteLine($"currentYear: {currentYear}");
            char myChar = '@';
            Console.WriteLine($"myChar: {myChar}");
            var person = new { age = 20, name = "Freddy", address = "Elm Street", salary = 10000.98, company = "Monsters Inc" };
            Console.WriteLine($"person.age = {person.age}, person.name = {person.name}, person.address = {person.address}, person.salary = {person.salary}, person.company = {person.company}");
        }
    }
}

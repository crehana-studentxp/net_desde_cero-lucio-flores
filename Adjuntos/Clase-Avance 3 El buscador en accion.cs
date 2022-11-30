using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Class15
    {
        public static void Main()
        {
            Console.WriteLine("Buscador de películas");

            //definición de variables
            string movieSearchParameter = "";
            var pressedKey = ConsoleKey.G;
            var moviesData = LoadMovies();

            do
            {
                Console.WriteLine(new string('*', 100));
                Console.WriteLine("Seleccione el número de la opción de búsqueda y presione enter");
                Console.WriteLine("1. Búsqueda por nombre");
                Console.WriteLine("2. Búsqueda por año");
                Console.WriteLine("3. Búsqueda por género");
                Console.WriteLine("4. Búsqueda por actor");
                Console.WriteLine("5. Búsqueda por director");
                Console.WriteLine("6. Salir del programa");
                var selectedOption = Console.ReadLine();

                var resultOption = IsValidOption(selectedOption);

                if (resultOption == false)
                {
                    Console.WriteLine("Escriba una opción válida");
                }

                if (resultOption == true)
                {
                    switch (selectedOption)
                    {
                        case "1":
                            Console.WriteLine("Escriba el nombre de la película y presione enter");
                            movieSearchParameter = Console.ReadLine();
                            var resultsByName = SearchMovieByName(movieSearchParameter);
                            PrintResults(resultsByName);
                            break;
                        case "2":
                            Console.WriteLine("Escriba el año de la película y presione enter");
                            movieSearchParameter = Console.ReadLine();
                            var resultsByYear = SearchMovieByYear(movieSearchParameter);
                            PrintResults(resultsByYear);
                            break;
                        case "3":
                            Console.WriteLine("Escriba el género de la película y presione enter");
                            movieSearchParameter = Console.ReadLine();
                            var resultsByGenre = SearchMovieByGenre(movieSearchParameter);
                            PrintResults(resultsByGenre);
                            break;
                        case "4":
                            Console.WriteLine("Escriba el nombre del actor o actriz y presione enter");
                            movieSearchParameter = Console.ReadLine();
                            var resultsByActors = SearchMovieByActors(movieSearchParameter);
                            PrintResults(resultsByActors);
                            break;
                        case "5":
                            Console.WriteLine("Escriba el nombre del director/a");
                            movieSearchParameter = Console.ReadLine();
                            var resultsByDirector = SearchMovieByDirector(movieSearchParameter);
                            PrintResults(resultsByDirector);
                            break;
                        case "6":
                            Environment.Exit(0);
                            break;
                        default: break;
                    }
                }

                Console.WriteLine("Presione enter para realizar otra búsqueda o escape para salir");
                pressedKey = Console.ReadKey(true).Key;
            } while (pressedKey != ConsoleKey.Escape);

            List<string[]> LoadMovies()
            {
                var movies = new List<string[]>();
                TextFieldParser parser = new TextFieldParser("IMDB-Movie-Data.csv", System.Text.Encoding.UTF7);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] data = parser.ReadFields();
                    var movieData = new string[]
                    {
            data[1],
            data[2],
            data[4],
            data[5],
            data[6]
                    };
                    movies.Add(movieData);
                }
                return movies;
            }

            bool IsValidOption(string selectedOption)
            {
                var validOptions = new int[] { 1, 2, 3, 4, 5, 6 };
                int option = System.Convert.ToInt16(selectedOption);
                return validOptions.Contains(option);
            }

            List<string[]> SearchMovieByName(string movieName)
            {
                var searchResults = new List<string[]>();
                foreach (var data in moviesData)
                {
                    if (movieName.ToUpper() == data[0].ToUpper())
                    {
                        var result = new string[]
                                {
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4]
                                };
                        searchResults.Add(result);
                    }
                }
                return searchResults;
            }

            List<string[]> SearchMovieByYear(string movieYear)
            {
                //validate movieYear is a number
                try
                {
                    System.Convert.ToInt16(movieYear);
                }
                catch
                {
                    Console.WriteLine("Introduzca un número correcto para el año");
                }
                var searchResults = new List<string[]>();
                foreach (var data in moviesData)
                {
                    if (movieYear.ToUpper() == data[4].ToUpper())
                    {
                        var result = new string[]
                                {
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4]
                                };
                        searchResults.Add(result);
                    }
                }
                return searchResults;
            }

            List<string[]> SearchMovieByGenre(string movieYear)
            {
                //validate movieYear is a number
                var searchResults = new List<string[]>();
                foreach (var data in moviesData)
                {
                    if (data[1].ToUpper().Contains(movieYear.ToUpper()))
                    {
                        var result = new string[]
                                {
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4]
                                };
                        searchResults.Add(result);
                    }
                }
                return searchResults;
            }

            List<string[]> SearchMovieByActors(string movieYear)
            {
                //validate movieYear is a number
                var searchResults = new List<string[]>();
                foreach (var data in moviesData)
                {
                    if (data[3].ToUpper().Contains(movieYear.ToUpper()))
                    {
                        var result = new string[]
                                {
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4]
                                };
                        searchResults.Add(result);
                    }
                }
                return searchResults;
            }

            List<string[]> SearchMovieByDirector(string movieYear)
            {
                //validate movieYear is a number
                var searchResults = new List<string[]>();
                foreach (var data in moviesData)
                {
                    if (data[2].ToUpper().Contains(movieYear.ToUpper()))
                    {
                        var result = new string[]
                                {
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4]
                                };
                        searchResults.Add(result);
                    }
                }
                return searchResults;
            }


            void PrintResults(List<string[]> results)
            {
                Console.WriteLine($"Resultados de búsqueda:");
                if (results.Count == 0) Console.WriteLine("No se encontraron resultados");
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine($"{result[0]}, [{result[1]}], {result[2]}, [{result[3]}], {result[4]}");
                    }
                }
            }
        }
    }
}

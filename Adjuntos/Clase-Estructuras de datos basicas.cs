using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Class13
    {
        public static void Main()
        {
            int[] arrayInt = new int[10];

            var tvShows = new string[] { "TWD", "GOT", "WhatIf", "The Big Bang Theory" };

            var myFavoriteTvShow = tvShows[0];

            for (int i = 0; i < tvShows.Length; i++)
            {
                Console.WriteLine(tvShows[i]);
            }

            Console.WriteLine(myFavoriteTvShow);

            int[][] arrayOfArraysInt = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 } };

            foreach (int[] arrayOfArrays in arrayOfArraysInt)
            {
                foreach (int arrayOfArrays2 in arrayOfArrays)
                {
                    Console.WriteLine(arrayOfArrays2);
                }
            }

            List<int> listaInt = new List<int>();
            listaInt.Add(1);
            listaInt.Add(2);
            listaInt.Add(3);
            listaInt.Add(4);
            listaInt.Add(5);

            List<int> listaInt2 = new List<int> { 6, 7, 8, 9 };
            listaInt.AddRange(listaInt2);

            listaInt.ForEach(x =>
            {
                Console.Write($"{x},");
            });
            Console.WriteLine();
            listaInt.Remove(4);
            Console.WriteLine("Lista después de eliminar el elemento 4");
            listaInt.ForEach(x =>
            {
                Console.Write($"{x},");
            });
            Console.WriteLine();

            listaInt.RemoveAt(0);
            Console.WriteLine("Lista después de eliminar el elemento en la posición 0");
            listaInt.ForEach(x =>
            {
                Console.Write($"{x},");
            });
            Console.WriteLine();
            Console.WriteLine("Lista después de eliminar los elementos de la posición 0 a la 5");
            listaInt.RemoveRange(0, 5);
            listaInt.ForEach(x =>
            {
                Console.Write($"{x},");
            });
            Console.WriteLine();
            Console.WriteLine($"La lista contiene el número 9? {listaInt.Contains(9)}");

            //listas anidadas
            List<List<int>> listOfList = new List<List<int>>();
            listOfList.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            listOfList.Add(new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            listOfList.ForEach(list =>
            {
                list.ForEach(item =>
                {
                    Console.Write($"{item},");
                });
                Console.WriteLine();
            });


            //Diccionarios
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            dictionary1.Add("clave_1", "valor que almacena la clave 1");
            dictionary1.Add("clave_2", "valor que almacena la clave 2");
            dictionary1.Add("clave_3", "valor que almacena la clave 3");

            foreach (var keypar in dictionary1)
            {
                Console.WriteLine($"key: {keypar.Key}, value: {keypar.Value}");
            }

            var clave_1 = dictionary1["clave_1"];
            Console.WriteLine($"dicctionary[\"clave_1\"] = {clave_1}");

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("a", new List<string> { "árbol", "abeja", "androide" });
            dictionary.Add("b", new List<string> { "batman", "bart", "benson" });

            foreach (var keypar in dictionary)
            {
                Console.Write($"Valores en {keypar.Key}: ");
                foreach (var value in dictionary[keypar.Key]) Console.Write($"{value},");
                Console.WriteLine();
            }
        }
    }
}

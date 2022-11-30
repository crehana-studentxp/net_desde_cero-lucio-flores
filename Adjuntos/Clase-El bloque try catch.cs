using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crehana.DotNetDesdeCero
{
    public class Clase16
    {
        public static void Main()
        {
            try
            {
                System.Convert.ToInt16(".net");
            }
            catch
            {
                Console.WriteLine("Ocurrió un error");
            }
            finally
            {

            }

            try
            {
                System.Convert.ToInt16(".net");
            }
            catch (FormatException)
            {
                Console.WriteLine("La cadena no se puede convertir a número");
            }
            finally
            {

            }

            try
            {
                System.Convert.ToInt16("12345678923456789023456789");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es muy grande");
            }
            finally
            {

            }

            try
            {
                System.Convert.ToInt16("1234567890123456789234567893456789023456789345678");
            }
            catch (FormatException)
            {
                Console.WriteLine("La cadena no se puede convertir a número");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es muy grande");
            }
            finally
            {
                Console.WriteLine("El programa continuará la ejecución.");
            }
        }
    }
}

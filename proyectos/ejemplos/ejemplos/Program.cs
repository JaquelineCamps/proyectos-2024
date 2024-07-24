using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            do
            {
                Console.Write("Introduce un número positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                }
                else
                {
                    break;
                }

            } while (true);

            Console.WriteLine("La suma de los números positivos introducidos es: " + suma);
        }
    }
}

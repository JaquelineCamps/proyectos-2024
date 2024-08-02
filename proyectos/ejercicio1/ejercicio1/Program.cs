using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Introduce un número (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("Saliendo del programa...");
                }

            } while (numero != 0);
        }
    }

}
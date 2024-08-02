using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            do
            {

                Console.Write("Escriba un numero positivo;(negativo o cero es para finalizar):");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba otro numero positivo,(negativo o cero es para finalizar):");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                if (numero1 != 0 || numero2 != 0)


                    Console.WriteLine("El resultado es: {0}", resultado);
                break;

            } while (numero1 != 0 || numero2 != 0);


            Console.Write(" terminara cuando escriba un numero negativo o cero");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module3
{
    internal class IteratorFor
    {
        public static void RunIteratorFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------");

            for(int i = 0; i <= 10; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------");

            string[] names = ["Alex", "Eddie", "David", "Michael"];
            for( int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("------------------------------------------------------");

            // EJERCICIO FIZZ BUZZ
            /* Dados los numeros de 1 a 100
             * Imprime en consola Fizz si el valor actual es divisible por 3
             * Imprime en consola Buzz si el valor actual es divisible por 5
             * Si es divisible por 3 y 5 imprime FizzBuzz junto al numero
             */

            for ( int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

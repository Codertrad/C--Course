using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module3
{
    internal class BooleanExpresions
    {
        public static void RunBooleanExpresions()
        {
            Console.WriteLine("a" == "a"); // True
            Console.WriteLine("a" == "A"); // False
            Console.WriteLine(1 == 2); // False

            Console.WriteLine("--------------------------------------------------------------");

            // Operador ternario

            int saleAmmount = 1000;
            int discount = saleAmmount <= 1000 ? 50 : 100;

            Console.WriteLine($"The discount of your buy is {discount}, beacause your buy ammount is {saleAmmount}");

            Console.WriteLine("--------------------------------------------------------------");

            // CARA O CRUZ: EJERCICIO
            /* Desafío de código: escribir código para mostrar el resultado de un cara o cruz
               Estos son los requisitos del desafío:
                                                  
                * Use la clase Random para generar un valor.
                
                * Tenga en cuenta el intervalo de números necesarios.
                
                * Según el valor generado, use el operador condicional para mostrar heads o tails.
                
                * Debería haber una posibilidad del 50 % de que el resultado sea cara o cruz.
                
                * El código debe ser fácil de leer, pero con el menor número posible de líneas.
                
                Debería lograr el resultado deseado en tres líneas de código o menos.
             */

            // SOLUCION:

            Random coin = new Random();

            int flip = coin.Next(2);
            string result = (flip == 0) ? "Heads" : "Tails";
            Console.WriteLine(result);

            Console.WriteLine("-----------------------------------------------------------------");

            // MANEJO DE ROLES: EJERCICIO

            string permission = "";
            int level = 20;

            if (permission.Contains("Admin"))
            {
                Console.WriteLine(level > 55 ? "Welcome, Super Admin user" : "Welcome, Admin user.");
            }
            else if (permission.Contains("Manager"))
            {
                Console.WriteLine(level >= 20 ? "Contact an Admin for access" : "You do not have sufficient privileges.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}

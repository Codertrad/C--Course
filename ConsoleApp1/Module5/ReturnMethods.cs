using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class ReturnMethods
    {
        public static void RunReturnMethods()
        {
            /* Uso de metodos para calcular el precio total de compra 
               El centro comercial contoso tiene unas excelentes rebajas! MUchos articulos
               tienen un precio con descuente. se le da una lista de precios de los articulos
               y una lista de los descuentos correspondientes. Los descuentos se representan
               mediante porcentajes, por ejemplo, 50% = 0.5. Si un cliente gasta mas de 30.00 usd
               recibira 5.00 usd de su compra total. En esta tarea, escribira codigo para calcular
               el total del cliente.
             */

            double total = 0;
            double minimumSpend = 30.00;

            double[] items = [15.97, 3.50, 12.25, 22.99, 10.98];
            double[] discounts = [0.30, 0.00, 0.10, 0.20, 0.50];

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            if (TotalMeetsMinimum())
            {
                total -= 5.00;
            }

            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                // Calculate the discounted price of the item
                double result = items[itemIndex] * (1 - discounts[itemIndex]);
                return result;
            }

            bool TotalMeetsMinimum()
            {
                // Check if the total meets the minimum
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                // Format the double so only 2 decimal places are displayed
                return input.ToString().Substring(0, 5);
            }

            Console.WriteLine("------------------------------------------------------------");

            // EJERCICIO: Devolver numeros de metodos

            /* A menudo, es posible que tenga que devolver numeros de metodos y usar los resultados
               para otras tareas. En este breve ejercicio, practicara la devolucion de los tipos 
               de datos int y double y la captura de los valores devueltos.
            */

            /*Supongamos que visita Vietnam y quiere crear un breve programa de conversion de
               divisa.Supongamos que el tipo de cambio actual es 1 USD = 23500 VND.En esta tarea
               escribira un metodo que convierta USD en VND
            */


            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            Console.WriteLine($"${usd} USD = ${vnd} VND");
            Console.WriteLine($"${vnd} VND = ${vndToUsd(vnd)} USD");

            int UsdToVnd(double usd)
            {
                int rate = 23500;
                return (int)(rate * usd);
            }

            double vndToUsd(int vnd)
            {
                double rate = 23500;
                return vnd / rate;
            }

            Console.WriteLine("------------------------------------------------------------");

            string input = "snake";
            string message = "there are snakes at the zoo";

            Console.WriteLine(input);
            Console.WriteLine(ReverseWord(input));
            Console.WriteLine(ReverseSentence(message));

            string ReverseWord(string word)
            {
                string result = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }

                return result;
            }

            string ReverseSentence(string input)
            {
                string result = "";
                string[] words = input.Split(" ");

                foreach (string word in words)
                {
                    result += ReverseWord(word) + " ";
                }

                return result.Trim();
            }

            Console.WriteLine("------------------------------------------------------------");

            //EJERCICIO: Devolver valores booleanos de metodos

            /* Creacion de un metodo que devuleve un valor booleano
               Supongamos que es un candidato en una entrevista para un puesto de programador.
               El entrevistador quiere que compruebe si varias palabras son un palindromo. Una
               palabra es un palindromo si lee igual hacia atra y hacia delante. Por ejempo la
               palara "racecar" es un palindromo comencemos:
            */

            string[] words = ["racecar", "talented", "deified", "tent", "tenet"];

            Console.WriteLine("Is it a palindrome?");

            foreach (string word in words)
            {
                Console.WriteLine($"Word: {word} - Palindrome: {IsPalindrome(word)}");
            }

            bool IsPalindrome(string word)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string wordReversed = new string(charArray);

                return word == wordReversed ? true : false;
            }

            Console.WriteLine("------------------------------------------------------------");

            // EJERCICIO: Devolver valores de metodos de tipo array

            /* Supongamos que tiene varias monedas de diferentes valores. se le ha pedido que
               encuentre dos monedas cuya suma sea igual a un valor objetivo. En este ejercicio, las
               monedas disponibles se representan en una matriz de enteros. Debera devolver los indices
               de las dos monedas en una nueva matriz. Comencemos.
            */

            /* En caso que no se encuentren dos monedas, el metodo devuelve una matriz vacia.
               Dedique un momento a considerar la sintaxis del resultado devuelto. Aunque pueda
               crear una variable, la instruccion return permite crear y devolver valores al 
               mismo tiempo
            */

            // PSEUDOCODIGO
            /* a) Elegir un numero de la matriz
               b) Comprobar otros numeros de uno en uno para ver si suman el valor objetivo
               c) Devolver el resultado tan pronto como se encuentre una coincidencia
            */

            int target = 30;
            int[] coins = [5, 5, 50, 25, 25, 10, 5];
            //Matriz 1D: int[] result = TwoCoins(coins, target);
            //Matriz 2D:
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                // Matriz 1D Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");

                Console.WriteLine("Change found at positions:");
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (result[i, 0] == -1)
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
                }
            }

            /*int[] TwoCoins(int[] coins, int target)
            {
                for (int curr = 0; curr < coins.Length; curr++)
                {
                    for (int next = curr + 1; next < coins.Length; next++)
                    {
                        if (coins[curr] + coins[next] == target)
                        {
                            return new int[] { curr, next };
                        }
                    }
                }
                return new int[0];
            }*/

            /* ENCONTRAR VARIOS PARES DE MONEDAS PARA DAR EL CAMBIO:    
             
               En este paso, ampliara el metodo TwoCoins para encontrar mas pares de monedas
               cuya suma sea igual al valor objetivo. Para este ejercicio, encontrara un maximo
               de cinco pares.Esto significa que el tipo de valor devuelvo sera una matriz 2D
               en lugar de una matriz 1D, y tendra que modificar la forma en que el codigo
               devuelve los resultados. Comencemos
             */

            int[,] TwoCoins(int[] coins, int target)
            {
                int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
                int count = 0;

                for (int curr = 0; curr < coins.Length; curr++)
                {
                    for (int next = curr + 1; next < coins.Length; next++)
                    {
                        if (coins[curr] + coins[next] == target)
                        {
                            result[count, 0] = curr;
                            result[count, 1] = next;
                            count++;
                        }
                        if (count == result.GetLength(0))
                        {
                            return result;
                        }
                    }
                }
                return (count == 0) ? new int[0, 0] : result;
            }
        }
    }
}

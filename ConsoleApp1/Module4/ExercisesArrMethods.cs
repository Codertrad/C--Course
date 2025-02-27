using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module4
{
    class ExercisesArrMethods
    {
        public static void RunExercises ()
        {
            /* EJERCICIO 1: 
            *  1. Dado una cadena de palabras debe invertir cada una de las palabras
            *  2. La posicion de la palabra debe ser igual a la original
            *  3. El output es el siguiente: 'ehT kciuq nworb xof spmuj revo eht yzal god'
            */

            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] arrWords = pangram.Split(" ");
            string[] arrReversedWords = new string[arrWords.Length];

            for(int i = 0; i < arrWords.Length; i++)
            {
                char[] letter = arrWords[i].ToCharArray();
                Array.Reverse(letter);
                arrReversedWords[i] = new string(letter);
                //Console.WriteLine($"-- {arrReversedWords[i]}");
            }

            string pangramReversed = string.Join(" ", arrReversedWords);
            Console.WriteLine(pangramReversed);

            /* EJERCICIO 2:
             * Los datos vienen en muchos formatos. En este desafío, tiene que analizar los "identificadores de pedido" 
             * individuales y generar los "OrderIDs" ordenados y etiquetados como "Error" si no tienen exactamente cuatro 
             * caracteres de longitud.          
            
                la variable orderStream contiene string de varios id. de pedido separados por comas.
                        
               1.Analizar los "Id. de pedido" de string de los pedidos entrantes y 
                 almacenar los "Id. de pedido" en una matriz.

               2.Agregue código para que cada "Id. de pedido" ordenado por prioridad 
                 y por etiqueta que no tenga exactamente cuatro caracteres de longitud 
                 genere "- Error".
                
                OUTPUT: 
                A345
                B123
                B177
                B179
                C15     - Error
                C234
                C235
                G3003   - Error
            */

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orders = orderStream.Split(",");
            Array.Sort(orders);

            foreach (string order in orders)
            {
                if(order.Length != 4)
                    Console.WriteLine($"{order} \t - Error");
                else
                {
                    Console.WriteLine(order);
                }
            }
             
        }
    }
}

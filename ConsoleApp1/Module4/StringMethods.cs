using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module4
{
    class StringMethods
    {
        public static void RunStringMethods()
        {
            /*string message = "Find What is (inside the parentheses)";

            //Metodo IndexOf: Recupera el indice de la caracter
            int openingPosition = message.IndexOf("(");
            int closingPosition = message.IndexOf(")");

            //Console.WriteLine(openingPosition); // Indice: 13
            //Console.WriteLine(closingPosition); // Indice: 36
            openingPosition += 1;
            int lengthInsideParenthesis = closingPosition - openingPosition;

            //Metodo Substring: Corta la cadena o el string (index inicial, candidad de caracteres x cortar);
            Console.WriteLine(message.Substring(openingPosition, lengthInsideParenthesis)); // inside the parentheses
            */

            /*string message = "What is the value <span>between the tags</span>";

            const string openSpan = "<span/>";
            const string closeSpan = "</span>";


            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));*/

            /*  IndexOf() proporciona la primera posición de un carácter o una cadena dentro de otra cadena.
                IndexOf() devuelve -1 si no encuentra ninguna coincidencia.
                Substring() devuelve solo la parte especificada de una cadena, con una posición inicial y una longitud opcional.
                A menudo hay más de una manera de solucionar un problema. Se han usado dos técnicas independientes para buscar todas las instancias de un determinado carácter o cadena.
                Evite los valores mágicos codificados de forma rígida. En su lugar, defina una variable const. El valor de una variable constante no se puede cambiar después de la inicialización.*/


            // EJERCICIO: Uso de los metodos auxiliares IndexOf() y LastIndexOf()

            /*string message = "hello there!";

            int first_h = message.IndexOf("h");
            int second_h = message.LastIndexOf("h");

            Console.WriteLine($"For the message: \"{message}\" the firs \"h\" is at positon {first_h} and the last \"h\" is at position {second_h}");*/

            /*string message = "(What if) I am (only interested) in the last (set of parentheses)?";

            int openingPosition = message.LastIndexOf("(");
            openingPosition += 1;
            int closingPosition = message.LastIndexOf(")");
            int length = closingPosition - openingPosition;

            Console.WriteLine(message.Substring(openingPosition, length));*/

            /*string message = "(What if) there are (more than) one (set of parentheses)?";

            while (true)
            {
                int openingPosition = message.IndexOf("(");
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(")");
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note the overload of the Substring to return only the remaining
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }*/

            /*Cuando se usa Substring() sin especificar un parámetro de entrada de 
             * longitud, devolverá todos los caracteres después de la posición inicial 
             * que se especifica.Con la cadena que se está procesando,
             * message = "(What if) there are (more than) one (set of parentheses)?", 
             * es ventajoso eliminar el primer conjunto de paréntesis(What if)
             * del valor de message. Lo que queda se procesa después en la siguiente iteración 
             * del bucle while.*/

            //METODO IndexOfAny():

            /*string message = "Hello, world!";
            char[] charsToFind = ['a', 'e', 'i'];

            int index = message.IndexOfAny(charsToFind);

            Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");*/

            /*string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // You want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // You'll use a slightly different technique for iterating through 
            // the characters in the string. This time, use the closing 
            // position of the previous iteration as the starting index for the 
            //next open symbol. So, you need to initialize the closingPosition 
            // variable to zero:

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now  find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Finally, use the techniques you've already learned to display the sub-string:

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));*/

            // EJERCICIO: Uso de los metodos Remove() y Replace()

            /*string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);*/

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            string openTagSpan = "<span>";
            string closeTagSpan = "</span>";
            string openTagDiv = "<div>";
            string closeTagDiv = "</div>";

            // Extract Only Quantity 
            int openingPosition = input.IndexOf(openTagSpan);
            openingPosition += 6;
            int closingPosition = input.IndexOf(closeTagSpan);
            int lenghtQuantity = closingPosition - openingPosition;

            quantity = input.Substring(openingPosition, lenghtQuantity);
            // Remove <div> Tag
            int openDivPosition = input.IndexOf(openTagDiv);
            openDivPosition += 5;
            int closeDivPosition = input.IndexOf(closeTagDiv);
            int lengthExtractDiv = closeDivPosition - openDivPosition;

            string outputWithoutDiv = input.Substring(openDivPosition, lengthExtractDiv);
            output = outputWithoutDiv.Replace("&trade", "&reg");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }
    }
}

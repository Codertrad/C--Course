using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module4
{
    class ParseTypeData
    {
        public static void RunParseTypeData()
        {
            /*int first = 2;
            string second = "4";
            int result = first + second;
            Console.WriteLine(result);*/
            // Hay un error en el compilador de C# ya que no puede convertir el tipo string en tipo number

            /*int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);*/
            // Al ser result un tipo string lo que hace el compilador es concatenar para mostrar como resultado 24

            /*int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");*/
            //Cualquier valor int puede adaptarse facilmente dentro de un tipo decimal, de modo que el compilador realiza la conversion.
            /*El termino conversion de ampliacion significa que intenta convertir un valor de un tipo de datos que podria contener menos informacion
            en un tipo de datos que contiene mas informacion.*/
            // En este caso, un valor almacenado en una variable de tipo int convertido en una variable de tipo decimal no pierde informacion.

            // REALIZACION DE UNA COERCION
            /*decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");*/

            /* La variable myDecimal contiene un valor con precision despues del separador decimal. Al agregar la instruccion de coercion (int) 
               estamos indicando al compilador de C# que sabemos que es posible que perdamos esa precision, pero que, en este caso, no pasa nada.
               Esta diciendole al compilador que esta realizando una conversion intencionala, una conversion explicita */

            // Ejemplos de metodos para conversion:

            /* En la mayoria de los primitivos, realiza una conversion de ampliacion. Aunque esto no es estrictamente necesario ( puesto que podemos
               basarnos en la conversion implicita en la mayoria de los casos ). puede comunicar a otros desarrolladores que comprende lo que esta haciendo y que 
               es a proposito */

            /*int first = 5;
            int second = 7;

            string message = first.ToString() + second.ToString();
            Console.WriteLine(message); // --------------> 57*/

            /*string first = "5";
            string second = "7";

            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum); // ---------------> 12 */

            // TRYPARSE()

            /*string value = "bad";
            int result = 0;

            if(int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine($"Unable to report the measurement.");
            }

            if(result > 0)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");*/


            //EJERCICIO 1

            /* Regla 1: Si el valor es alfabético, concaténelo para formar un mensaje.

               Regla 2: Si el valor es numérico, súmelo al total.

               Regla 3: El resultado debe coincidir con la siguiente salida: 
                
                Output:

                Message: ABCDEF
                Total: 68,3
             */

            /*string[] values = ["12,3", "45", "ABC", "11", "DEF"];
            decimal totalAcc = 0;
            string messageConcat = "";

            for (int i = 0; i < values.Length; i++)
            {
                if (decimal.TryParse(values[i], out decimal total))
                {
                    totalAcc += total;
                }
                else
                {
                    messageConcat += values[i];
                }
            }

            Console.WriteLine($"Message: {messageConcat}");
            Console.WriteLine($"Total: {totalAcc}");*/

            // EJERCICIO 2

            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2

            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}

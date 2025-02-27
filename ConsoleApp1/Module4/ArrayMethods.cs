using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module4
{
    class ArrayMethods
    {
        public static void RunArrayMethods ()
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];


            //METODO SORT: PARA ORDENAR EL ARRAY
            /*Console.WriteLine("Sorted....");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/

            //METODO REVERSE: PARA INVERTIR EL ORDEN DEL ARRAY
            /*Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/


            // METODO CLEAR: CONVIERTE LOS DATOS EN TIPO NULL, LOS QUITA PERO SIGUEN EXISTIENDO DENTRO DEL ARRAY
            /*Console.WriteLine("");
            Console.WriteLine($"Before: {pallets[0].ToLower()}");
            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"After: {pallets[0]}");
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/


            // METODO RESIZE: SIVE PARA AGREGAR O QUITAR DATOS DEL ARREGLO
            /*Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach(var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/

            /*Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/

            // METODO ToCharArray(): Convierte el string en un arreglo de carracteres
            /*string value = "abc123";
            char[] valueArray = value.ToCharArray(); // -----> ["a", "b", "c", "1", "2", "3"]
            Array.Reverse(valueArray); // -----> ["3", "2", "1", "c", "b", "a"]
            string result = new string(valueArray); // convierte el arr en string
            Console.WriteLine(result);// -----> "321cba"*/

            //METODO Join(): Combina los caracteres en una nueva cadena de valores 
            /*string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            //METODO Split(): Crea una matriz teniendo en cuenta el limitador para separar cada uno de 
            // los datos que tendra el array
            string[] items = result.Split(",");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }*/

        }
    }
}

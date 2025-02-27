using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module4
{
    class FormatCharacters
    {
        public static void RunFormatNumbers ()
        {
            /*// FORMATO COMPUESTO

            string first = "Hello";
            string second = "world";
            string result = string.Format("{0} {1}!", first, second);
            string result2 = string.Format("{1} {0}!", first, second);
            string result3 = string.Format("{0} {0} {0}!", first, second);
            Console.WriteLine(result); // Hello world!
            Console.WriteLine(result2); // world Hello!
            Console.WriteLine(result3); // Hello Hello Hello!

            Console.WriteLine(" ");
            //Interpolacion de cadenas: Simplifica el formato compuesto.
            Console.WriteLine($"{first} {second}!"); // Hello world!
            Console.WriteLine($"{second} {first}!"); // world Hello!
            Console.WriteLine($"{first} {first} {first}!"); // Hello Hello Hello!

            Console.WriteLine(" ");
            // APLICACION DE FORMATO A VALORES DE MONEDA:

            decimal price = 123.45m;
            int discount = 50;

            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement {measurement:N} units");

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");*/

            // EJERCICIO 1: Exploracion de la interpolacion de cadenas

            /*int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Shares: {productShares:N3} Product");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Billed: {total:C}");*/

            /*string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);*/

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are exited to tell you about a new financial product that would dramatically increase your return.");
            Console.WriteLine("");
            Console.WriteLine($"Currently, you own {currentShares:N} at a return of {currentReturn:P2}.");
            Console.WriteLine("");
            Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");
            Console.WriteLine("");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage += currentProduct.PadRight(20);
            comparisonMessage += $"{currentReturn:P2}\t";
            comparisonMessage += $"{currentProfit:C}\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += $"{newReturn:P2}\t";
            comparisonMessage += $"{newProfit:C}\n";


            Console.WriteLine(comparisonMessage);
        }
    }
}

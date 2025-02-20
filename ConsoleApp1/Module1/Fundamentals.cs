using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module1
{
    internal class Fundamentals
    {
        public static void RunFundamentals()
        {
            string name = "bob";
            int numbermessages = 3;
            double temperature = 34.4;

            // Console.WriteLine($"Hello {name}! You have {numberMessages} messages in your inbox. The temperature is {temperature} celcius.");


            // Adition of two numbers

            int firstNumber = 12;
            int secondNumber = 7;

            //Console.WriteLine(firstNumber + secondNumber);

            string firstName = "Bob";
            int widgetSold = 7;

            //Console.WriteLine(firstName + " sold " + 7 + widgetSold + " widgets."); // Bob sold 77 widgets.
            //Console.WriteLine(firstName + " sold " + (7 + widgetSold) + " widgets."); // Bob sold 14 widgets.


            // Operations Math

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 5 * 5;
            int quotientWithoutDecimal = 10 / 2;
            decimal quotientWithDecimal = 7.0m / 5;

            /*Console.WriteLine("Sum: " + sum); // Sum: 12 +
            Console.WriteLine("Difference: " + difference); // Difference: 2 -
            Console.WriteLine("Product: " + product); // Product: 25 *
            Console.WriteLine("Quotient: " + quotientWithoutDecimal); // Quotient: 5 /
            Console.WriteLine("Quotient: " + quotientWithDecimal); // Quotient: 1.4 /*/


            // Decrement and Increment


            int value = 0; // value is 0
            value = value + 5; // value is 5
            value += 5; // value is 10

            //Console.WriteLine(value);



            // Conver Fahrenheit to Celcius

            int fahrenheit = 94;
            decimal toCelcius = (fahrenheit - 32m) * 5m / 9m;

            //Console.WriteLine($"The Temperature is {toCelcius} Celsius.");
            //Console.WriteLine(5 / 10);
        }
    }
}

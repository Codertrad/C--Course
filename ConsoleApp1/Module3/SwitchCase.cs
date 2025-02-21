using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module3
{
    internal class SwitchCase
    {
        public static void RunSwitchCase ()
        {
            int employeeLevel = 200;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
            Console.WriteLine("--------------------------------------------------------------");


            // EJERCICIO: REFACTORIZAR CODIGO PARA LA UTILIZACION DE SWITCH CASE
            // Output: Product: Large Maroon Sweat shirt

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;

                case "02":
                    type = "T-Shirt";
                    break;

                case "03":
                    type = "Sweat pants";
                    break;

                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;

                case "MN":
                    color = "Maroon";
                    break;

                default:
                    color = "White";
                    break;
            }
            
            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;

                case "M":
                    size = "Medium";
                    break;

                case "L":
                    size = "Large";
                    break;

                default:
                    size = "One Size Fits All";
                    break;
            }
                                    
            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
}

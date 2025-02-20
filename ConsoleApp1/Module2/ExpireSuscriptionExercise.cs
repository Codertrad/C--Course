using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module2
{
    internal class ExpireSuscriptionExercise
    {
        public static void RunExpireSuscription()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            //Your code goes here

            if (daysUntilExpiration <= 10)
            {

                if (daysUntilExpiration == 0)
                {
                    Console.WriteLine("Your subscription has expired.");
                }

                else if (daysUntilExpiration == 1)
                {
                    discountPercentage = 20;
                    Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage}%!");
                }

                else if (daysUntilExpiration <= 5)
                {
                    discountPercentage = 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save {discountPercentage}%!");
                }

                else
                {
                    Console.WriteLine("Your subscription will expire soon! Renew now");
                }
            }
        }
    }
}

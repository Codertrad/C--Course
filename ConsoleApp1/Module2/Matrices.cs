﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module2
{
    internal class Matrices
    {
        public static void RunMatrices ()
            {
            /*string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";*/

            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            Console.WriteLine("--------------------------------------------------------------------------------------");

            string[] names = ["John", "Paul", "George", "Ringo"];

            foreach (string name in names)
            {
                Console.WriteLine($"Name: {name}");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            int[] inventory = [200, 450, 700, 175, 250];
            int sum = 0;
            int bin = 0;

            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in inventory.");

            Console.WriteLine("--------------------------------------------------------------------------------------");

            string[] fraudulentInventory = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

            foreach (string item in fraudulentInventory)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine($"The item {item} starts with 'B'!");
                }
            }
        }
    }
}

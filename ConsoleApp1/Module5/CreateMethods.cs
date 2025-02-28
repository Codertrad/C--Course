using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class CreateMethods
    {
        public static void RunCreateMethods()
        {
            /* Console.WriteLine("Generating random numbers:");
             DisplayRandomNumbers();

             void DisplayRandomNumbers()
             {
                 Random random = new Random();

                 for (int i = 0; i < 5; i++)
                 {
                     Console.Write($"{random.Next(1, 100)} ");
                 }

                 Console.WriteLine();
             }*/

            /*int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));              
                AdjustTimes();
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine();

            void DisplayTimes ()
            {   
                *//* Format and display medicine times *//*
                foreach (int val in times)
                {
                    string time = val.ToString();
                    int len = time.Length;

                    if (len >= 3)
                    {
                        time = time.Insert(len - 2, ":");
                    }
                    else if (len == 2)
                    {
                        time = time.Insert(0, "0:");
                    }
                    else
                    {
                        time = time.Insert(0, "0:0");
                    }

                    Console.Write($"{time} ");
                }
            }

            void AdjustTimes()
            {
                *//* Adjust the times by adding the difference, keeping the value within 24 hours *//*
                for (int i = 0; i < times.Length; i++)
                {
                    times[i] = ((times[i] + diff)) % 2400;
                }
            }*/

            // EJERCICIO: 

            /* Uso de métodos para estructurar código:
             
            Supongamos que es un candidato en una entrevista para un puesto de programador.
            El entrevistador quiere que escriba un programa que compruebe si una dirección IPv4 es válida o no.
            Se le dan las siguientes reglas:

            *Una dirección IPv4 válida consta de cuatro números separados por puntos.
            *Cada número no debe contener ceros iniciales.
            *Cada número debe oscilar entre 0 y 255.
            *1.1.1.1 y 255.255.255.255 son ejemplos de direcciones IP válidas.

            La dirección IPv4 se proporciona como una cadena. Puede suponer que solo consta de 
            dígitos y puntos(no hay letras en la cadena proporcionada).

            ¿Cómo abordaría esta tarea?*/

            /* Nota:

            Incluso si no está familiarizado con las direcciones IP, no se preocupe. 
            Todavía puede completar el código de este ejercicio siguiendo los pasos.*/

            // Desglose del problema

            /* En esta tarea, identificara los pasos necesarios para resolver el problema. Si examina
             detenidamente las reglas, se dara cuenta de que solo son necesarios 3 pasos para determinar
             si una direccion IPv4 es valida o no 
            */

            /*
              if ipAddress consists of 4 numbers
              and
              if each ipAddress number has no leading zeroes
              and
              if each ipAddress number is in range 0 - 255

              then ipAddress is valid

              else ipAddress is invalid
            */

            /* El pseudocodigo es una excelente manera de empezar a abordar cualquier problema. Con este bloque
               de comentarios, cierra la brecha entre las reglas PROMPT y el codigo del programa, con lo que
               aclara las tareas principales que realizara el codigo. El pseudocodigo no necesita ser funcional 
               ni cumplir las reglas de sintaxis, pero debe ser una explicacion clara de lo que hara el codigo.
               Ahora vamos a convertir esto en codigo real
            */

            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input)
            {
                address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                ValidateLength();
                ValidateZeroes();
                ValidateRange();

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength()
            {
                validLength = address.Length == 4;
            };

            void ValidateZeroes()
            {
                foreach (string number in address)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                    {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            };

            void ValidateRange()
            {
                foreach (string number in address)
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            };
        }
    }
}

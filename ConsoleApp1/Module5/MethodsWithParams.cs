using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class MethodsWithParams
    {
        public static void RunMethodsWhithParams ()
        {
            /*int[] schedule = [800, 1200, 1600, 2000];
            
            void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
            {
                int diff = 0;
                if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) 
                {
                    Console.WriteLine("Invalid GMT");
                }
                else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                {
                    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                }
                else
                {
                    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                }

                for (int i = 0; i < times.Length; i++)
                {
                    int newTime = ((times[i] + diff)) % 2400;
                    Console.WriteLine($"{times[i]} -> {newTime}");
                }
            }

            DisplayAdjustedTimes(schedule, 6, -6);*/

            // EXAMPLE 2:

            string[] students = ["Jenna", "Ayesha", "Carlos", "Viktor"];

            DisplayStudents(students);
            DisplayStudents(new string[]{"Robert", "Vanya"});

            void DisplayStudents(string[] students)
            {
                foreach(string student in students)
                {
                    Console.Write($"{student}, ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------");

            // EXAMPLE 3:

            // Al utilizar la variable pi en los dos metodos es una buena candidata para ser una variable global

            double pi = 3.14159;
            PrintCircleInfo(12);
            PrintCircleInfo(24);
            
            void PrintCircleInfo(int radius)
            {
                Console.WriteLine($"Circle with raidus {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumference(radius);
                Console.WriteLine();
            }

            void PrintCircleArea(int radius)
            {
                //double pi = 3.14159;
                double area = pi * (radius * radius);
                Console.WriteLine($"Area: {area}");
            }

            void PrintCircleCircumference(int radius)
            {
                //double pi = 3.14159;
                double circumference = 2 * pi * radius;
                Console.WriteLine($"Circumference: {circumference}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            // EJERCICIO: Usar parametros de tipo y de valor y referencia

            /* Parámetros pasados por valor y pasados por referencia
             
             * Cuando se pasa un argumento a un método, los valores de las variables de tipo valor se copian 
               en el método. Cada variable tiene su propia copia del valor, por lo que la variable original 
               no se modifica.
               
             * Con los tipos de referencia, la dirección del valor se pasa al método. La variable dada al método 
               hace referencia al valor en esa dirección, por lo que las operaciones en esa variable afectan al valor 
               al que hace referencia la otra.
            */

            // Prueba de paso por VALOR:
            Console.WriteLine("Pass argument by Value");

            int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a,b,c);
            Console.WriteLine($"Global Statement: {a} x {b} = {c}");

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                Console.WriteLine($"Inside Multiply Method: {a} x {b} = {c}");
            }

            /* Las variables "a", "b", "c" se pasan al metodo "Multiply". Los valores de las variables se 
               imprimen durante la ejecucion del metodo y se imprimen de nuevo una vez completado el metodo.

               Los enteros son tipos de valor, cuyos valores se copian cuando se pasan a metodos. ¿Cual cree que
               sera la salida de "c"?
                
               Output:
               inside Multiply method: 3 x 4 = 12
               global statement: 3 x 4 = 0

               Observe que el valor de "c" solo se modifica dentro del metodo "Multiply".
               Fuera del metodo "c" conserva su valor original.
            */

            Console.WriteLine();

            // Prueba de paso por REFERENCIA:
            Console.WriteLine("Pass arguments by reference");

            int[] array = [1, 2, 3, 4, 5];

            PrintArray(array);
            Clear(array);
            PrintArray(array);

            void PrintArray(int[] array)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

            void Clear(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }

            Console.WriteLine();

            //Prueba con cadenas
            Console.WriteLine("Pass argument type of string");

            /* Anterionmente, aprendion que las cadenas son un tipo inmutable. Aunque una cadena es un tipo 
               de referencia, a diferencia de una matriz, su valor no se puede modificar una vez asignado. Puede
               que se haya dado cuenta si ha utilizado metodos como "string.Replace" o "string.ToUpper". En esta 
               tarea aprendera a corregir un error comun que se encuentra al trabajar con cadenas.
            */

            string status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth(false);
            Console.WriteLine($"End: {status}");

            void SetHealth(bool isHealthy)
            {
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            // EJERCICIO: Metodos con parametros opcionales

            /* El leguaje C# permite el uso de parametros con nombre y opcionales.
               Estos tipos de parametros permiten seleccionar que argumentos quiere proporcionar al metodo,
               por lo que no esta restringido a la estructura definida en la firma del metodo.

             * Los argumentos con nombre permiten especificar el valor de un parametro con su nombre en lugar 
               de la posicion. Los parametros opcionales permiten omitir esos argumentos al llamar al metodo.

               En este ejercicio, aprendera a usar parametros con nombre y opcionales.

               --- CREAR UNA APLICACION PARA CONFIRMAR ASISTENCIA ---
               
               En esta tarea, creara una breve aplicacion para que los invitados confirmen su asistencia a 
               un evento. Los invitados indicaran el tamaño de su grupo y cualquier alergia. Tambien agregara
               la opcion para restringir las confirmaciones de asistencia a una lista de asistentes por invitacion
             */

            string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
            string[] rsvps = new string[10];
            int count = 0;

            RSVP("Rebecca", 1, "none", true);
            RSVP("Nadia", 2, "Nuts", true);
            RSVP("Linh", 2, "none", false);
            RSVP("Tony", 1, "Jackfruit", true);
            RSVP("Noor", 4, "none", false);
            RSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVPs();

            void RSVP(string name, int partySize, string allergies, bool inviteOnly)
            {
                if (inviteOnly)
                {
                    // search guesList before adding rsvp
                    bool found = false;

                    foreach(string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name:{name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }
        }
    }
}

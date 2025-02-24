using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module3
{
    class IteratorWhile
    {
        public static void RunIteratorWhile()
        {
            //Random random = new Random();
            //int current = 0;
            //int current = random.Next(1,11);

            /*do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            }
            while (current != 7);*/

            /*while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }

            Console.WriteLine($"Last Number: {current}");*/

            /*do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current); // Si el valor de current es mayor a 8, no va a escribir en la consola el valor ya que lo salta

            } while (current != 7);*/

            /*
            Desafío de la batalla del juego de rol
            En algunos juegos de rol, el personaje del jugador se enfrenta a personajes que no son de jugador, normalmente monstruos o "los malos". A veces, en una batalla cada personaje genera un valor aleatorio mediante dados y ese valor se resta de la puntuación de salud del adversario. Cuando la salud de cualquiera de los personajes llega a cero, pierden.

            En este desafío, esa interacción se reducirá a lo más básico. Un héroe y un monstruo comienzan con la misma puntuación de salud. Durante el turno del héroe, se generará un valor aleatorio que se restará de la salud del monstruo. Si la salud del monstruo es mayor que cero, tomará su turno y atacará al héroe. Mientras que la salud del héroe y del monstruo sea mayor que cero, el combate se reanudará.

            Desafío de código: escribir código para implementar las reglas de juego
            Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

            * Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
            * El héroe y el monstruo comenzarán con 10 puntos de salud.
            * Todos los ataques tendrán un valor comprendido entre 1 y 10.
            * El héroe ataca primero.
            * Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
            * Si la salud del monstruo es mayor que 0, puede atacar al héroe.
            * Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
            * Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
            * Imprima el ganador.
             */

            /*Random random = new Random();

            int heroHealth = 10;
            int monsterHealth = 10;

            do
            {
                int heroAtack = random.Next(1, 10);
                monsterHealth -= heroAtack;

                Console.WriteLine($"Monster was damaged and lost {heroAtack} health and now has {monsterHealth} health.");

                if (monsterHealth <= 0) continue;

                int monsterAtack = random.Next(1, 10);
                heroHealth -= monsterAtack;

                Console.WriteLine($"Hero was damaged and lost {monsterAtack} health and now has {heroHealth}");

            } while (monsterHealth > 0 && heroHealth > 0);

            Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins" : "Monster wins");*/

            /*string? readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);*/

            /*
            Proyecto de código 1: escritura de código que valida la entrada de enteros
            Estas son las condiciones que el primer proyecto de codificación debe implementar:
            
            La solución debe incluir una iteración do-while o while.
            
            Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.
            
            Dentro del bloque de iteración:
            
            La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
            La solución debe asegurarse de que la entrada es una representación válida de un entero.
            Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
            La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
            Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
             */

            /*int numericValue = 0;
            bool validNumber = false;

            Console.WriteLine($"Enter an integer value between 5 and 10");

            do
            {
                string? readResult = Console.ReadLine();
                                           
                    if (int.TryParse(readResult,out numericValue))
                    {
                        if (numericValue >= 5 && numericValue <= 10) 
                        {
                            validNumber = true;
                        }
                        else
                        {
                            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Sorry, you entered an invalid number, please try again");
                    }            
                
            } while (!validNumber);

            Console.WriteLine($"Your input value ({numericValue}) has been accepted");*/

            /*
             * Estas son las condiciones que el segundo proyecto de codificación debe implementar:

            La solución debe incluir una iteración do-while o while.
            
            Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.
            
            Dentro del bloque de iteración:
            
            La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
            La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
            La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
            La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
            Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
            Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
            */

            //Administrador, Director o Usuario

            string? rol = "";
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

            do
            {   
                string? inputRol = Console.ReadLine();
                rol = (inputRol ?? "").Trim().ToLower();

                if (rol != "administrator" && rol != "manager" && rol != "user")
                    Console.WriteLine($"The role name that you entered, \"{inputRol}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                                              
                
            } while (rol != "administrator" && rol != "manager" && rol != "user");

            Console.WriteLine($"Your input value ({rol}) has been accepted.");
        }
    }
}

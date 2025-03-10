using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class MinigameApp
    {
        public static void RunMinigameApp () {
            /* Imaginemos que quiere crear su propio juego. Es posible que no este listo para desarrollar
               un juego completo, por lo que decide empezar lo mas pequeño posible. La idea que tiene
               es mover un personaje por la pantalla y hace que se consuma un objeto. El consumo de algun
               objeto puede afectar al estado del jugado. Para que el juego avanzara, queria regenerar 
               el objeto en otra ubicacion una vez que se hubiera consumido. Decide que tendra que usar
               metodos para mantener organizado el codigo del juego

               En este modulo, desarrollaremos estas caracteristicas de una aplicacion minijuego:

             * Una caracteristica para determinar si el jugador consumi el alimento   

             * Una caracteristica que actualiza el estado del jugador en funcion de los alimentos
               consumidos

             * Una caracteristica que pausa la velocidad de movimiento en funcion de los alimentos
               consumidos

             * Una caracteristica para regenerar los alimentos en otra ubicacion

             * Una opcion para finalizar el juego si se presiona un caracter no admitido

             * Una caracteristica para que el juego termine si se ha cambiado el tamaño de la ventana
               del terminal


             */

            Random random = new Random();
            Console.CursorVisible = false;
            int height = Console.WindowHeight - 1;
            int width = Console.WindowWidth - 5;
            bool shouldExit = false;

            // Console position of the player
            int playerX = 0;
            int playerY = 0;

            // Console position of the food
            int foodX = 0;
            int foodY = 0;

            // Available player and food strings
            string[] states = { "('-')", "(^-^)", "(X_X)" };
            string[] foods = { "@@@@@", "$$$$$", "#####" };

            // Current player string displayed in the Console
            string player = states[0];

            // Index of the current food
            int food = 0;

            InitializeGame();
            while (!shouldExit)
            {
                if (TerminalResized())
                {
                    Console.Clear();
                    Console.Write("Console was resized. Program exiting.");
                    shouldExit = true;
                }
                else
                {
                    if (PlayerIsFaster())
                    {
                        Move(1, false);
                    }
                    else if (PlayerIsSick())
                    {
                        FreezePlayer();
                    }
                    else
                    {
                        Move(otherKeysExit: false);
                    }
                    if (GotFood())
                    {
                        ChangePlayer();
                        ShowFood();
                    }
                }
            }

            // Returns true if the Terminal was resized 
            bool TerminalResized()
            {
                return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
            }

            // Displays random food at a random location
            void ShowFood()
            {
                // Update food to a random index
                food = random.Next(0, foods.Length);

                // Update food position to a random location
                foodX = random.Next(0, width - player.Length);
                foodY = random.Next(0, height - 1);

                // Display the food at the location
                Console.SetCursorPosition(foodX, foodY);
                Console.Write(foods[food]);
            }

            // Returns true if the player location matches the food location
            bool GotFood()
            {
                return playerY == foodY && playerX == foodX;
            }

            // Returns true if the player appearance represents a sick state
            bool PlayerIsSick()
            {
                return player.Equals(states[2]);
            }

            // Returns true if the player appearance represents a fast state
            bool PlayerIsFaster()
            {
                return player.Equals(states[1]);
            }

            // Changes the player to match the food consumed
            void ChangePlayer()
            {
                player = states[food];
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(player);
            }

            // Temporarily stops the player from moving
            void FreezePlayer()
            {
                System.Threading.Thread.Sleep(1000);
                player = states[0];
            }

            // Reads directional input from the Console and moves the player
            void Move(int speed = 1, bool otherKeysExit = false)
            {
                int lastX = playerX;
                int lastY = playerY;

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerX -= speed;
                        break;
                    case ConsoleKey.RightArrow:
                        playerX += speed;
                        break;
                    case ConsoleKey.Escape:
                        shouldExit = true;
                        break;
                    default:
                        // Exit if any other keys are pressed
                        shouldExit = otherKeysExit;
                        break;
                }

                // Clear the characters at the previous position
                Console.SetCursorPosition(lastX, lastY);
                for (int i = 0; i < player.Length; i++)
                {
                    Console.Write(" ");
                }

                // Keep player position within the bounds of the Terminal window
                playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
                playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

                // Draw the player at the new location
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(player);
            }

            // Clears the console, displays the food and player
            void InitializeGame()
            {
                Console.Clear();
                ShowFood();
                Console.SetCursorPosition(0, 0);
                Console.Write(player);
            }
        }
    }
}

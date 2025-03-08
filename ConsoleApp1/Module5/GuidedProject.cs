using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class GuidedProject
    {

        public static void RunGuidedProject()
        {
            // DESAFIO MINIJUEGO DE DADOS:

            /* Su desafio es diseñar un minijuego. El juego debe seleccionar un numero objetivo
               que sea un numero aleatorio entre 1 y 5 (ambos inclusive). El jugador debe tirar
               un dado de seis caras. Para ganar, el jugador debe sacar un numero mayor que el 
               numero objetivo. Al final de cada ronda, se debe preguntar al jugador si desea
               volver a jugar, y el juego debe continuar o terminar en consecuencia
            */

            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            void PlayGame()
            {
                Console.WriteLine("The game was played!");
                var play = true;

                while (play)
                {
                    var target = 2;
                    var roll = random.Next(1,6);

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(target, roll));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            bool ShouldPlay()
            {
                string resp = string.Empty;
                while (string.IsNullOrEmpty(resp))
                {
                    resp = Console.ReadLine();
                }
                return resp.ToLower() == "y" ? true : false;
            }

            string WinOrLose(int target, int roll)
            {
                return roll > target ? "You Win!" : "You lose";
            }
        }
    }
}

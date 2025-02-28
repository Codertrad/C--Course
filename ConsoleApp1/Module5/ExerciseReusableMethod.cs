using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class ExerciseReusableMethod
    {
        public static void RunExercise ()
        {
            /* Adivinar la suerte:
             
               Está ayudando a desarrollar un juego de rol multijugador masivo. 
               Cada jugador tiene una estadística de suerte que puede afectar a sus probabilidades de encontrar 
               tesoros raros. Cada día, un jugador puede hablar con un adivino en el juego que revela si su 
               estadística de suerte es alta, baja o neutral.
              
               Actualmente el juego tiene código para generar la suerte de un jugador, pero no es reutilizable. 
               La tarea consiste en crear un método tellFortune al que se pueda llamar en cualquier momento y 
               reemplazar la lógica existente por una llamada al método.
              
               En este desafío, se le proporciona un código de partida. Debe decidir cómo crear el método 
               tellFortune y cómo llamarlo.
            */

            Random random = new Random();
            int luck = random.Next(40);

            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

            void TellFortune ()
            {
                Console.WriteLine("A fortune teller whispers the following words:");
                string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{text[i]} {fortune[i]} ");
                }
                Console.WriteLine();
            };

            TellFortune();
        }
    }
}

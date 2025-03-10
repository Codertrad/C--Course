using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module5
{
    class AppZoo
    {
        public static void RunApp()
        {
            /* Va a desarrollar una aplicacion que coordina las visitas escolares al zoo de masco
               tas contoso. El zoo es el hogar de 18 especies diferentes de animales. En el zoo,
               los alumnos visitantes se asignan a grupos y cada grupo tiene un conjunto de animales
               asignado. Despues de visitar un conjunto de animales, los alumnos rotaran en los 
               grupos hasta que hayan visto todos los animales del zoo de mascotas.

               De forma predeterminada, los alumnos se dividen en 6 grupos. Sin embargo, hay algunas
               clases que tienen un numero menor o mayor de alumnos, por lo que debe ajustarse el
               numero de grupos en consecuencia. Los animales tambien deben asignarse aleatoriamente
               a cada grupo, con el fin de que la experiencia sea siempre unica

               La especificacion del diseño de la aplicacion para el zoo de mascotas Contoso es la
               siguiente:

               - Actualmente hay 3 cologios de visita:
                * El colegio A tiene seis grupos de visita(numero predeterminado).
                * El colegio B tiene tres grupos de visita.
                * El colegio C tiene dos grupos de visita.

               - Para cada colegio de vistia, realice las siguientes tareas:
                * Aletorizar los animales.
                * Asignar los animales al numero correcto de grupos.
                * Imprimir el nombre del colegio.
                * Imprimir los grupos de animales.
             */

            string[] pettingZoo =
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals();
                string[,] group1 = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group1);
            }

            void RandomizeAnimals()
            {
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++)
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[r];
                    pettingZoo[r] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groups = 6)
            {
                string[,] result = new string[groups, pettingZoo.Length / groups];
                int start = 0;

                for (int i = 0; i < groups; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups)
            {
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++)
                    {
                        Console.Write($"{groups[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

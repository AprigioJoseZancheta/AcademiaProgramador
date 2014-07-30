using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosFixacao
{
    /* Crie umprograma que imprima na tela um triângulo de “*”*/
    class Exercio5
    {
        static void Main5()
        {
            /*for (int i = 0; i < 4; i++)
            {
                string s = "*";
                for (int l = 1; l < 6; l++)
                {
                    Console.WriteLine(s);
                    s += "*";
                }
            }*/

            for (int i = 0; i < 3; i++)
            {
                string s1 = "";
                string s2 = "**********";
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(s1);
                    Console.WriteLine(s2);
                    s1 += " ";
                }
            }

            Console.ReadKey();
        }
    }
}
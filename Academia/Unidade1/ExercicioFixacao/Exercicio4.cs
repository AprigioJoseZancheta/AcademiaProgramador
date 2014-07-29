using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosFixacao
{
    /*Faça um programa que percorra todos os números de 1 até 100. Para os números múltiplos de 4, 
    imprima a palavra “PI”, e para os outros, imprima o próprio número.*/
    class Exercicio4
    {
        static void Main4()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("PI");
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
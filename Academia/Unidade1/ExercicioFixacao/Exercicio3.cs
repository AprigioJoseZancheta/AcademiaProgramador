using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosFixacao
{
    /*Faça um programa que percorra todos os números de 1  até 100. Para os números ímpares, deve
     ser impresso um  “*”, e para os números pares, deve ser impresso dois “**”.*/
    class Exercico3
    {
        static void Main3()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("*");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("**");
                }
            }
            Console.ReadKey();
        }
    }
}
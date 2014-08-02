using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioComplementar
{
    class Exercicio1
    {
        /*1)	Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e calcule a 
         * duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e 
         * terminar no dia seguinte.*/
        static void Main1()
        {
            try
            {
                Console.WriteLine("Informe o inicio do jogo: ");
                int inicioJogo = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o fim do jogo: ");
                int fimJogo = int.Parse(Console.ReadLine());
                int duracaoJogo = fimJogo - inicioJogo;
                if (duracaoJogo < 24)
                {
                    Console.WriteLine("Jogo terminou com a duração de {0} ", duracaoJogo);
                }
                else
                {
                    Console.WriteLine("Jogo excedeu o tempo de 24 horas");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Apenas Números");
            }
            Console.ReadKey();
        }
    }
}
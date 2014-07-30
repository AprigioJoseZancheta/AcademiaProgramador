using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioFixacao
{
    /*Serie Fibonacci*/
    class Exercicio7
    {
        static void Main7()
        {
            int novoNumero = 0;
            int numeroAtual = 1;
            int numeroAnterior = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(numeroAnterior);
                novoNumero = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = novoNumero;
                
            }
            Console.ReadKey();
        }
    }
}

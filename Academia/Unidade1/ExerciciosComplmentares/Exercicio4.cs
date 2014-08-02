using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioComplementar
{
    /*4)	Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima em estoque de um produto. 
     * Calcular e escrever a quantidade média ((quantidade média = quantidade máxima + quantidade mínima) /2). Se a quantidade em estoque for maior
     * ou igual a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'. */
    class Exercicio4
    {
        static void Main4()
        {
            int quantidadeAtualEstoque = 0;
            int quantidadeMaximaEstoque = 0;
            int quantidadeMinimaEstoque = 0;
            int quantidadeMediaEstoque = 0;
            try
            {
                Console.WriteLine("Infrome a quantidade atual em estoque: ");
                quantidadeAtualEstoque = int.Parse(Console.ReadLine());
                Console.WriteLine("Infrome a quantidade maxima em estoque: ");
                quantidadeMaximaEstoque = int.Parse(Console.ReadLine());
                Console.WriteLine("Infrome a quantidade minima em estoque: ");
                quantidadeMinimaEstoque = int.Parse(Console.ReadLine());

                quantidadeMediaEstoque = ((quantidadeMaximaEstoque - quantidadeMinimaEstoque) / 2);
                Console.WriteLine("Quantidade média em estoque {0} ", quantidadeMediaEstoque);
                if (quantidadeMediaEstoque >= quantidadeMinimaEstoque)
                {
                    Console.WriteLine("Não efetuar compra");
                }
                else
                {
                    Console.WriteLine("Efetuar a compra");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Somente Números");
            }
            Console.ReadKey();
        }
    }
}

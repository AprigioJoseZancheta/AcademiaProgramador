using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioComplementar
{
    /*3)	Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever o saldo atual 
     * (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior ou igual a zero escrever a mensagem 'Saldo Positivo', 
     * senão escrever a mensagem 'Saldo Negativo'. */
    class Exercicio3
    {
        static void Main3()
        {
            try
            {
                int numeroConta = 0;
                double saldo = 0;
                double debito = 0;
                double credito = 0;
                double saldoAtual = 0;

                Console.WriteLine("Informe o número da conta: ");
                numeroConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o saldo da conta: ");
                saldo = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o debito da conta: ");
                debito = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o credito da conta: ");
                credito = int.Parse(Console.ReadLine());

                saldoAtual = (saldo - debito) + credito;
                Console.WriteLine("Saldo Atual {0} ", saldoAtual);
                if (saldoAtual > 0)
                {
                    Console.WriteLine("Saldo Positivo");
                }
                else
                {
                    Console.WriteLine("Saldo Negativo");
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
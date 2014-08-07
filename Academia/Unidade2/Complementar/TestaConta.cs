using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Complementar
{
    class TestaConta
    {
        static void Main1(string[] args)
        {
            ContasBanco conta = new ContasBanco();
            Menu(conta);
            OpcaoEscolha(conta);
        }
       
        static void Menu(ContasBanco conta)
        {
            Console.WriteLine("Informe o número da conta: ");
            conta.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo da conta: ");
            conta.saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o limite: ");
            conta.limite = double.Parse(Console.ReadLine());
            Console.ReadKey();
        }
        static void OpcaoEscolha(ContasBanco conta)
        {
            Console.WriteLine("Deseja fazer alguma transação (s) Sim (n) Não");
            string escolha = Console.ReadLine();
            do
            {
                Console.WriteLine("Escolha uma opção\n (1) Saca\n (2) Deposita\n (3) Imprime Extrato");
                string opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1": Console.WriteLine("Digite o valor que deseja sacar: ");
                        double valor = double.Parse(Console.ReadLine());
                        conta.Saca(valor);
                        Console.Clear();
                        break;
                    case "2": Console.WriteLine("Digite o valor que deseja depositar: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Deposita(valor);
                        Console.Clear();
                        break;
                    case "3": Console.Clear();
                              Console.WriteLine("Extrato Impresso");
                              conta.ImprimiExtrato();     
                        break;

                    default: Console.WriteLine("Opção Invalida");
                        break;
                }
                Console.WriteLine("Deseja fazer alguma transação (s) Sim (n) Não");
                escolha = Console.ReadLine();
            } while (escolha != "n");
            
        }
        
    }

   
}

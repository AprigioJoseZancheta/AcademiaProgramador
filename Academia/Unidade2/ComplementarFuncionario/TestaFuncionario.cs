using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ComplementarFuncionario
{
    class TestaFuncionario
    {
        static void Main2()
        {
            Funcionario funcionario = new Funcionario();
            Menu(funcionario);
            EscolheOpcao(funcionario);
        }

        static void Menu(Funcionario funcionario)
        {
            Console.WriteLine("Digite o nome do funcionario: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionario: ");
            funcionario.salario = double.Parse(Console.ReadLine());
        }
        static void EscolheOpcao(Funcionario funcionario)
        {
            Console.WriteLine("Deseja alterar algum dado (s) Sim (n) Não ");
            string escolha = Console.ReadLine();
            do
            {
                Console.WriteLine("Escolha (1) Alterar Dados"
                                        +" (2) Visualisar Dados");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": Console.WriteLine("Digite o nome do funcionario: ");
                              funcionario.nome = Console.ReadLine();
                              Console.WriteLine("Digite o salario do funcionario: ");
                              funcionario.salario = double.Parse(Console.ReadLine());
                              Console.Clear();
                    break;
                    case "2": Console.Clear();
                              Console.WriteLine("Visualisando os Dados");
                              funcionario.MostraDados();
                    break;        
                    default: Console.WriteLine("Opção Invalida");
                        break;
                }
                Console.WriteLine("Deseja alterar algum dado (s) Sim (n) Não ");
                escolha = Console.ReadLine();
            } while (escolha != "n");
        }
    }
}

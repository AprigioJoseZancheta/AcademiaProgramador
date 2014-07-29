using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosFixacao
{
    /*Menu padrão*/
    class Exercicio_6
    {
        static void Main6()
        {
            Menu();
        }

        public static void Menu()
        {
            string opcao = "";
            Console.WriteLine(" MENU\n Digite(1) Padrão1\n Digite(2) Padrão2\n Digite(3) Padrão3\n Digite(4) Padrão4");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1": Console.WriteLine("Padrão 1");
                    break;
                case "2": Console.WriteLine("Padrão 2");
                    break;
                case "3": Console.WriteLine("Padrão 3");
                    break;
                case "4": Console.WriteLine("Padrão 4");
                    break;
                default: Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
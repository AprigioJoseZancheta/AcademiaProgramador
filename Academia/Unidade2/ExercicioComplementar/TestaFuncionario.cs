using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioComplementar
{
    class TestaFuncionario
    {
        static void Main2(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            funcionario1.nome = "Bill Gates";
            funcionario1.cargo = "Desenvolvedor";
            funcionario1.dataAdmissão = "12/13/1965";

            Funcionario funcionario2 = new Funcionario();

            funcionario2.nome = "Aprígio";
            funcionario2.cargo = "Desenvolvedor";
            funcionario2.dataAdmissão = "12/03/2010";

            Console.WriteLine("Nome Funcionario {0}, Cargo {1}, Data Admissão {2} ", funcionario1.nome, funcionario1.cargo, funcionario1.dataAdmissão);
            Console.WriteLine("Nome Funcionario {0}, Cargo {1}, Data Admissão {2} ", funcionario2.nome, funcionario2.cargo, funcionario2.dataAdmissão);
            Console.ReadKey();

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Funcionario
{
    class TestaFuncionario
    {
        static void Main1()
        {
            /*Funcionario funcionario = new Funcionario();

            funcionario.nome = "Aprigio";
            funcionario.salario = 1300;
            funcionario.ConsultaDadosFuncionario();

            funcionario.AumentaSalario(500);
            funcionario.ConsultaDadosFuncionario();*/

            Gerente gerente = new Gerente();

            gerente.nome = "Tio Everton";
            gerente.salario = 1200;
            gerente.DadosGerente();
            gerente.AumentaSalario(0.450);
            gerente.DadosGerente();
            Console.ReadKey();

        }
    }
}

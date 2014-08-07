using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ComplementarFuncionario
{
    class Funcionario
    {
        public string nome;
        public double salario = 200;

        public void MostraDados()
        {
            Console.WriteLine("Nome {0}, Salario {1} ", nome, salario);
        }
    }
}

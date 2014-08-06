using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Funcionario
{
    class Funcionario
    {
        public string nome;
        public double salario;

        public void AumentaSalario(double valor)
        {
            salario += valor;
        }
        public void ConsultaDadosFuncionario()
        {
            Console.WriteLine("Nome {0}, Salario {1} ", nome, salario);
        }
    }
}

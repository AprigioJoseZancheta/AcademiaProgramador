using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Funcionario
{
    class Gerente
    {
        public string nome;
        public double salario;

        public void AumentaSalario()
        {
            this.AumentaSalario(0.1);
        }
        public void AumentaSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
        public void DadosGerente()
        {
            Console.WriteLine("Nome {0}, Salario {1} ", nome, salario);
        }
    }
}

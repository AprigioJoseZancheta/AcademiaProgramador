using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioFixacao
{
    class TestaValoresPadrao
    {
        private static void Main3()
        {
            Conta conta = new Conta();

            Console.WriteLine("Número Conta {0}, Limite Conta {1}, Saldo Conta {2} ", conta.numero, conta.limite, conta.saldo);
            Console.ReadKey();
        }
    }
}

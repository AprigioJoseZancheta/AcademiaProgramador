using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioFixacao
{
    class TestaConta
    {
        static void Main2(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.numero = 111222;
            conta1.limite = 500;
            conta1.saldo = 1000;

            Conta conta2 = new Conta();
            conta2.numero = 3334444;
            conta2.limite = 600;
            conta2.saldo = 1300;

            Console.WriteLine("Número Conta {0}, Limite Conta {1}, Saldo Conta {2} ", conta1.numero, conta1.limite, conta1.saldo);
            Console.WriteLine("Número Conta {0}, Limite Conta {1}, Saldo Conta {2} ", conta2.numero, conta2.limite, conta2.saldo);
            Console.ReadKey();
        }
    }
}

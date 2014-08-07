using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Banco
{
    class TestaConta
    {
        static void Main3()
        {
            Conta origem = new Conta(1223);
            origem.saldo = 500;
            Console.WriteLine("Saldo Origem {0} ", origem.saldo);

            Conta destino = new Conta(1344);
            origem.Transferencia(destino, 300);
            Console.WriteLine("Saldo Destino {0} ", destino.saldo);
            Console.WriteLine("Saldo Origem apos fazer a transferencia {0} ", origem.saldo);
            Console.ReadKey();
        }
    }
}

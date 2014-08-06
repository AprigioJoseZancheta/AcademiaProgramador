using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioAssociacao
{
    class ContaEAgencia
    {
        static void Main2(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1111;
            c1.limite = 500;
            c1.saldo = 700;

            Conta c2 = new Conta();
            c2.numero = 2222;
            c2.limite = 600;
            c2.saldo = 1200;

            Agencia a = new Agencia();

            a.numero = 2302;

            c1.agencia = a;
            c2.agencia = a;

            Console.WriteLine("Número Conta {0}, Limite {1}, Saldo {2}, Agencia {3} ", c1.numero, c1.limite, c1.saldo, c1.agencia.numero);
            Console.WriteLine("Número Conta {0}, Limite {1}, Saldo {2}, Agencia {3} ", c2.numero, c2.limite, c2.saldo, c2.agencia.numero);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Banco
{
    class TestaConta
    {
        static void Main()
        {
            CartaoDeCredito cdc = new CartaoDeCredito(2333);
            Agencia a = new Agencia(1333);
            Conta c = new Conta(a);

            c.agencia = a;
            c.ImprimeExtrato();
            c.Deposita(1000);
            c.ImprimeExtrato();

            c.Saca(500);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo Disponível: " + saldoDisponivel);
            Console.ReadKey();
        }
    }
}

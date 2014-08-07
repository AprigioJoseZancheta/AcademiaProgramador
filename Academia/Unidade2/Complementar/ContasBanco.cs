using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Complementar
{
    class ContasBanco
    {
        public int numero;
        public double limite;
        public double saldo;

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void ImprimiExtrato()
        {
            Console.WriteLine("Saldo {0} ", this.saldo);
        }
    }
}

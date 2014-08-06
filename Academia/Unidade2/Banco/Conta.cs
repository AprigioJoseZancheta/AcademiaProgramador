using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Banco
{
    class Conta
    {
        public double saldo;
        public double limite = 100;
        public Agencia agencia;
        private int p;

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public Conta(int p)
        {
            this.p = p;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine(" Saldo {0}, Limite {1} ", this.saldo, this.limite);
            this.ImprimeExtrato(15);
        }
        public void ImprimeExtrato(int dia)
        {
            
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
} 

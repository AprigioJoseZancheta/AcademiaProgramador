using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioFixacao
{
    class Program
    {
        static void Main1(string[] args)
        {
            Cliente cliente1 = new Cliente();
            CartaoDeCredito cartao1 = new CartaoDeCredito();
            Agencia agencia1 = new Agencia();

            cliente1.codigo = 111111;
            cliente1.nome = "Aprigio";
            cartao1.numero = 222222;
            cartao1.dataDeValidade = "19/12";
            agencia1.numero = 11222;

            Cliente cliente2 = new Cliente();
            CartaoDeCredito cartao2 = new CartaoDeCredito();
            Agencia agencia2 = new Agencia();

            cliente2.codigo = 222222;
            cliente2.nome = "Fabiane";
            cartao2.numero = 3333333;
            cartao2.dataDeValidade = "28/2";
            agencia2.numero = 333444;

            Console.WriteLine("Código {0} , Nome {1}, Número Cartão {2} , Data Validade Cartão {3}, Número Agencia {4}", cliente1.codigo, cliente1.nome, cartao1.numero, cartao1.dataDeValidade, agencia1.numero);
            Console.WriteLine("********************************************************");
            Console.WriteLine("Código {0} , Nome {1}, Número Cartão {2} , Data Validade Cartão {3}, Número Agencia {4}", cliente2.codigo, cliente2.nome, cartao2.numero, cartao2.dataDeValidade, agencia2.numero);
            Console.ReadKey();
        }
    }
}

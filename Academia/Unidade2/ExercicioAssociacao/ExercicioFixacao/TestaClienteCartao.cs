using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioAssociacao
{
    class TestaClienteCartao
    {
        static void Main1()
        {
            
            CartaoDeCredito cartao1 = new CartaoDeCredito();
            
            cartao1.numero = 111111;
            cartao1.dataValidade = "13/04/2014";

            Cliente c = new Cliente();
            c.codigo = 2305;
            c.nome = "Aprigio";

            CartaoDeCredito cartao2 = new CartaoDeCredito();
            cartao2.numero = 222222;
            cartao2.dataValidade = "12/08/2014";

            cartao2.cliente = c;
            cartao1.cliente = c;

            Console.WriteLine("Número Cartão {0}, Data Validade {1}, Nome Cliente {2} ", cartao1.numero, cartao1.dataValidade, cartao1.cliente.nome);
            Console.WriteLine("Número Cartão {0}, Data Validade {1}, Nome Cliente {2} ", cartao2.numero, cartao2.dataValidade, cartao2.cliente.nome);
            Console.ReadKey();
            
        }
    }
}

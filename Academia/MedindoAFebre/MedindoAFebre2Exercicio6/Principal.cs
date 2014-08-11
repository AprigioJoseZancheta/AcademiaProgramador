using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebre.MedindoAFebre2Exercicio6
{
    class Principal
    {
        
        static void Main()
        {
            ContaLuz conta1 = new ContaLuz();
            conta1.CadastraConta(new DateTime(2014, 03, 21), new DateTime(2014, 03, 23), 160, 11222, 360, 60.5);
            conta1.MostraCadastro();

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            ContaLuz conta2 = new ContaLuz();
            conta2.CadastraConta(new DateTime(2014, 03, 21), new DateTime(2014, 03, 23), 110, 223333, 310, 52.5);
            conta2.MostraCadastro();
            Console.ReadKey();
        }
      
        
    }
}

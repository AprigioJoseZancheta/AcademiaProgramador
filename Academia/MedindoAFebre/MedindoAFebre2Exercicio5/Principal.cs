using MedindoAFebre.MedindoAFebre2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebre.MedindoAFebre2Exercicio5
{
    class Principal
    {
        static void Main1()
        {
            Cd cd1 = new Cd();

            cd1.Cadastrar("Album Zé Ramalho","19/09/2014","Zé Ramalho",true);
            cd1.MostraCadastro();
            Console.ReadKey();
        }
    }
}

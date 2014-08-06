using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioComplementar
{
    class TestaAluno
    {
        static void Main1()
        {
            Aluno aluno1 = new Aluno();

            aluno1.nome = "Aprigio";
            aluno1.rg = 122233;
            aluno1.dataNascimento = "19/12/1981";

            Aluno aluno2 = new Aluno();

            aluno2.nome = "Fabiane";
            aluno2.rg = 3334444;
            aluno2.dataNascimento = "12/09/1982";

            Console.WriteLine("Nome Aluno {0}, Rg Aluno {1}, Data Nascimento Aluno {2} ", aluno1.nome, aluno1.rg, aluno1.dataNascimento);
            Console.WriteLine("Nome Aluno {0}, Rg Aluno {1}, Data Nascimento Aluno {2} ", aluno2.nome, aluno2.rg, aluno2.dataNascimento);
            Console.ReadKey();
        }
    }
}

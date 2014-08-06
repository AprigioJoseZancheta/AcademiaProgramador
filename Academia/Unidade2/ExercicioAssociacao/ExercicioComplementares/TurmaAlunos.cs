using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioAssociacao.ExercicioComplementares
{
    class TurmaAlunos
    {
        static void Main2()
        {
            Aluno aluno1 = new Aluno();

            aluno1.nome = "Aprigio";
            aluno1.rg = 123456;
            aluno1.dataNascimento = "19/12/1981";

            Turma t = new Turma();

            t.periodo = "Vespertino";
            t.serie = "1ª";
            t.sigla = "MBB";
            t.tipoEnsino = "Médio";

            aluno1.turma = t;

            Console.WriteLine("Nome {0}, Rg {1}, Data Nascimento {2}, Periodo {3}, Série {4}, Sigla {5}, Tipo Ensino {6} ", aluno1.nome, aluno1.rg, aluno1.dataNascimento, aluno1.turma.periodo, aluno1.turma.serie, aluno1.turma.sigla, aluno1.turma.tipoEnsino);
            Console.ReadKey();
        }
    }
}

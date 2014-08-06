using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExercicioComplementar
{
    class TestaTurma
    {
        static void Main3()
        {
            Turma turma1 = new Turma();

            turma1.periodo = "Matutino";
            turma1.serie = "2ª";
            turma1.sigla = "Alfa";
            turma1.tipoEnsino = "Fundamental";

            Turma turma2 = new Turma();

            turma2.periodo = "Noturno";
            turma2.serie = "4ª";
            turma2.sigla = "Beta";
            turma2.tipoEnsino = "Superior";

            Console.WriteLine("Periodo {0}, Série {1}, Sigla {2}, Tipo Ensino {3} ", turma1.periodo, turma1.serie, turma1.sigla, turma1.tipoEnsino);
            Console.WriteLine("Periodo {0}, Série {1}, Sigla {2}, Tipo Ensino {3} ", turma2.periodo, turma2.serie, turma2.sigla, turma2.tipoEnsino);
            Console.ReadKey();
        }
    }
}

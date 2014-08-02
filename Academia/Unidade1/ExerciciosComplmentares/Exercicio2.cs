
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioComplementar
{
    class Exercicio2
    {
        /*2)	A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra, 
         * cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que leia o número de horas trabalhadas em um mês, 
         * o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas 
         * (considere que o mês possua 4 semanas exatas). */
        static void Main2()
        {
            double horasTrabalhadasMes = 0;
            double salarioHora = 0;
            double horaExtra = 0;
            double salarioTotal = 0;
            try
            {
                Console.WriteLine("Informe o salario por hora: ");
                salarioHora = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe quantas horas o funcionario trabalhou no mês: ");
                horasTrabalhadasMes = int.Parse(Console.ReadLine());

                if (horasTrabalhadasMes > 160)
                {
                    horaExtra = (salarioHora * 0.5) + salarioHora;
                    salarioTotal = (160 * salarioHora) + (horaExtra * (horasTrabalhadasMes - 160));
                    Console.WriteLine("Salario por hora {0} ", salarioHora + " R$");
                }
                else
                {
                    salarioTotal = salarioHora * horasTrabalhadasMes;
                }
                Console.WriteLine("Salario Total {0} ", salarioTotal);

            }
            catch (Exception)
            {

                Console.WriteLine("Somente Números");
            }
            Console.ReadKey();
        }
    }
}
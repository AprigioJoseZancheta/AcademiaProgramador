
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExercicioComplementar
{
    /*5)	Um posto está vendendo combustíveis com a seguinte tabela de descontos: 
    Álcool 	até 20 litros, desconto de 3% por litro:
	Acima de 20 litros, desconto de 5% por litro. 
    Gasolina até 20 litros, desconto de 4% por litro:
	Acima de 20 litros, desconto de 6% por litro.
    Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), 
     * calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90. */
    class Exercicio5
    {
        static void Main()
        {
            string opcao = "";
            double quantidadeLitros = 0;
            double alcoolAteVinte = 0;
            double alcoolMaisVinte = 0;
            double gasolinaAteVinte = 0;
            double gasolinaMaisVinte = 0;
            double precoAlcool = 2.90;
            double precoGasolina = 3.30;

            Console.WriteLine("Digite (a) Alcool ou (g) Gasolina");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "a": Console.WriteLine("Informe a quantidade de litros: ");
                    quantidadeLitros = double.Parse(Console.ReadLine());
                    if (quantidadeLitros <= 20)
                    {
                        alcoolAteVinte = ((precoAlcool * 0.03) + precoAlcool * quantidadeLitros);
                        Console.WriteLine("Preço {0} ", alcoolAteVinte);
                    }
                    else
                    {
                        alcoolMaisVinte = ((precoAlcool * 0.05) + precoAlcool * quantidadeLitros);
                        Console.WriteLine("Preço {0} ", alcoolMaisVinte);
                    }
                    break;
                case "g": Console.WriteLine("Informe a quantidade de litros: ");
                    quantidadeLitros = double.Parse(Console.ReadLine());
                    if (quantidadeLitros <= 20)
                    {
                        gasolinaAteVinte = ((precoGasolina * 0.04) + precoGasolina * quantidadeLitros);
                        Console.WriteLine("Preço {0} ", gasolinaAteVinte);
                    }
                    else
                    {
                        gasolinaMaisVinte = ((precoGasolina * 0.06) + precoGasolina * quantidadeLitros);
                        Console.WriteLine("Preço {0} ", gasolinaMaisVinte);
                    }
                    break;
                default: Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
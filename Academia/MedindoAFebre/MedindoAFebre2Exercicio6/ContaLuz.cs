using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebre.MedindoAFebre2Exercicio6
{
    class ContaLuz
    {
        public DateTime dataLeitura;
        public DateTime dataPagamento;
        public double mediaConsumo;
        public int numeroLeitura;
        public int quantidadeKw;
        public double valorApagar;
        public double maiorConsumo;
        public double menorConsumo = 999;

        public void CadastraConta(DateTime dataLeitura, DateTime dataPagamento, double mediaConsumo, int numeroLeitura, int quantidadeKw, double valorApagar)
        {
            this.dataLeitura = dataLeitura;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
            this.numeroLeitura = numeroLeitura;
            this.quantidadeKw = quantidadeKw;
            this.valorApagar = valorApagar;
        }
        public void MaiorConsumo()
        {
            if (maiorConsumo > mediaConsumo)
            {
                maiorConsumo = mediaConsumo;
            }
        }
        public void MenorConsumo()
        {
            if (menorConsumo < mediaConsumo)
            {
                menorConsumo = mediaConsumo;
            }
        }

        public void MostraCadastro()
        {
            Console.WriteLine(" Data Leitura: {0}\n Data Pagamento: {1}\n Media Consumo: {2}\n NumeroLeitura: {3}\n Quantidade de Kw: {4}\n Valor a Pagar: {5} ", dataLeitura, dataPagamento, mediaConsumo, numeroLeitura, quantidadeKw, valorApagar);
        }
    }
}

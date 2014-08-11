using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebre.MedindoAFebre2
{
    class Cd
    {
        public string tituloCd;
        public string dataLacamento;

        Musico musico = new Musico();

        public void Cadastrar(string tituloCd, string dataLacamento, string nome, bool musicoSolo)
        {
            this.tituloCd = tituloCd;
            this.dataLacamento = dataLacamento;
            this.musico.nome = nome;
            this.musico.musicoSolo = musicoSolo;
        }
        public void MostraCadastro()
        {
            Console.WriteLine(" Titulo Cd: {0}\n Data Lançamento: {1}\n Nome Artista: {2}\n Músico Solo: {3}", tituloCd, dataLacamento, musico.nome, musico.musicoSolo);
        }
    }
}

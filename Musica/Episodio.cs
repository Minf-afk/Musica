using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Musica
{
    public class Episodio
    {
        public int Duracao { get; set; }
        public int Ordem { get; }
        public string Descri { get; set; }
        public string Titulo { get; set; }

        public List<string> Convidado { get; } = new();

        public Episodio(int dur, int ordem, string descri, string titulo)
        {
            Duracao = dur;
            Ordem = ordem;
            Descri = descri;
            Titulo = titulo;
        }

        void AdicionarConvidados(string nome)
        {
            if(!string.IsNullOrWhiteSpace(nome))
                Convidado.Add(nome);
        }

    }
}

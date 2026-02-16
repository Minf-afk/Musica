using System;
using System.Collections.Generic;

namespace Musica
{
    public class Episodio
    {
        public int Duracao { get; set; }
        public int Ordem { get; private set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }

        public List<string> Convidados { get; } = new();

        public Episodio(int dur, int ordem, string descri, string titulo)
        {
            Duracao = dur;
            Ordem = ordem;
            Descricao = descri;
            Titulo = titulo;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Episódio {Ordem}: {Titulo}");
            Console.WriteLine($"Tema: {Descricao}");
            Console.WriteLine($"Duração: {Duracao} min");

            if (Convidados.Count > 0)
                Console.WriteLine("Convidados: " + string.Join(", ", Convidados));
        }

        public void AdicionarConvidado(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
                Convidados.Add(nome);
        }
    }
}

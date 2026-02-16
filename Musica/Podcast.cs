using System;

namespace Musica
{
    public class Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios { get; private set; }

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
            TotalEpisodios = 0;
        }

        public void AdicionarEpisodio()
        {
            TotalEpisodios++;
        }

        public void ExibirDetalhes()
        {
            AdicionarEpisodio();
            Console.WriteLine($"Host do dia: {Host} , dando inicio ao episódio do dia: {Nome}\n");
            Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        }

    }
}

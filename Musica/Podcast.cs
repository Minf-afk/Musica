using System;

namespace Musica
{
    public class Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios { get; private set; }

        private List<Episodio> episodios { get; } = new();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
            TotalEpisodios = 0;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
            TotalEpisodios++;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast: {Nome}");
            Console.WriteLine($"Host: {Host}");
            Console.WriteLine($"Total de episódios: {TotalEpisodios}");
            Console.WriteLine("----------------------------------");

            foreach (var ep in episodios.OrderBy(e => e.Ordem))
            {
                ep.ExibirDetalhes();
                Console.WriteLine();
            }
        }

    }
}

using Musica;

var podcast = new Podcast("Mateus", "Iniciando C#");

var ep1 = new Episodio(dur: 25, ordem: 1, descri: "Classes, objetos e construtores", titulo: "Episódio 1");
ep1.AdicionarConvidado("Alexandre");
ep1.AdicionarConvidado("Maria");

var ep2 = new Episodio(dur: 30, ordem: 2, descri: "Encapsulamento e propriedades", titulo: "Episódio 2");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();

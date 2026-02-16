using Musica;

var podcast = new Podcast("Mateus", "Iniciando C#");

var ep1 = new Episodio(dur: 25, ordem: 1, descri: "Classes, objetos e construtores", titulo: "Primeiros passos do desenvolvimento");
ep1.AdicionarConvidado("Alexandre");
ep1.AdicionarConvidado("Maria");

var ep2 = new Episodio(dur: 30, ordem: 2, descri: "Encapsulamento e propriedades", titulo: "Continuidade em POO");
ep2.AdicionarConvidado("Rafael");
ep2.AdicionarConvidado("Mari");

var ep3 = new Episodio(dur: 65, ordem: 3, descri: "Polimorfismo e Entidades", titulo: "Iniciando a parte Intermediária");
ep3.AdicionarConvidado("Luiz");
ep3.AdicionarConvidado("Fred");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();

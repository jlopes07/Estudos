Episodio ep1 = new(1, "Tecnicas de facilitacao", 45);
ep1.AdicionarConvidados("Amanda");
ep1.AdicionarConvidados("Carla");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Julio");
ep2.AdicionarConvidados("Abner");
ep2.AdicionarConvidados("Glaucia");

Podcast podcast = new("Aprendendo a programar", "João");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

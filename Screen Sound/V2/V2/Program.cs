using V2;

Episodio ep01 = new Episodio("Tecnicas de interpolação", 120, 01);
ep01.AdicionarConvidado("Kaio");
ep01.AdicionarConvidado("William");

Episodio ep02 = new Episodio("Tecnicas de facilitação", 180, 02);
ep02.AdicionarConvidado("Kaio");
ep02.AdicionarConvidado("William");
 
Podcast podcast01 = new Podcast("Podcast Especial", "Gustavo Guanabara ");
podcast01.AdicionarEpsodios(ep01);
podcast01.AdicionarEpsodios(ep02);

podcast01.ExibirDetalhes();
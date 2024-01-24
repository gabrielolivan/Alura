Album albumDoQueen = new Album("A night at the opera");

Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = false,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true,
};

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);

// albumDoQueen.ExibirMusicasDoAlbum();

// queen.AdicionarAlbum(albumDoQueen);
// queen.ExibirDiscografia();

Episodio ep1 = new(1, "tecnica de facilitacao", 45);
Episodio ep2 = new(2, "tecnica de corrida", 90);

ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Rogerio");

Podcast pd1 = new("Pocast1", "Gabriel");
pd1.AdicionarEpisodio(ep2);
pd1.AdicionarEpisodio(ep1);
pd1.ExibirDetalhes();
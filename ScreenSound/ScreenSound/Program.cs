Genero rock = new Genero();
rock.Nome = "Rock";
rock.Descricao = "Gênero musical derivado do rock and roll dos anos 1950.";

Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A Night At The Opera", queen, rock);

Musica musica1 = new Musica("Love of my life", queen)
{
    Duracao = 213,
    Disponivel = true,
    Genero = rock
};

Musica musica2 = new Musica("Bohemian Rhapsody", queen)
{
    Duracao = 354,
    Disponivel = false,
    Genero = rock
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Episodio episodio1 = new Episodio(1, "A revolução da música digital", 90)
{
    Convidados = new List<string> { "Monark", "Jovem Nerd" }
};

Episodio episodio2 = new Episodio(2, "A revolução das máquinas", 60)
{
    Convidados = new List<string> { "Monark", "André Diamand" }
};

Podcast podcast = new Podcast("Monark", "Café Brasil");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();

//albumDoQueen.ExibirMusicasDoAlbum();

//rock.ExibirMusicasDoGenero();
//rock.ExibirAlbunsDoGenero();
//rock.ExibirTudoDoGenero();

//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirAlbunsDaBanda();
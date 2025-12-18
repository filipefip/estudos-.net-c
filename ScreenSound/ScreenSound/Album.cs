class Album
{
    public Album(string nome, Banda artista, Genero genero)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.Genero = genero;
    }
    private Genero _genero;
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public Banda Artista { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public Genero Genero { 
        get => this._genero; 
        private set
        {
            this._genero = value;
            this._genero.Albuns.Add(this);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        this.musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do álbum {this.Nome}: \n");
        foreach (var musica in this.musicas)
        {
            Console.WriteLine($"- Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {this.DuracaoTotal}");
        Console.WriteLine();
    }
}
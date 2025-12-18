class Genero {
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<Musica> Musicas { get; set; } = new List<Musica>();
    public List<Album> Albuns { get; set; } = new List<Album>();
    public string DescricaoDetalhada => $"Gênero: {Nome}\nDescrição: {Descricao}\nNúmero de músicas: {Musicas.Count}\n";

    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"Músicas do Genero: {this.Nome}\n");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- Música: {musica.Nome} por {musica.Artista.Nome}");
        }
        Console.WriteLine();
    }

    public void ExibirAlbunsDoGenero()
    {
        Console.WriteLine($"Músicas do Genero: {this.Nome}\n");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- Música: {musica.Nome} por {musica.Artista.Nome}");
        }
        Console.WriteLine();
    }

    public void ExibirTudoDoGenero()
    {
        Console.WriteLine(this.DescricaoDetalhada);
        Console.WriteLine($"Músicas do Genero: {this.Nome}\n");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome} por {musica.Artista.Nome}");
        }
        Console.WriteLine($"\nÁlbuns do Genero: {this.Nome}\n");
        foreach (var album in Albuns)
        {
            Console.WriteLine($"- {album.Nome} por {album.Artista.Nome}");
        }
        Console.WriteLine();
    }
}
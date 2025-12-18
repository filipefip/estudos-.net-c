class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome { get; set; }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirAlbunsDaBanda()
    {
        Console.WriteLine($"Álbuns da banda {Nome}:");
        foreach (Album album in albums)
        {
            Console.WriteLine($"- {album.Nome}");
        }
    }
}
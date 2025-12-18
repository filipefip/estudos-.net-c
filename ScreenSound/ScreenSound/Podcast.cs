class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> Episodios = new();
    public int TotalEpisidios => Episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Pocast: {this.Nome} - Host: {this.Host}\n");
        Console.WriteLine("Lista de episódios: ");
        foreach (Episodio episodio in Episodios.OrderBy(e => e.ID))
        {
            Console.WriteLine($"- {episodio.Resumo}");
        }
    }
}
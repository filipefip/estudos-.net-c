class Musica
{
    public Musica(string nome, Banda artista)
    {
        this.Nome = nome;
        this.Artista = artista;
    }
    private Genero _genero;
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero
    {
        get => _genero;
        set
        {
            _genero = value;
            _genero.Musicas.Add(this);
        }
    }
    public string DescricaoResumida =>
        $"A música ${Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}
namespace Alura.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> Filmes { get; set; }
    public string Resumo => $"{Nome}, {Idade} anos. Filmes: {string.Join(", ", Filmes.Select(filme => filme.Titulo))}\n";

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }

    public void AdiconarFilmeDoArtista(Filme filme)
    {
        Filmes.Add(filme);
    }
}
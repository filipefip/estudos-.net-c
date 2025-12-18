namespace Alura.Filmes;

class Filme
{
    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = new List<Artista>();
        elenco.ForEach(artista => RegistrarElenco(artista));
    }

    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }
    public string Resumo => $"{Titulo}, duração de {Duracao} minutos. Elenco: {string.Join(", ", Elenco.Select(artista => artista.Nome))}\n";

    public void RegistrarElenco(Artista artista)
    {
        Elenco.Add(artista);
        artista.AdiconarFilmeDoArtista(this);
    }
}
using System.Text.Json.Serialization;

namespace PraticandoAPI.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string? Autor { get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao { get; set; }
    public void ExibirDetalhesLivro()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Gênero: {Genero}, Ano de Publicação: {AnoPublicacao}\n");
    }
}

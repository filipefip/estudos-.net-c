using System.Text.Json.Serialization;

namespace PraticandoAPI.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    private int anoLancamento;

    private double nota;

    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }

    [JsonPropertyName("imDbRating")]
    public string Nota { set => nota = double.Parse(value.ToString()); }

    [JsonPropertyName("year")]
    public string AnoLancamento { set => anoLancamento = int.Parse(value.ToString()); }

    public void ExibirDetalhesFilme()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano de Lançamento: {anoLancamento}");
        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Equipe: {Equipe}");
    }
}
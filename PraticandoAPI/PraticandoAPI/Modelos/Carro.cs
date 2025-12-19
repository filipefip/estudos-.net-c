using System.Text.Json.Serialization;

namespace PraticandoAPI.Modelos;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    public void ExibirDetalhesCarro()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

namespace PraticandoAPI.Modelos;

internal class Pais
{
    public string? nome { get; set; }
    public string? capital { get; set; }
    public int populacao { get; set; }
    public string? continente { get; set; }
    public string? idioma { get; set; }

    public void ExibirDetalhesPais()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Capital: {this.capital}");
        Console.WriteLine($"Populacao: {this.populacao}");
        Console.WriteLine($"Continente: {this.continente}");
        Console.WriteLine($"Idioma: {this.idioma}");
    }
}

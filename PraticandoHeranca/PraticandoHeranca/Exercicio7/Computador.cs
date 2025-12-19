namespace PraticandoHeranca.Exercicio7;

internal class Computador
{
    public Processador Processador { get; }
    public PlacaMae PlacaMae { get; }
    public Computador(Processador processador, PlacaMae placaMae)
    {
        this.Processador = processador;
        this.PlacaMae = placaMae;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {Processador.Marca} {Processador.Modelo}");
        Console.WriteLine($"Placa-Mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
    }
}

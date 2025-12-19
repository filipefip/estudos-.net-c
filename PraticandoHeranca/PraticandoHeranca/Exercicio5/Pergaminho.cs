namespace PraticandoHeranca.Exercicio5;

internal class Pergaminho : ItemDigital
{
    public string Conteudo { get; }
    public Pergaminho(string titulo, string conteudo) : base (titulo)
    {
        this.Conteudo = conteudo;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Titulo: {this.Titulo}");
        Console.WriteLine($"Descricao: {this.Conteudo}");
    }
}

namespace PraticandoHeranca.Exercicio9;

internal class Consultoria : IServico
{
    public string Titulo { get; }
    public Funcionario Funcionario { get; }

    public Consultoria(string titulo, Funcionario funcionario)
    {
        this.Titulo = titulo;
        this.Funcionario = funcionario;
    }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {this.Titulo}");
        Console.WriteLine($"Responsável: {Funcionario.Nome} - Departamento: {Funcionario.Depatamento}");
    }
}

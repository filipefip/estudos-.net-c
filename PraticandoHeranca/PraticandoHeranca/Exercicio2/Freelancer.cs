namespace PraticandoHeranca.Exercicio2;

internal class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; }

    public Freelancer(string nome, string cargo, decimal valorProjeto) : base (nome, cargo)
    {
        this.ValorProjeto = valorProjeto;
    }

    public override string ToString()
    {
        return $"Freelancer {this.Nome} – Cargo: {this.Cargo} – Projeto atual: R$ {this.ValorProjeto}";
    }
}

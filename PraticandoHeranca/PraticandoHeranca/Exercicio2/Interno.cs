namespace PraticandoHeranca.Exercicio2;

internal class Interno : Funcionario
{
    public decimal Salario { get; }

    public Interno(string nome, string cargo, decimal salario) : base (nome, cargo)
    {
        this.Salario = salario;
    }

    public override string ToString()
    {
        return $"Funcionária {this.Nome} – Cargo: {this.Cargo} – Projeto atual: R$ {this.Salario}";
    }
}

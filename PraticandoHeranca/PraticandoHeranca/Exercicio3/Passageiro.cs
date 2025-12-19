namespace PraticandoHeranca.Exercicio3;

internal class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; }

    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
        this.QuantidadeBilhetes = quantidadeBilhetes;
    }

    public override string ToString()
    {
        return $"Passageiro: {this.Nome} - Idade: {this.Idade} - Quantidade de Bilhetes: {this.QuantidadeBilhetes}";
    }
}
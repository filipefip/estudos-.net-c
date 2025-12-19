namespace PraticandoHeranca.Exercicio1;

internal class ClienteVIP : Pessoa
{
    public string NivelFidelidade { get; }
    public string CodigoVIP { get; }

    public ClienteVIP(string nome, int idade, string nivelFidelidade, string codigoVIP)
        : base(nome, idade)
    {
        this.NivelFidelidade = nivelFidelidade;
        this.CodigoVIP = codigoVIP;
    }
}

namespace PraticandoHeranca.Exercicio4;

internal class Certificado
{
    public Profissao Profissao { get; }
    public Certificado(Profissao profissao)
    {
        this.Profissao = profissao;
    }

    public override string ToString()
    {
        return $"Certificado emitido para: {this.Profissao.Titulo}";
    }
}

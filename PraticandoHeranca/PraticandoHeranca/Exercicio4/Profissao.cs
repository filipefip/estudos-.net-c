namespace PraticandoHeranca.Exercicio4;

internal abstract class Profissao
{
    public string Titulo { get; set; }
    public Profissao(string titulo)
    {
        this.Titulo = titulo;
    }
}

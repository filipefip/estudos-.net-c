namespace PraticandoHeranca.Exercicio10;

internal class CursoDesign : ICurso
{
    public string Titulo { get; }
    public Instrutor Instrutor { get; }

    public CursoDesign(string titulo, Instrutor instrutor)
    {
        this.Titulo = titulo;
        this.Instrutor = instrutor;
    }
    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {this.Titulo} - Instrutor: {this.Instrutor.Nome} ({this.Instrutor.Especialidade})");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {this.Titulo}");
    }
}

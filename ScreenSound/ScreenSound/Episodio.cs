class Episodio
{
    public Episodio(int id, string titulo, int duracao)
    {
        ID = id;
        Titulo = titulo;
        Duracao = duracao;
    }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public int ID { get; set; }
    public List<string> Convidados { get; set; } = new List<string>();
    public string Resumo => $"Episódio {ID}: {Titulo} - Duração: {Duracao} minutos | Convidados: {string.Join(", ", Convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}
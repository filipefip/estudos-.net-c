class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
    }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        Console.WriteLine($"Consulta reagendada para {DataConsulta}");
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Consulta marcada com {this.NomeMedico} para o paciente {this.NomePaciente}.");
        Console.WriteLine($"Data: {this.DataConsulta}\n");
    }
}
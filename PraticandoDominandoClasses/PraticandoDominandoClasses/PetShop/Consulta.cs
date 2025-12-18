namespace PraticandoDominandoClasses.PetShop;

internal class Consulta
{
    public Consulta(Dono dono, Pet pet, Medico medico, DateTime dataConsulta)
    {
        Dono = dono;
        Pet = pet;
        Medico = medico;
        DataConsulta = dataConsulta;
    }

    public Dono Dono { get; set; }
    public Pet Pet { get; set; }
    public Medico Medico { get; set; }
    public DateTime DataConsulta { get; set; }

    public void ExibirDetalhesConsulta()
    {
        Console.WriteLine($"Consulta marcada para o pet {Pet.Nome}, dono {Dono.Nome}, com o médico {Medico.Nome} na data {DataConsulta}.\n");
    }
}

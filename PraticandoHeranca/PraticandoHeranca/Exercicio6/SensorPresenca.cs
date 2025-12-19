namespace PraticandoHeranca.Exercicio6;

internal class SensorPresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de Presença Ativado.");
    }
    public void Desativar()
    {
        Console.WriteLine("Sensor de Presença Desativado.");
    }
}

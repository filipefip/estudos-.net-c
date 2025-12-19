namespace PraticandoHeranca.Exercicio6;

internal class SensorTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de Temperatura Ativado.");
    }
    public void Desativar()
    {
        Console.WriteLine("Sensor de Temperatura Desativado.");
    }
}

namespace PraticandoDominandoClasses.FormasGeometricas;

internal class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public override double CalcularArea()
    {
        double areaCirculo = Math.PI * this.Raio * this.Raio;
        Console.WriteLine($"A área do círculo é: {areaCirculo}");
        return areaCirculo;
    }

    public override double CalcularPerimetro()
    {
        double perimetroCirculo = 2 * Math.PI * this.Raio;
        Console.WriteLine($"O perímetro do círculo é: {perimetroCirculo}");
        return perimetroCirculo;
    }
}

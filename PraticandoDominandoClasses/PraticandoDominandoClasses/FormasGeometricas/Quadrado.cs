namespace PraticandoDominandoClasses.FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        double areaQuadrado = this.Base * this.Altura;
        Console.WriteLine($"A área do quadrado é: {areaQuadrado}");
        return areaQuadrado;
    }
    public override double CalcularPerimetro()
    {
        double perimetroQuadrado = 2 * (this.Base + this.Altura);
        Console.WriteLine($"O perímetro do quadrado é: {perimetroQuadrado}");
        return perimetroQuadrado;
    }
}

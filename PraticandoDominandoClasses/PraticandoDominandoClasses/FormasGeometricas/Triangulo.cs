namespace PraticandoDominandoClasses.FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public override double CalcularArea()
    {
        double areaTriangulo = (this.Base * this.Altura) / 2;
        Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
        return areaTriangulo;
    }

    public override double CalcularPerimetro()
    {
        double perimetroTriangulo = this.Base + this.Altura + Math.Sqrt(this.Base * this.Base + this.Altura * this.Altura);
        Console.WriteLine($"O perimetro do triângulo é: {perimetroTriangulo}");
        return perimetroTriangulo;
    }
}

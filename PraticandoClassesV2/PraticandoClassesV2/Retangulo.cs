class Retangulo
{
    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public double Altura { get; set; }
    public double Largura { get; set; }

    public void CalcularArea()
    {
        double area = this.Altura * this.Largura;
        Console.WriteLine($"A área do retângulo é: {area}");
    }
}
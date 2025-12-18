using static System.Runtime.InteropServices.JavaScript.JSType;

class Carro
{
    private int ano;
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int VelocidadeAtual { get; set; }

    public string DescricaoDetalhada => $"Modelo do carro: {this.Marca} {this.Modelo} {this.Ano}";

    public void Acelerar()
    {
        VelocidadeAtual += 10;
    }

    public void Frear()
    {
        VelocidadeAtual -= 10;
        if (VelocidadeAtual < 0)
        {
            VelocidadeAtual = 0;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Buzina: BEEP BEEP!");
    }

    public void ExibirVelocidadeAtual()
    {
        Console.WriteLine($"Velocidade Atual: {VelocidadeAtual} km/h");
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}
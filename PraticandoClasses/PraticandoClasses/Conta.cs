class Conta
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoesConta()
    {
        Console.WriteLine($"ID: {NumeroIndicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: R${Saldo}");
    }
}
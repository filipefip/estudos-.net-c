class Produto
{
    private double _preco;
    private int _estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => _preco;
        set
        {
            try
            {
                if (value < 0)
                    throw new Exception("Preço inválido! O preço não pode ser negativo.");
                _preco = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("O preço foi ajustado para o valor positivo correspondente.");
                _preco = value * -1;
            }
        }
    }
    public int Estoque {
        get => _estoque;
        set
        {
            try
            {
                if (value < 0)
                    throw new Exception("Estoque inválido! O estoque não pode ser negativo.");
                _estoque = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("O estoque foi ajustado para o valor positivo correspondente.");
                _estoque = value * -1;
            }
        }
    }

    public Produto(string nome, string marca, double preco, int estoque)
    {
        this.Nome = nome;
        this.Marca = marca;
        this.Preco = preco;
        this.Estoque = estoque;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nNome: {this.Nome}");
        Console.WriteLine($"Marca: {this.Marca}");
        Console.WriteLine($"Preço: R${this.Preco}");
        Console.WriteLine($"Estoque: {this.Estoque} unidades");
    }
}
class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeEstoque)
    {
        Nome = nome;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public void Retirar(int quantidade)
    {
        if (this.quantidadeEstoque >= quantidade)
        {
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
            this.quantidadeEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {this.Nome}, \nQuantidade em estoque: {this.quantidadeEstoque}");
    }
}
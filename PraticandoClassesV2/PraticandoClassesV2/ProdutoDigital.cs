class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InformacaoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InformacaoTecnica = infoTecnica;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco}");
        Console.WriteLine($"Tamanho: {InformacaoTecnica.TamanhoMB}MB");
        Console.WriteLine($"Compatível com: {InformacaoTecnica.SistemaOperacional}");
    }
}
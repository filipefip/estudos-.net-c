class Pedido
{
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarStatus(string novoStatus)
    {
        this.Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido nº {this.NumeroPedido}");
        Console.WriteLine($"Cliente: {this.NomeCliente}");
        Console.WriteLine($"Status: {this.Status}\n");
    }
}
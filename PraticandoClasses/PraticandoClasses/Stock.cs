class Stock
{
    public string StockId { get; set; }
    public string StockName { get; set; }
    private List<Product> products = new List<Product>();

    public Stock(string stockId, string stockName)
    {
        StockId = stockId;
        StockName = stockName;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayStockInfo()
    {
        Console.WriteLine($"Stock ID: {StockId}");
        Console.WriteLine($"Stock Name: {StockName}");
    }

    public void DisplayStockProducts()
    {
        this.DisplayStockInfo();
        Console.WriteLine("\nProducts in Stock:\n");
        foreach (var product in products)
        {
            product.DisplayProductInfo();
            Console.WriteLine();
        }
    }
}
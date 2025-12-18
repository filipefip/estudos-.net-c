class Order
{
    public int OrderId { get; set; }
    public List<string> Items { get; set; }

    public Order(int orderId)
    {
        OrderId = orderId;
        Items = new List<string>();
    }

    public void AddItem(string item, Menu menu)
    {
        if (menu.Items.Contains(item))
        {
            Items.Add(item);
        }
        else
        {
            Console.WriteLine($"Item '{item}' is not available in the menu.");
            Console.WriteLine();
        }
    }
}
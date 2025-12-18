class Menu
{
    public List<string> Items { get; set; } = new List<string>();
    public void AddItem(string item)
    {
        Items.Add(item);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine();
    }
}
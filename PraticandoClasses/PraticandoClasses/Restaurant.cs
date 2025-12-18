class Restaurant
{
    public string Name { get; set; }
    private List<Table> Tables { get; set; } = new List<Table>();
    public Menu Menu { get; set; }

    public Restaurant(string name)
    {
        Name = name;
        Tables = new List<Table>();
    }

    public void AddTable(Table table)
    {
        Tables.Add(table);

    }

    /*public void ReserveTable(int tableNumber)
    {
        var table = Tables.FirstOrDefault(t => t.TableNumber == tableNumber);
        if (table != null && !table.IsReserved)
        {
            table.IsReserved = true;
            Console.WriteLine($"Table {tableNumber} has been reserved.");
        }
        else
        {
            Console.WriteLine($"Table {tableNumber} is either not found or already reserved.");
        }
    }*/

    public void ReserveTable()
    {
        foreach (Table table in Tables)
        {
            if (!table.IsReserved)
            {
                table.IsReserved = true;
                Console.WriteLine($"Table {table.TableNumber} has been reserved.");
                Console.WriteLine();
                break;
            }
        }
    }

    public void DisplayReservedTables()
    {
        Console.WriteLine($"Reserved Tables in {Name}:");
        foreach (var table in Tables)
        {
            if (table.IsReserved)
            {
                Console.WriteLine($"- Table {table.TableNumber}");
            }
        }
        Console.WriteLine();
    }

    public void DisplayMenu()
    {
        Menu.DisplayMenu();
    }

    public void DisplayOrders() {
        Console.WriteLine($"Orders in {Name}:\n");
        foreach (var table in Tables)
        {
            if (table.IsReserved && table.Order != null)
            {
                Console.WriteLine($"Table {table.TableNumber} Order {table.Order.OrderId}:");
                foreach (var item in table.Order.Items)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            Console.WriteLine();
        }
    }
}
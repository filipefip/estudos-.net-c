class Table
{
    public int Seats {get; set;}
    public bool IsReserved { get; set; }
    public int TableNumber { get; set; }

    public Order Order { get; set; }

    public Table(int tableNumber, int seats)
    {
        TableNumber = tableNumber;
        Seats = seats;
        IsReserved = false;
        Order = null;
    }
}
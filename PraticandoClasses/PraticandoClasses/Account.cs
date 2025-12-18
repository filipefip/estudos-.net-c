class Account
{
    public Holder Holder { get; set; }
    public string Agency { get; set; }
    public double Balance { get; set; }
    public double Limit { get; set; }
    public string DisplayAccountInfo => $"Holder: {this.Holder.Name} \nAgency: {this.Agency} \nBalance: ${this.Balance} \nLimit: ${this.Limit}";
    public string DisplayHolderInfo => $"Holder Name: {this.Holder.Name} \nHolder Document: {this.Holder.Document}";

    public Account(Holder holder, string agency, double balance, double limit)
    {
        this.Holder = holder;
        this.Agency = agency;
        this.Balance = balance;
        this.Limit = limit;
    }
}
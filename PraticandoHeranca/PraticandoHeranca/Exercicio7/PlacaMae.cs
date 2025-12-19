namespace PraticandoHeranca.Exercicio7;

internal class PlacaMae
{
    public string Fabricante { get; set; }
    public string Socket { get; set; }

    public PlacaMae(string fabricante, string socket)
    {
        this.Fabricante = fabricante;
        this.Socket = socket;
    }
}

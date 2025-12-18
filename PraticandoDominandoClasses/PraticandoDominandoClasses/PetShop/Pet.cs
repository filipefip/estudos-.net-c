namespace PraticandoDominandoClasses.PetShop;
internal class Pet
{
    public Pet(string nome, int idade, string raca)
    {
        Nome = nome;
        Idade = idade;
        Raca = raca;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Raca { get; set; }
}
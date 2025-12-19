using System.Text.Json;
using PraticandoAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        //string jsonFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        //var filmes = JsonSerializer.Deserialize<List<Filme>>(jsonFilmes)!;
        //filmes[0].ExibirDetalhesFilme();

        //string jsonPaises = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        //var paises = JsonSerializer.Deserialize<List<Pais>>(jsonPaises)!;
        //paises[0].ExibirDetalhesPais();

        //string jsonCarros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        //var carros = JsonSerializer.Deserialize<List<Carro>>(jsonCarros)!;
        //carros[0].ExibirDetalhesCarro();

        //string jsonLivros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        //var livros = JsonSerializer.Deserialize<List<Livro>>(jsonLivros)!;
        //foreach(Livro livro in livros)
        //{
        //    livro.ExibirDetalhesLivro();
        //}
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }    
}
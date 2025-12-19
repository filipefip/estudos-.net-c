using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(artista => artista.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}

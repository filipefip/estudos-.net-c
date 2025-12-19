//using System.Linq;
using ScreenSoundAPI.Modelos;
namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        /* JEITO CORRETO */
        var todosOsGenerosMusicais = musicas
            .SelectMany(generos => generos.Genero.Split(','))
            .Select(genero => genero.Trim())
            .Distinct()
            .ToList();

        /* JEITO DO CURSO */
        //var todosOsGenerosMusicais = musicas
        //    .Select(genero => genero.Genero)
        //    .Distinct()
        //    .ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista))
            .ToList();
        Console.WriteLine(nomeArtista);
        Console.WriteLine($"Musicas do artisita: {nomeArtista}");
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}

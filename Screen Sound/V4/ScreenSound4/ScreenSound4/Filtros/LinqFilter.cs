namespace ScreenSound4.Filtros;
using System.Linq;
using Modelos;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenerosMusicais(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Artistas por gênero musical: ");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDeUmArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista))
            .Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Musicas por artista: {nomeDoArtista}");
        foreach (var musicaDoArtista in musicasDeUmArtista)
        {
            Console.WriteLine($"- {musicaDoArtista}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int key)
    {
        var musicasPorTonalidade =
            musicas.Where(musica => musica.Key!.Equals(key)).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Musicas por tonalidade:");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}

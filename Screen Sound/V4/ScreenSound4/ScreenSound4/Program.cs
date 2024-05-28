using System.Text.Json;
using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 6);
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGenerosMusicais(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        // var musicasPreferidasDeKaio = new MusicasPreferidas("Kaio");
        // musicasPreferidasDeKaio.AdicionarMusicasFavoritas(musicas[12]);
        // musicasPreferidasDeKaio.ExibirMusicasFavoritas();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
        throw;
    }
}

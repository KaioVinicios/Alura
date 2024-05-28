namespace ScreenSound4.Modelos;
using System.Text.Json;
internal class MusicasPreferidas
{
    private string? Nome { get; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são suas músicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string Json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"Musicas_Favoritas_de_{Nome}.json";
        File.WriteAllText(nomeDoArquivo, Json);
        Console.WriteLine($"Arquivo criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
    }
}
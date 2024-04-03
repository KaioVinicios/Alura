namespace V2;

public class Album
{
    private List<Musicas> musicas = new List<Musicas>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musicas musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"\nLista das músicas do album: {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esse album inteiro você precisa de: {DuracaoTotal} segundos.");
    }
}
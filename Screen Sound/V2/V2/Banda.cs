using System.Security.Cryptography;

namespace V2;

public class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }

}
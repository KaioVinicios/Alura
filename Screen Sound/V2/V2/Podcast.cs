namespace V2;

public class Podcast
{
    private List<Episodio> _episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpsodios => _episodios.Count;

    public void AdicionarEpsodios(Episodio episodio)
    {
        _episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in _episodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nEste podcast possui {TotalEpsodios} episódios.");
    }
}
namespace V2;

public class Musicas
{
    public Musicas(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public String Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponibilidade { get; set; }

    public String DescricaoResumida
    {
        get
        {
            return $"O artista é {Artista}, a música referente é {Nome} com uma duração de {Duracao} segundos. A música está presente no seu plano: {Disponibilidade}.";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}, duração: {Duracao}.");
    }
}
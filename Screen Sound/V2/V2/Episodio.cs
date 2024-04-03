namespace V2;

public class Episodio
{
    public Episodio( string titulo, int duracao, int ordem)
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }
    
    private List<String> _convidados = new List<string>(); 
    public int Duracao { get; }
    public string Titulo { get; }
    public int Ordem { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao}min) - {string.Join(", ", _convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        _convidados.Add(convidado);
    }
} 
class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nO Podcast {Nome} tem como host: {Host}.\n");
        if(TotalEpisodios > 0)
        {
            Console.WriteLine("Segue a lista de episódios:");
            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\ntotal de episódios: {TotalEpisodios}");
        }
    }
}
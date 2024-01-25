
using System.Text.Json;

namespace ScreenSound4.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas {get; }

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
        System.Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            System.Console.WriteLine($" - {musica.Nome} de {musica.Artista}");
        }
        System.Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        System.Console.WriteLine($"O arquivo json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
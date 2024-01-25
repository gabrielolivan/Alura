using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade { 
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Musica: {Nome}");
        System.Console.WriteLine($"Duração: {Duracao/100}s");
        System.Console.WriteLine($"Gênero Musical: {Genero}s");
        System.Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
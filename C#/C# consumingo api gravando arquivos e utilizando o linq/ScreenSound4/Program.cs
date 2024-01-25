using System.Collections;
using System.Text.Json;
using ScreenSound4.Modelos;
using ScreenSound4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        
        // musicas[1].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        // var musicasPreferidas = new MusicasPreferidas("Daniel");
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);

        // musicasPreferidas.ExibirMusicasFavoritas();

        // var musicasPreferidas2 = new MusicasPreferidas("Emy");
        // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[500]);
        // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[637]);
        // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[428]);
        // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[13]);
        // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[71]);
        
        // musicasPreferidas2.ExibirMusicasFavoritas();

        // musicasPreferidas2.GerarArquivoJson();
    }
    catch (System.Exception ex)
    {
        
        System.Console.WriteLine(ex.Message);
    }
}
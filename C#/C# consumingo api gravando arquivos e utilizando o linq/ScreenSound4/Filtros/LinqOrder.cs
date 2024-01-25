using ScreenSound4.Modelos;

namespace ScreenSound4.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(a => a.Artista).Select(a => a.Artista).Distinct().ToList();
        foreach (var artista in artistasOrdenados)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }
}
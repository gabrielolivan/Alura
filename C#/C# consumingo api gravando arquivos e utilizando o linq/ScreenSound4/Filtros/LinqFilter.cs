namespace ScreenSound4.Filtros;

using System;
using ScreenSound4.Modelos;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(a => a.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            System.Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(a => a.Genero!.Contains(genero)).Select(a => a.Artista).Distinct().ToList();
        foreach (var artista in artistasPorGeneroMusical)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDeUmArtista = musicas.Where(a => a.Artista!.Equals(artista)).Select(a => a.Nome).ToList();
        foreach (var musica in musicasDeUmArtista)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(a => a.Tonalidade.Equals("C#")).Select(a => a.Nome).Distinct().ToList();
        foreach (var musica in musicasEmCSharp)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }
}
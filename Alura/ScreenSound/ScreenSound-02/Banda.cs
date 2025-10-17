﻿class Banda
{
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:\n");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome}");
            Console.WriteLine($"Duração total: {album.DuracaoTotal}\n");
        }
    }
}
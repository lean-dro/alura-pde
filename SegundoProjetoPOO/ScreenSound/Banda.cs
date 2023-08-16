﻿class Banda
{
    public Banda(string artista)
    {
        Nome = artista;
    }
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public int QuantidadeDeAlbuns => albuns.Count;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine(@"
██████╗░██╗░██████╗░█████╗░░█████╗░░██████╗░██████╗░░█████╗░███████╗██╗░█████╗░
██╔══██╗██║██╔════╝██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗██╔════╝██║██╔══██╗
██║░░██║██║╚█████╗░██║░░╚═╝██║░░██║██║░░██╗░██████╔╝███████║█████╗░░██║███████║
██║░░██║██║░╚═══██╗██║░░██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██╔══╝░░██║██╔══██║
██████╔╝██║██████╔╝╚█████╔╝╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░░░░░██║██║░░██║
╚═════╝░╚═╝╚═════╝░░╚════╝░░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░  ░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
██║░░██║██║░░██║  ███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██║░░██║██║░░██║  ██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██████╔╝╚█████╔╝  ██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═════╝░░╚════╝░  ╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
        Console.WriteLine($"**********{Nome}**********");
        Console.WriteLine($"Álbuns do artista ({QuantidadeDeAlbuns}):");
        foreach (var album in albuns)
        {
            Console.WriteLine($"- {album.Nome}");
        }
    }
}
class Album
{
    private List<Musica> musicas;
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasdoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");

        }

        Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos");
    }
}

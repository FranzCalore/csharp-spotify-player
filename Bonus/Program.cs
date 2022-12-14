// See https://aka.ms/new-console-template for more information

using csharp_spotify_player;
using System.Globalization;
using Bonus;

List <IContenutoRiproducibile> PlaylistSpotify = new List<IContenutoRiproducibile>();

IContenutoRiproducibile Deutschland = new Brano("Deutschland", "Rammstein");

PlaylistSpotify.Add(Deutschland);

IContenutoRiproducibile PodcastSerialKiller = new Podcast("La mano e il coltello", "Pinco Pallo");

PlaylistSpotify.Add(PodcastSerialKiller);

Console.WriteLine("Ecco la tua playlist: \n\n");

foreach(IContenutoRiproducibile Contenuto in PlaylistSpotify)
{
    Console.WriteLine(Contenuto);
}


Console.WriteLine("Vuoi aggiungere qualcosa alla playlist? (y/n)");
string RispostaUtente = Console.ReadLine();
while (RispostaUtente == "y")
{
    Console.WriteLine("Si tratta di un brano o di un podcast?");
    string classeContenuto = Console.ReadLine();
    Console.WriteLine("Inserisci il nome del contenuto che vuoi inserire");
    string nomeNuovoContenuto = Console.ReadLine();
    Console.WriteLine("Inserisci l'autore del contenuto che vuoi inserire");
    string autoreNuovoContenuto = Console.ReadLine();
    if (classeContenuto == "brano")
    {
        Brano branoUtente = new Brano(nomeNuovoContenuto, autoreNuovoContenuto);
        PlaylistSpotify.Add(branoUtente);
    }
    else if (classeContenuto == "podcast")
    {
        Podcast PodcastUtente = new Podcast(nomeNuovoContenuto, autoreNuovoContenuto);
        PlaylistSpotify.Add(PodcastUtente);
    }
    else
    {
        Console.WriteLine("Contenuto non riconosciuto");
    }

    Console.WriteLine("Ecco la tua playlist: \n\n");

    foreach (IContenutoRiproducibile Contenuto in PlaylistSpotify)
    {
        Console.WriteLine(Contenuto);
    }


    Console.WriteLine("Vuoi aggiungere qualcosa alla playlist? (y/n)");
    RispostaUtente = Console.ReadLine();


}
OrdinaPlaylist(PlaylistSpotify);


Console.WriteLine("\n\nQuale vuoi riprodurre?");
string TitoloDaRiprodurre = Console.ReadLine();

for (int i = 0; i<PlaylistSpotify.Count; i++)
{
    if (PlaylistSpotify[i] is Brano)
    {
        Brano BranoConvertito = (Brano)PlaylistSpotify[i];
        string nomeBrano = BranoConvertito.GetNomeBrano();
        if (nomeBrano == TitoloDaRiprodurre)
        {
            ContenutoAudio.indiceInRiproduzione = i;
            BranoConvertito.Play();
            Skip();
            break;
        }
    }
    else
    {
        Podcast PodcastConvertito = (Podcast)PlaylistSpotify[i];
        string nomePodcast = PodcastConvertito.GetNomePodcast();
        if (nomePodcast == TitoloDaRiprodurre)
        {
            ContenutoAudio.indiceInRiproduzione = i;
            PodcastConvertito.Play();
            Skip();
            break;
        }
    }
}


// Funzione

void OrdinaPlaylist(List<IContenutoRiproducibile> Playlist)
{
    for(int i = 0; i< Playlist.Count; i++)
    {
        ContenutoAudio contenutoaudio = (ContenutoAudio)Playlist[i];
        contenutoaudio.SetPosizione(i);
    }
}

void Skip()
{
    ContenutoAudio.indiceInRiproduzione++;
    if (ContenutoAudio.indiceInRiproduzione == PlaylistSpotify.Count)
    {
        ContenutoAudio.indiceInRiproduzione = 0;
    }
    PlaylistSpotify[ContenutoAudio.indiceInRiproduzione].Play();
}
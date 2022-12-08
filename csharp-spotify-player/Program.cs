// See https://aka.ms/new-console-template for more information

using csharp_spotify_player;
using System.Globalization;

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

Console.WriteLine("\n\nQuale vuoi riprodurre?");
string TitoloDaRiprodurre = Console.ReadLine();
int indiceInRiproduzione;

for (int i = 0; i<PlaylistSpotify.Count; i++)
{
    if (PlaylistSpotify[i] is Brano)
    {
        Brano BranoConvertito = (Brano)PlaylistSpotify[i];
        string nomeBrano = BranoConvertito.GetNomeBrano();
        if (nomeBrano == TitoloDaRiprodurre)
        {
            indiceInRiproduzione = i;
            BranoConvertito.Play();
            break;
        }
    }
    else
    {
        Podcast PodcastConvertito = (Podcast)PlaylistSpotify[i];
        string nomePodcast = PodcastConvertito.GetNomePodcast();
        if (nomePodcast == TitoloDaRiprodurre)
        {
            indiceInRiproduzione = i;
            PodcastConvertito.Play();
            break;
        }
    }
}
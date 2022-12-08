using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public class Podcast : IContenutoRiproducibile
    {
        private string nomePodcast;
        private string autorePodcast;

        public Podcast(string nomePodcast, string autorePodcast)
        {
            this.nomePodcast = nomePodcast;
            this.autorePodcast = autorePodcast;
        }

        public string GetNomePodcast()
        {
            return this.nomePodcast;
        }

        public string GetAutorePodcast()
        {
            return this.autorePodcast;
        }

        public void Pausa()
        {
            Console.WriteLine("Il podcast " + nomePodcast + " è stato messo in pausa");
        }

        public void Play()
        {
            Console.WriteLine("Il podcast " + nomePodcast + " è stato messo in riproduzione");
        }

        public void Stop()
        {
            Console.WriteLine("Il podcast " + nomePodcast + " è stato stoppato e riavvolto");
        }

        public override string ToString()
        {
            return this.GetNomePodcast() + "\t\t\t\t" + this.GetAutorePodcast();
        }
    }
}

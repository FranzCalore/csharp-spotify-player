using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public class Podcast : ContenutoAudio
    {
        private string nome;
        private string autore;

        public Podcast(string nomePodcast, string autorePodcast)
        {
            this.nome = nomePodcast;
            this.autore = autorePodcast;
        }

        public string GetNomePodcast()
        {
            return this.nome;
        }

        public string GetAutorePodcast()
        {
            return this.autore;
        }

        public void Pausa()
        {
            Console.WriteLine("Il podcast " + nome + " è stato messo in pausa");
        }

        public void Play()
        {
            Console.WriteLine("Il podcast " + nome + " è stato messo in riproduzione");
        }

        public void Stop()
        {
            Console.WriteLine("Il podcast " + nome + " è stato stoppato e riavvolto");
        }

        public override string ToString()
        {
            return this.GetNomePodcast() + "\t\t\t\t" + this.GetAutorePodcast();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bonus;

namespace csharp_spotify_player
{
    public class Podcast : ContenutoAudio
    {

        public Podcast(string nome, string autore):base(nome, autore)
        {
            this.nome = nome;
            this.autore = autore;
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
            return "Podcast\t\t" + this.GetNomePodcast() + "\t\t\t\t" + this.GetAutorePodcast();
        }
    }
}

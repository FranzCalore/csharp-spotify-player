using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public class Brano : IContenutoRiproducibile
    {
        private string nomeBrano;
        private string autoreBrano;


        public Brano(string nomeBrano, string autoreBrano)
        {
            this.nomeBrano = nomeBrano;
            this.autoreBrano = autoreBrano;
        }

        public string GetNomeBrano()
        {
            return this.nomeBrano;
        }

        public string GetAutoreBrano()
        {
            return this.autoreBrano;
        }

        public void Pausa()
        {
            Console.WriteLine(nomeBrano + " è stato messo in pausa");
        }

        public void Play()
        {
            Console.WriteLine(nomeBrano + " è stato messo in riproduzione");
        }

        public void Stop()
        {
            Console.WriteLine(nomeBrano + " è stato fermato e riavvolto");
        }

        public override string ToString()
        {
            return this.GetNomeBrano()+ "\t\t\t\t\t" + this.GetAutoreBrano();
        }
    }
}

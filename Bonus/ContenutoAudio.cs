using csharp_spotify_player;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public abstract class ContenutoAudio : IContenutoRiproducibile
    {
        private protected string nome;
        private protected string autore;
        internal static int indiceInRiproduzione=-1;
        private int posizione;

        public ContenutoAudio(string nome, string autore, int posizione=-2)
        {
            this.nome = nome;
            this.autore = autore;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetAutore()
        {
            return this.autore;
        }

        public void SetPosizione(int posizione)
        {
            this.posizione = posizione;
        }

        public override string ToString()
        {
            string stringaStampa = "Nome: " + this.GetNome();
            stringaStampa= stringaStampa.PadRight(80, ' ');
            return stringaStampa + " Autore: " + this.GetAutore() + "\n";
        }

        public void Play()
        {
            Console.WriteLine(this.nome + " è stato messo in riproduzione");
            indiceInRiproduzione = this.posizione;
        }

        public void Pausa()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            indiceInRiproduzione = 0;
            Console.WriteLine(nome + " è stato fermato e riavvolto");
        }

    }
}

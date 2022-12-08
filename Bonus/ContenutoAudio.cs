using csharp_spotify_player;
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

        public ContenutoAudio(string nome, string autore)
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

        public override string ToString()
        {
            return this.GetNome() + "\t\t\t\t" + this.GetAutore();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Pausa()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}

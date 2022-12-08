using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bonus;

namespace csharp_spotify_player
{
    public class Brano : ContenutoAudio
    {
        private string nomeBrano;
        private string autoreBrano;


        public Brano(string nome, string autore):base(nome,autore)
        {
            this.nome = nome;
            this.autore = autore;
        }

        public string GetNomeBrano()
        {
            return this.nome;
        }

        public string GetAutoreBrano()
        {
            return this.autore;
        }

        public void Pausa()
        {
            Console.WriteLine(nome + " è stato messo in pausa");

        }
    }
}

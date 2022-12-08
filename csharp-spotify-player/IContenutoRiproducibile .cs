using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public interface IContenutoRiproducibile
    {
        public void Play();
        public void Pausa();
        public void Stop();

    }
}

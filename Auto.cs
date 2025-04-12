using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Auto
    {
       public string targa;
       public string marca;
       public string modello;
       public int tempo_sosta;
        public Auto(string targa, string marca, string modello, int tempo_sosta)
        {
            this.targa = targa;
            this.marca = marca;
            this.modello = modello;
            this.tempo_sosta = tempo_sosta;
        }
    }
}

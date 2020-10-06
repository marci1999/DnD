using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Karakter
    {
        string nev;
        int eletero;
        int sebzes;

        public Karakter(string nev, int eletero, int sebzes)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.sebzes = sebzes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Sebzes { get => sebzes; set => sebzes = value; }
    }
}

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

        public Karakter(string sor)
        {
            string[] adat = sor.Split(';');

            this.nev = adat[0];
            this.eletero = adat[1];
            this.segbzes = adat[2];
        }

        public Karakter(string nev, int eletero, int sebzes)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.sebzes = sebzes;
        }

        public string Nev { get => nev; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Sebzes { get => sebzes; set => sebzes = value; }

        public override string ToString()
        {
            return String.Format("Nev: {0}, Eletero: {1}, Sebzes: {2}",this.Nev,this.Eletero,this.Sebzes);
        }
    }
}

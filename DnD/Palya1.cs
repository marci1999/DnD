using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KalandJatek
{
    class Palya
    {
        List<Karakter> ellneseg;

        internal List<Karakter> Ellneseg { get => ellneseg; set => ellneseg = value; }

        public Palya(string filename)
        {
            ellneseg = new List<Karakter>();
            try
            {
                ellneseg = new List<Karakter>();
                StreamReader sr = new StreamReader(filename);
                string sor = sr.ReadLine();
                while (sor != null)
                {
                    ellneseg.Add(new Karakter(sor));
                    sor = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }

    }
}

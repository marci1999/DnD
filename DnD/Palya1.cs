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

       public void kezdes()
       {
            Console.WriteLine(ellneseg[0].ToString());
            Console.WriteLine(ellneseg[1].ToString());
            Console.WriteLine(ellneseg[2].ToString());
       }

        public void ball()
        {
            Console.WriteLine(ellneseg[3].ToString());
            Console.WriteLine(ellneseg[4].ToString());
            Console.WriteLine(ellneseg[5].ToString());
            Console.WriteLine(kristály);
        }
        public void jobb()
        {
            Console.WriteLine(ellneseg[6].ToString());
            Console.WriteLine(ellneseg[7].ToString());
            Console.WriteLine(ellneseg[8].ToString());
            Console.WriteLine(korona);
        }

    }
}

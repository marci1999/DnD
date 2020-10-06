﻿using System;
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
                throw;
            }
        }

       public void kezdes()
       {
            ellneseg.ElementAt(0);
            ellneseg.ElementAt(1);
            ellneseg.ElementAt(2);

       }

        Karakter k = new Karakter("proba",10,10);

    }
}

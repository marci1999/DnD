using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Palya p = new Palya("ellnesegek.txt");

            p.kezdes();
            bool jatekTart = true;
            char holAJatekos = 'k'; //kozep
            Karakter jatekos = new Karakter("Jatekos Karaktere",100,10);
            while (jatekTart)
            {
                Console.WriteLine("\nJátékos:");
                Console.WriteLine(jatekos.ToString());
                Console.WriteLine("\nEllenségek:");
                switch (holAJatekos)
                {
                    case 'k':
                        Console.WriteLine(p.Ellneseg[0].ToString());
                        Console.WriteLine(p.Ellneseg[1].ToString());
                        Console.WriteLine(p.Ellneseg[2].ToString());
                        break;
                    case 'b':
                        Console.WriteLine(p.Ellneseg[3].ToString());
                        Console.WriteLine(p.Ellneseg[4].ToString());
                        Console.WriteLine(p.Ellneseg[5].ToString());
                        break;
                    case 'j':
                        Console.WriteLine(p.Ellneseg[6].ToString());
                        Console.WriteLine(p.Ellneseg[7].ToString());
                        Console.WriteLine(p.Ellneseg[8].ToString());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n---------------------------------------------------------------------------------\n" +
                    "Mit szeretnél csinálni? h - harc, g - gyogyulni, b - balra megy, j - jobbra megy, k - kilépés");
                char parancs = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (parancs)
                {
                    case 'h':
                        Console.WriteLine("Kivel harcolsz?");
                        switch(holAJatekos)
                        {
                            case 'k':
                                Console.WriteLine("1   "+p.Ellneseg[0].ToString());
                                Console.WriteLine("2   "+p.Ellneseg[1].ToString());
                                Console.WriteLine("3   "+p.Ellneseg[2].ToString());
                                int a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[a-1].Nev);
                                jatekos.Tamadas(jatekos, p.Ellneseg[a-1]);
                                if (p.Ellneseg[a - 1].Eletero>0)
                                {
                                    Console.WriteLine("{0} visszatámad", p.Ellneseg[a - 1].Nev);
                                    p.Ellneseg[a - 1].Tamadas(p.Ellneseg[a - 1], jatekos);
                                }
                                break;
                            case 'b':
                                Console.WriteLine("4   " + p.Ellneseg[3].ToString());
                                Console.WriteLine("5   " + p.Ellneseg[4].ToString());
                                Console.WriteLine("6   " + p.Ellneseg[5].ToString());
                                int b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[b - 1].Nev);
                                jatekos.Tamadas(jatekos, p.Ellneseg[b - 1]);
                                if (p.Ellneseg[b - 1].Eletero > 0)
                                {
                                    Console.WriteLine("{0} visszatámad", p.Ellneseg[b - 1].Nev);
                                    p.Ellneseg[b - 1].Tamadas(p.Ellneseg[b - 1], jatekos);
                                }
                                break;
                            case 'j':
                                Console.WriteLine("7   " + p.Ellneseg[6].ToString());
                                Console.WriteLine("8   " + p.Ellneseg[7].ToString());
                                Console.WriteLine("9   " + p.Ellneseg[8].ToString());
                                int c = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[c- 1].Nev);
                                jatekos.Tamadas(jatekos, p.Ellneseg[c - 1]);
                                if (p.Ellneseg[c - 1].Eletero > 0)
                                {
                                    Console.WriteLine("{0} visszatámad", p.Ellneseg[c - 1].Nev);
                                    p.Ellneseg[c - 1].Tamadas(p.Ellneseg[c - 1], jatekos);
                                }
                                break;
                        }

                        break;
                    case 'g':
                        Console.WriteLine("gyogyulsz");
                        jatekos.Gyogyulas(jatekos);
                        break;
                    case 'b':
                        if (p.Ellneseg[0].Eletero>0 || p.Ellneseg[1].Eletero>0 || p.Ellneseg[2].Eletero>0)
                        {
                            Console.WriteLine("nem mehetsz balra, még vannak élő ellenfelek");
                        }
                        else
                        {
                            Console.WriteLine("balra mész");
                            holAJatekos = 'b';
                        }
                        break;
                    case 'j':
                        if (p.Ellneseg[0].Eletero > 0 || p.Ellneseg[1].Eletero > 0 || p.Ellneseg[2].Eletero > 0)
                        {
                            Console.WriteLine("nem mehetsz jobbra, még vannak élő ellenfelek");
                        }
                        else
                        {
                            Console.WriteLine("jobbra mész");
                            holAJatekos = 'j';
                        }
                        break;
                    case 'k':
                        Console.WriteLine("Kiléptél");
                        jatekTart = false;
                        Console.WriteLine("nyomj egy gombot a kilépéshez");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("hibás parancs");
                        break;
                        /*nyuszi;5;12
nyuszi2;10;10
nyuszi3;12;5
trol;20;15
köSzrny;30;20
köSárkány;40;30
irányitottHarcos;7;7
mágus7;12
mágikusSárkány20;50*/
                }
            }
        }
    }
}

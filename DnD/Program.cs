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

                        /*
                         Üdvözölek bátor harco hogy hivhtlak?
És milyen erös vagy!
És menyire vagy szívos(menyi a életed)!
Remek. Akkor kezdödhet is a kaland!
Mész  az erdőben és nagy kincseket keresel. Egy szer csak előugrik egy vérszomjas nyúl az egyikk bokorbol. kicsitm megijdsz és felemeled a kardodat hogy megküzdj vele. Ám de amikor learaod cspni  hirtelen valaki megharapja a lábadat.  
Hátranézel és még egy vérszomjas nyúl. Gondolkozol hogy elöször melyik fejét csabd le ám ekkor elöugrál az egyik bokorbol egy harmadik nyul is. 
Te töntöd el milyen sorrendbe küzdesz meg velük!
Ezutány a kemény csat utány kicsit ledölsz a földre és leszurod magad mellé a kardodat. 
Ám amikor kényelmesen elhejezkednél a nap utolsó sugar  rásüt a tisdztásra  és megcsillna a kardodon ami vissza veri a fényt és eltalál egy fa törzset. 
Ezzen a fán volt egy érzékelő amitöl megmozdul a talaj alattad és az egész tisztás a föld alá süjjed.
Feálsz kihuzod a földbol a kardod és körbenézel. Két oriási feket e alagutat látsz. 

B:

Elindolsz a töled barra lévő alagut felé. 
Megláts a egy alakot égy oriási trolt.
Nem volt egyszerü de legyözted a trolt.
A fojoso egyre sotétebb lesz viszpont még kivehetöen látod azt a hatalmas boltives kaput két kőszobor áll a két oldalán és egy vizköpő a tetején ül. mintha a vizköpö pislogot volna.
A vizköpő legözése még enhezzeb volt minta a trolé de ezis sikerült.
Átlépsz a kapun és egy hetelmas felásaskodó sárkány áll elötedd nnem kell megijedin köböl van ne fog bántan vagy mégis?
A kösárkány majddnem megölt de még tulélted.
A sárkány mögött egy lépcősorr van aminek a tetején egy tron.
A tron háttámlájában egy zölden fénylő kristály van.
amikor meg fogod a kristályt arra gondolsz hogy a fancba fogsz innen kimászni. ekkir hirtlen  othon találaod maga d és rájösz hogya kivánságok égkövét találtad meg.
Azért érdekelt volna mi is volt jobra.

 */
                }
            }
        }
    }
}

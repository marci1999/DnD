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
            bool jatekTart = true;
            char holAJatekos = 'k'; //kozep
            bool vege = false;
            Console.WriteLine("Üdvözöllek bátor harcos, hogy hívhatlak?");
            Console.WriteLine("add meg az értéket, és \"enter\""); 
            string nev = Console.ReadLine();
            int ero = -1;
            int elet = -1;
            int maradekHPPotik = 6;
            do
	        {
                if (elet-ero >= 100 || ero-elet >= 100)
	            {
                    Console.WriteLine("tül sokk az élted az erődhöz képest.\n"+
                        "maximum 100 lehet a külömbség");
	            }
                Console.WriteLine("És milyen erős vagy!");
                Console.WriteLine("add meg az értéket, és \"enter\""); 
                do
	            {
                    try 
	                {	       
		                 ero = Convert.ToInt32(Console.ReadLine());
	                }
	                catch (Exception)
	                {
                        Console.WriteLine("nem számot adtál meg");
	                }
                    if (ero == 0)
	                {
                        Console.WriteLine("az erőd nem lehet 0");
	                }
	            } while (ero <= 0);
                Console.WriteLine("És mennyire vagy szívós (mennyi az életed)!");
                Console.WriteLine("add meg az értéket, és \"enter\""); 
                do
	            {
                    try 
	                {	        
		                 elet = Convert.ToInt32(Console.ReadLine());
	                }
	                catch (Exception)
	                {
                        Console.WriteLine("nem számot adtál meg");
	                }
                    if (elet == 0)
	                {
                        Console.WriteLine("az éleded nem lehet 0");
	                }
	            } while (elet <= 0);
	        } while (elet-ero >= 100 || ero-elet >= 100);
            int hPPotiModosito = 20;
            int lenyModosito = 0;
            int kezdetiElet = elet;
            for (int i = 0; i < p.Ellneseg.Count(); i++)
			{
                double ideiglenesEro = ero;
                double ideiglenesElet = elet;
                if (elet < 100)
	            {
                    lenyModosito = Convert.ToInt32(10-(ideiglenesEro/100)*10);
                     p.Ellneseg[i].Eletero -= lenyModosito;
                    if (p.Ellneseg[i].Eletero <= 0)
	                {
                      p.Ellneseg[i].Eletero = 1;
	                }   
                    hPPotiModosito -= lenyModosito*2;
                    if (hPPotiModosito <= 0)
	                {
                        hPPotiModosito = 1;
	                }
	            }
                else if(elet > 100)
                {
                    lenyModosito = Convert.ToInt32(elet/100);
                    p.Ellneseg[i].Eletero += elet;
                    hPPotiModosito += lenyModosito*2;
                }
                if (ero < 10)
	            { 
                    lenyModosito = Convert.ToInt32(10-(ideiglenesEro/10)*10);
                    p.Ellneseg[i].Sebzes -= lenyModosito;
                    if (p.Ellneseg[i].Sebzes <= 0)
	                {
                      p.Ellneseg[i].Sebzes = 1;
	                }
	            }
                else if(ero > 10)
                {
                    p.Ellneseg[i].Sebzes += ero;
                }
			}
            Karakter jatekos = new Karakter(""+nev+"",elet,ero); /// alapp: 100 10
            Console.WriteLine(jatekos);
            Console.WriteLine("Remek. Akkor kezdődhet is a kaland! \n"+
                "Mész az erdőben és nagy kincseket keresel. \n"+
                "Egyszer csak előugrik egy vérszomjas nyúl az egyik bokorból.");
            Console.WriteLine("\nEllenségek:");
            Console.WriteLine(p.Ellneseg[0].ToString());
            Console.WriteLine("nyomj egy gombot"); 
            Console.ReadKey();
            Console.WriteLine("Kicsit megijedsz és felemeled a kardodat, hogy megküzdj vele. \n"+
                "Amikor le akarod csapni,  hirtelen valaki megharapja a lábadat.\n"+
                "Hátra nézel és még egy vérszomjas nyúl van ott.");
            Console.WriteLine("\nEllenségek:");
            Console.WriteLine(p.Ellneseg[1].ToString());
            Console.WriteLine("nyomj egy gombot");
            Console.ReadKey();
            Console.WriteLine("Gondolkozol, hogy először melyiknek a  fejét csapd le, ám ekkor előugrik az egyik bokorból egy harmadik nyúl is.");
            Console.WriteLine("\nEllenségek:");
            Console.WriteLine(p.Ellneseg[2].ToString());
            Console.WriteLine("Te döntöd el, milyen sorrendben harcolsz velük!");
            Console.WriteLine("nyomj egy gombot");
            Console.ReadKey();
            Console.Clear();
            char parancs = 'a';
            int reteg = -1;
            int a  = 0;
            int elozzo = 0;
            while (jatekTart)
            {
                bool elagazas =false;
                if (p.Ellneseg[0].Eletero<=0 && p.Ellneseg[1].Eletero<=0 && p.Ellneseg[2].Eletero<=0 && holAJatekos=='k')
                    {
                        elagazas = true;
                    }
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
                        if (reteg == 1)
	                    {
                            Console.WriteLine(p.Ellneseg[3].ToString());
	                    } 
                        else if (reteg == 2)
	                    {
                            Console.WriteLine(p.Ellneseg[4].ToString());
	                    } 
                        else if (reteg == 3)
	                    {
                            Console.WriteLine(p.Ellneseg[5].ToString());
	                    }
                        break;
                    case 'j':
                        if (reteg == 1)
	                    {
                            Console.WriteLine(p.Ellneseg[6].ToString());
	                    } 
                        else if (reteg == 2)
	                    {
                            Console.WriteLine(p.Ellneseg[7].ToString());
	                    } 
                        else if (reteg == 3)
	                    {
                            Console.WriteLine(p.Ellneseg[8].ToString());
	                    }
                        break;
                    default:
                        break;
                }
                if (elagazas)
	            {
                    reteg++;      
	            }
                if (p.Ellneseg[3].Eletero<=0 && reteg == 1)
                {
                    reteg++;
	            }
                if (p.Ellneseg[4].Eletero<=0 && reteg == 2)
                {
                    reteg++;
	            }
                if (p.Ellneseg[5].Eletero<=0 && reteg == 3)
                {
                    reteg++;
	            }
                if (p.Ellneseg[6].Eletero<=0 && reteg == 1)
                {
                    reteg++;
	            }
                if (p.Ellneseg[7].Eletero<=0 && reteg == 2)
                {
                    reteg++;
	            }
                if (p.Ellneseg[8].Eletero<=0 && reteg == 3)
                {
                    reteg++;
	            }
                elozzo = a;
                if (reteg == 0)
	            {
                    Console.WriteLine("Ezután a kemény csata után, kicsit ledőlsz a földre és leszúrod magad mellé a kardodat.\n"+
                        "Ám amikor kényelmesen elhelyezkednél, a nap utolsó sugara rásüt a tisztásra és megcsillan a kardodon, ami vissza veri a fényt és eltalál egy fatörzset.\n"+
                        "Ezen a fán volt egy érzékelő, amitől megmozdul a talaj alattad és az egész tisztás a föld alá süllyed.\n"+
                        "Felállsz, kihúzod a földből a kardod és körbe nézel. \nKét óriási, fekete alagutat látsz. ");
                    Console.WriteLine("nyomj egy gombot");
                    Console.ReadKey();
	            }

                if (holAJatekos == 'b')
	            {
                    if (reteg == 1)
	                {
                        Console.WriteLine("Elindulsz a tőled balra lévő alagút felé. \n"+
                            "Meglátsz egy alakot, egy óriási trollt.");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[3].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 2)
	                {
                        Console.WriteLine("Nem volt egyszerű, de legyőzted a trollt.\n"+
                            "A folyosó egyre sötétebb lesz, viszont még jól látod azt a hatalmas boltíves kaput, aminek két kőszobor áll a két oldalán és egy vízköpő ül a tetején, mintha a vízköpő pislogott volna.");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[4].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 3)
	                {
                        Console.WriteLine("A vízköpő legyőzése még nehezebb volt, mint a trollé, de ez is sikerült.\n"+
                            "Átlépsz a kapun és egy hatalmas felágaskodó sárkány áll előtted, nem kell megijedni kőből van, nem fog bántani, vagy mégis?");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[5].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 4)
	                {
                        Console.WriteLine("A kő sárkány majdnem megölt.\nA sárkány mögött egy lépcsősor van, aminek a tetején egy trón áll.\n"+
                            "A trón háttámlájában egy zölden fénylő kristály van.\nAmikor megfogod a kristályt, arra gondolsz, hogy fogsz innen kimászni, ekkor hirtelen otthon találod magad, és rájössz, hogy a kívánságok ékkövet találtad meg.\n"+
                            "Azért érdekelt volna mi lett volna a jobb oldali alagútban.");
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
                        vege = true;
	                }
	            } 
                else if (holAJatekos == 'j')
                { 
                    if (reteg == 1)
	                {
                        Console.WriteLine("Elindulsz a tőled jobbra lévő alagút felé.\n"+
                            "Amikor átléped a küszöböt, egy erdős területen találod magad.\n"+
                            "Hirtelen megfordulsz és látod, hogy egy erdő közepén állsz.\n"+
                            "Időd sincsen csodálkozni, ugyanis egy hatalmas, vérszomjas nyúllal nézel farkasszemet, lehetséges hogy vissza kerültél a tisztásra és ez a nyulak vezére?");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[6].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 2)
	                {
                        Console.WriteLine("A hatalmas nyúl legyőzése után egy kicsit felsóhajtasz, és megpróbálsz rájönni, hogy most pontosan hol is lehetsz.\n"+
                            "Meglátsz a fák között egy zöldnövénnyel benőtt kastélyt.\nAmikor közelebb mész a kastélyhoz meglátod, hogy egy hatalmas ent áll a kapuban, reméled, hogy nem akar bántani, és el tudsz menni mellette.");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[7].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 3)
	                {
                        Console.WriteLine("Az ent legyőzése nem volt egyszerű de sikerült.\nBemész a kastélyba és felfedezed termeit.\n"+
                            "Az utolsó terembe érve, meglátsz egy hatalmas trónt, amikor megpróbálsz odamenni, egy óriási tűzvillanást látsz, és megjelenik egy főnix. \n"+
                            "Úgy tűnik vele is meg kell küzdeni.");
                        Console.WriteLine("\nEllenség:");
                        Console.WriteLine(p.Ellneseg[8].ToString());
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
	                }
                    else if (reteg == 4)
	                {
                        Console.WriteLine("Amikor a főnixet lecsapod és elhamvad, a hamvak között egy koronát találsz.\nKíváncsian odamész a trónhoz, ráülsz és felveszed a koronát.\n"+
                            "Egyszer csak rengeteg állat jelenik meg körülötted, mind lehajol, és királyuk ként tisztel. \n"+
                            "Rájössz, hogy érted a nyelvüket. \nEzután a te feladatod lesz, hogy vezérük légy, iránytű őket és gondoskodj róluk.\n"+
                            "Ez egy hatalmas felelősség, de azt még nem tudod, hogy a jutalom itt nem ért véget. \n"+
                            "Ugyanis ha meghalsz, te leszel a főnix.");
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
                        vege = true;
	                }
                }
                if (elagazas)
	            {
                    Console.WriteLine("\n---------------------------------------------------------------------------------\n" +
                    "Mit szeretnél csinálni? b - balra megy, j - jobbra megy, k - kilépés");
                    reteg++;
	            }
                else if (vege)
	            {
                    Console.WriteLine("\n---------------------------------------------------------------------------------\n" +
                        "köszönöm a játékot\n"+
                    "Mit szeretnél csinálni? k - kilépés");
	            }
                else
                {
                    Console.WriteLine("\n---------------------------------------------------------------------------------\n" +
                    "Mit szeretnél csinálni? h - harc, g - gyogyulni, k - kilépés");
                }
                if (jatekos.Eletero <= 0)
	            {
                    parancs = 'v';
	            } else
	            {
                    try 
	                {	        
		                parancs = Convert.ToChar(Console.ReadLine());
	                }
	                catch (Exception)
	                {
                        
	                }
	            }
                
                
                Console.Clear();
                switch (parancs)
                {
                    case 'h':
                        if (elagazas)
	                    {
                             Console.WriteLine("hibás parancs");
	                    }
                        else
	                    {
                            Console.WriteLine("Kivel harcolsz?");
                            switch(holAJatekos)
                            {
                                case 'k':
                                    Console.WriteLine("1   "+p.Ellneseg[0].ToString());
                                    Console.WriteLine("2   "+p.Ellneseg[1].ToString());
                                    Console.WriteLine("3   "+p.Ellneseg[2].ToString());
                                    Console.WriteLine("Nyomd meg azt a számot, amelyik ellenséggel harcolni akarsz és nyomj egy entert");
                                    try 
	                                {	        
		                                a = Convert.ToInt32(Console.ReadLine());
	                                }
	                                catch (Exception)
	                                {
                                        Console.WriteLine("ez nem szám");
                                        break;
	                                }
                                    if (a < 1||a > 3)
	                                {
                                        Console.WriteLine("nincs ilyen lény");
                                        break;
	                                }
                                    if (p.Ellneseg[a-1].Eletero<=0)
	                                {
                                        Console.WriteLine("ö már halot ne bánsd");
	                                } else
	                                {
                                        Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[a-1].Nev);
	                                }
                                    jatekos.Tamadas(jatekos, p.Ellneseg[a-1]);
                                    if (p.Ellneseg[a - 1].Eletero>0)
                                    {
                                        Console.WriteLine("{0} visszatámad", p.Ellneseg[a - 1].Nev);
                                        p.Ellneseg[a - 1].Tamadas(p.Ellneseg[a - 1], jatekos);
                                    }
                                    break;
                                case 'b':
                                    if (reteg == 1)
	                                {
                                        Console.WriteLine("4   " + p.Ellneseg[3].ToString());
	                                }
                                    else if (reteg == 2)
	                                {
                                        Console.WriteLine("5   " + p.Ellneseg[4].ToString());
	                                }
                                    else if (reteg == 3)
	                                {
                                        Console.WriteLine("6   " + p.Ellneseg[5].ToString());
	                                }
                                    Console.WriteLine("Nyomd meg azt a számot, amelyik ellenséggel harcolni akarsz nyomj egy entert");
                                    int ertek = (reteg + 3);
                                    try 
	                                {	        
		                                a = Convert.ToInt32(Console.ReadLine());
	                                }
	                                catch (Exception)
	                                {
                                        Console.WriteLine("ez nem szám");
                                        break;
	                                }
                                    if (a < 4||a > 6 || a!= ertek)
	                                {
                                        Console.WriteLine("nincs ilyen lény");
                                        break;
	                                }
                                    if (p.Ellneseg[a-1].Eletero<=0)
	                                {
                                        Console.WriteLine("ö már halot ne bánsd");
	                                } else
	                                {
                                        Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[a-1].Nev);
	                                }
                                    jatekos.Tamadas(jatekos, p.Ellneseg[a - 1]);
                                    if (p.Ellneseg[a - 1].Eletero > 0)
                                    {
                                        Console.WriteLine("{0} visszatámad", p.Ellneseg[a - 1].Nev);
                                        p.Ellneseg[a - 1].Tamadas(p.Ellneseg[a - 1], jatekos);
                                    }
                                    break;
                                case 'j':
                                    if (reteg == 1)
	                                {
                                        Console.WriteLine("7   " + p.Ellneseg[6].ToString());
	                                }
                                    else if (reteg == 2)
	                                {
                                        Console.WriteLine("8   " + p.Ellneseg[7].ToString());
	                                }
                                    else if (reteg == 3)
	                                {
                                        Console.WriteLine("9   " + p.Ellneseg[8].ToString());
	                                }
                                    Console.WriteLine("Nyomd meg azt a számot, amelyik ellenséggel harcolni akarsz nyomj egy entert");
                                    int ertek2 = (reteg + 6);
                                    try 
	                                {	        
		                                a = Convert.ToInt32(Console.ReadLine());
	                                }
	                                catch (Exception)
	                                {
                                        Console.WriteLine("ez nem szám");
                                        break;
	                                }
                                    if (a < 7||a > 9 || a!= ertek2)
	                                {
                                        Console.WriteLine("nincs ilyen lény");
                                        break;
	                                }
                                    if (p.Ellneseg[a-1].Eletero<=0)
	                                {
                                        Console.WriteLine("ö már halot ne bánd");
	                                } else
	                                {
                                        Console.WriteLine("Megküzdesz {0}-val", p.Ellneseg[a-1].Nev);
	                                }
                                    jatekos.Tamadas(jatekos, p.Ellneseg[a - 1]);
                                    if (p.Ellneseg[a - 1].Eletero > 0)
                                    {
                                        Console.WriteLine("{0} visszatámad", p.Ellneseg[a - 1].Nev);
                                        p.Ellneseg[a - 1].Tamadas(p.Ellneseg[a - 1], jatekos);
                                    }
                                    break;
                            }
                            Console.WriteLine("nyomj egy gombot");
                            Console.ReadKey();
                            Console.Clear();
	                    }

                        break;
                    case 'g':
                        if (elagazas)
                        {
                            Console.WriteLine("hibás parancs");
                        }
                        else
                        {
                            if (maradekHPPotik == 0)
	                        {
                                Console.WriteLine("elfogyott a HP potid");
	                        }
                            else
                            {
                                if (jatekos.Eletero+hPPotiModosito >= kezdetiElet)
	                            {
                                    Console.WriteLine("ne használd el a hp potidat, mert nem sebzödtél {0} éltnél többet",hPPotiModosito);
	                            }
                                else
                                {
                                    Console.WriteLine("megiszol egy gyogyitó potit.");
                                    Console.WriteLine("maradék gyogyitó potijaid száma: "+maradekHPPotik);
                                    jatekos.Gyogyulas(jatekos, hPPotiModosito);
                                    maradekHPPotik--;
                                }
                            }
                        }
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 'b':
                        if (elagazas)
                        {
                            Console.WriteLine("balra mész");
                            holAJatekos = 'b';
                        }
                        else
                        {
                            Console.WriteLine("hibás parancs");
                        }
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 'j':
                        if (elagazas)
                        {
                            Console.WriteLine("jobbra mész");
                            holAJatekos = 'j';
                        }
                        else
                        {
                            Console.WriteLine("hibás parancs");
                        }
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 'k':
                        Console.WriteLine("Kiléptél");
                        jatekTart = false;
                        Console.WriteLine("nyomj egy gombot a kilépéshez");
                        Console.WriteLine("nyomj egy gombot");
                        Console.ReadLine();
                        break;
                    case 'v':
                        Console.WriteLine("Meghaltál");
                        jatekTart = false;
                        Console.WriteLine("nyomj egy gombot a kilépéshez");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("hibás parancs");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}

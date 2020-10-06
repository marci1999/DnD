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
            while (jatekTart)
            {
                Console.WriteLine("Mit szeretnél csinálni? h - harc, g - gyogyulni, b - balra megy, j - jobbra megy, k - kilépés");
                char parancs = Convert.ToChar(Console.ReadLine());
                switch (parancs)
                {
                    case 'h':
                        Console.WriteLine("most harcolsz");
                        break;
                    case 'g':
                        Console.WriteLine("gyogyulsz");
                        break;
                    case 'b':
                        Console.WriteLine("balra mész");
                        break;
                    case 'j':
                        Console.WriteLine("jobbra mész");
                        break;
                    case 'k':
                        Console.WriteLine("Kiléptél");
                        jatekTart = false;
                        break;
                    default:
                        Console.WriteLine("hibás parancs");
                        break;
                }
            }
        }
    }
}

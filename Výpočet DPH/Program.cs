using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Výpočet_DPH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte cenu zboží s DPH v Kč");
            int cenaDPH = int.Parse(Console.ReadLine());
            double dph15 = cenaDPH * 0.15;
            double dph21 = cenaDPH * 0.21;
            double cena = cenaDPH - dph15;
            double cena1 = cenaDPH - dph21;
            double výšeDaně = cenaDPH - cena;
            double výšeDaně1 = cenaDPH - cena1;
            Console.WriteLine("Cena bez 15% daně činí {0} a bez 21% daně {1} Kč, výše daně činí {2} a {3} Kč", cena, cena1, výšeDaně, výšeDaně1);
            Console.ReadLine();
        }
    }
}
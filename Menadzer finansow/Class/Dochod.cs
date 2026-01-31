using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menadzer_finansow.Class
{
    
    public class Dochod : Transakcja
    {
        public Dochod(string tytul, decimal kwota) : base(tytul, kwota) { }

       
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+{Kwota} PLN (DOCHÓD)");
            Console.ResetColor();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menadzer_finansow.Class
{
    
    public class Wydatek : Transakcja
    {
        public Wydatek(string tytul, decimal kwota) : base(tytul, kwota) { }

        
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"-{Kwota} PLN (WYDATEK)");
            Console.ResetColor();
        }
    }
}

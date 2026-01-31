using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menadzer_finansow.Class
{
 
    public abstract class Transakcja
    {
      
        private string tytul;
        private decimal kwota;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public decimal Kwota
        {
            get { return kwota; }
            set
            {
                
                if (value < 0)
                {
                    Console.WriteLine("Błąd: Kwota nie może być ujemna! Zapisuję jako dodatnią.");
                    kwota = Math.Abs(value);
                }
                else
                {
                    kwota = value;
                }
            }
        }

       
        public DateTime Data { get; set; }

        public Transakcja(string tytul, decimal kwota)
        {
           
            Tytul = tytul;
            Kwota = kwota;
            Data = DateTime.Now;
        }

        
        public virtual void WyswietlInformacje()
        {
            Console.Write($"{Data.ToShortDateString()} | {Tytul} | ");
        }
    }
}

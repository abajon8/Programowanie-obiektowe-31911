using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Menadzer_finansow.Class
{
    class Program
    {
        static string nazwaPliku = "finanse.json";
        static BazaDanych baza = new BazaDanych();

        static void Main(string[] args)
        {
            WczytajDane();

            bool czyDzialac = true;

           
            while (czyDzialac)
            {
                Console.Clear();
                Console.WriteLine("=== MENEDŻER FINANSÓW (PROJEKT STUDENCKI) ===");
                Console.WriteLine("1. Dodaj dochód");
                Console.WriteLine("2. Dodaj wydatek");
                Console.WriteLine("3. Wyświetl historię i saldo");
                Console.WriteLine("4. Zapisz i wyjdź");
                Console.Write("Wybierz opcję: ");

                string wybor = Console.ReadLine();

                
                switch (wybor)
                {
                    case "1":
                        DodajTransakcje(true);
                        break;
                    case "2":
                        DodajTransakcje(false);
                        break;
                    case "3":
                        WyswietlHistorie();
                        break;
                    case "4":
                        ZapiszDane();
                        czyDzialac = false;
                        break;
                    default:
                        Console.WriteLine("Nieznana opcja!");
                        break;
                }
            }
        }

        static void DodajTransakcje(bool czyDochod)
        {
            Console.Write("Podaj tytuł: ");
            string tytul = Console.ReadLine();

            Console.Write("Podaj kwotę: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal kwota))
            {
                if (czyDochod)
                {
                    Dochod nowyDochod = new Dochod(tytul, kwota);
                    baza.ListaDochodow.Add(nowyDochod);
                }
                else
                {
                    Wydatek nowyWydatek = new Wydatek(tytul, kwota);
                    baza.ListaWydatkow.Add(nowyWydatek);
                }
                Console.WriteLine("Dodano pomyślnie! Wciśnij Enter...");
            }
            else
            {
                Console.WriteLine("To nie jest liczba! Anulowano.");
            }
            Console.ReadKey();
        }

        static void WyswietlHistorie()
        {
            Console.Clear();
            Console.WriteLine("--- HISTORIA TRANSAKCJI ---");

            decimal saldo = 0;

           
            List<Transakcja> wszystkieTransakcje = new List<Transakcja>();
            wszystkieTransakcje.AddRange(baza.ListaDochodow);
            wszystkieTransakcje.AddRange(baza.ListaWydatkow);

           
            foreach (Transakcja t in wszystkieTransakcje)
            {
                
                t.WyswietlInformacje();

                if (t is Dochod)
                    saldo += t.Kwota;
                else
                    saldo -= t.Kwota;
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"AKTUALNE SALDO: {saldo} PLN");
            Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić...");
            Console.ReadKey();
        }

       
        static void ZapiszDane()
        {
            try
            {
                var opcje = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(baza, opcje);

                File.WriteAllText(nazwaPliku, jsonString);
                Console.WriteLine("Zapisano dane.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd zapisu: " + ex.Message);
            }
        }

        
        static void WczytajDane()
        {
            if (File.Exists(nazwaPliku))
            {
                try
                {
                    string jsonString = File.ReadAllText(nazwaPliku);
                    baza = JsonSerializer.Deserialize<BazaDanych>(jsonString);
                }
                catch
                {
                    baza = new BazaDanych();
                }
            }
        }
    }
}
//zadanie 1

//string haslo = "";

//while (haslo != "admin123")
//{


//    Console.WriteLine("Podaj poprawne hasło");
//    haslo = Console.ReadLine();

//}

//Console.WriteLine("hasło poprawne");

//zadanie 2

//int liczba = 0;
//do
//{
//    Console.WriteLine("podaj liczbę większą od zera");
//    liczba = int.Parse(Console.ReadLine());
//}
//while (liczba < 0);
//Console.WriteLine("podano prawidłową liczbę");

//zadanie 3

//string[] miasta = { "łódź", "wrocław", "poznań", "warszawa", "katowice" };
//foreach (string miasto in miasta)
//{
//    Console.WriteLine($"Masto: {miasto}");
//}


//zadanie 4

//public class Osoba
//{
//    public string imie;
//    public int wiek;

//    public Osoba (string i, int w)
//    {
//        imie = i;
//        wiek = w;
//    }
//    public void PrzedstawSie()
//    {
//        Console.WriteLine($"Moje imie to {imie}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Osoba p1 = new Osoba("Adam", 30);
//        p1.PrzedstawSie();

//        Osoba p2 = new Osoba("Jan", 60);
//        p2.PrzedstawSie();

//        Osoba p3 = new Osoba("Marek", 20);
//        p3.PrzedstawSie();
//        Console.ReadKey();
//    }
//}

//zadanie 5

//class KontoBankowe
//{
//    private double saldo;
//    public void Wplata(double kwota) 
//    { 
//        saldo += kwota;  
//    }
//    public double PobierzSaldo() 
//    { 
//        return saldo; 
//    }

//    public void Wyplata(double kwota)
//    { 
//       if (saldo >= kwota)
//        saldo -= kwota;
//       else
//        Console.WriteLine("Brak wystarczających środków na koncie");
//    }
//}

//zadanie 6
//class Zwierze
//{
//    public void Jedz() => Console.WriteLine("Zwierzę je");
//}

//class Pies : Zwierze
//{
//    public void szczekaj() => Console.WriteLine("Hau hau!");
//}

//class Kot : Zwierze
//{
//    public void Miaucz() => Console.WriteLine("Miauuu");
//}

//zadanie 7
//class Zwierze
//{
//    public virtual void Dajglos() => Console.WriteLine("zwierzę wydaje dźwięk");
//}

//class Pies : Zwierze
//{
//    public override void Dajglos() => Console.WriteLine("hau hau!");
//}

//class Kot : Zwierze
//{
//    public override void Dajglos() => Console.WriteLine("miau!");
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Zwierze[] Zwierzeta = new Zwierze[]
//        {
//            new Pies(),
//            new Kot(),
//        };
//        foreach (Zwierze z in Zwierzeta)
//        {
//            z.Dajglos();
//        }
//    }
//}
//ćwiczenie 1

//class Zwierze
//{
//    public virtual void DajGlos()
//    {
//        Console.WriteLine("Zwierzę wydaje dźwięk");
//    }
//}
//class Pies : Zwierze
//{
//    public override void DajGlos()
//    {
//        Console.WriteLine("Hau hau!");
//    }
//}
//class Kot : Zwierze
//{
//    public override void DajGlos()
//    {
//        Console.WriteLine("Miau!");
//    }
//}
//    class Krowa : Zwierze
//    {
//        public override void DajGlos()
//        {
//            Console.WriteLine("Muuuu!");
//        }
//    }

//class Program
//{
//    static void Main()
//    {
//        Zwierze[] zwierzeta = { new Pies(), new Kot(), new Krowa() };
//        foreach (Zwierze z in zwierzeta)
//        {
//            z.DajGlos();
//        }
//    }
//}


// ćwiczenie 2
//using System;

//abstract class Pojazd
//{
//    public string Marka { get; set; }
//    public abstract void UruchomSilnik();
//    public void Info()
//    {
//        Console.WriteLine($"Pojazd marki {Marka}");
//    }
//}
//class Samochod : Pojazd
//{
//    public override void UruchomSilnik()
//    {
//        Console.WriteLine("Silnik samochodu został uruchomiony");
//    }
//}
//class Motocykl : Pojazd
//{
//    public override void UruchomSilnik()
//    {
//        Console.WriteLine("Motocykl odpala z głośnym dźwiękiem");
//    }
//}
//class Ciezarowka : Pojazd
//{
//    public override void UruchomSilnik()
//    {
//        Console.WriteLine("Uruchomiono ciężarówke");
//    }
//}
//class Program
//{
//    static void Main ()
//    {
//        Samochod p1 = new Samochod();
//        p1.Marka = "Opel";
//        Motocykl p2 = new Motocykl();
//        p2.Marka = "Honda";
//        Ciezarowka p3 = new Ciezarowka();
//        p3.Marka = "MAN";


//        List <Pojazd> Parking = new List<Pojazd>();

//        Parking.Add(p1);
//        Parking.Add(p2);
//        Parking.Add(p3);

//        foreach (Pojazd p in Parking)
//        {
//            p.Info();
//            p.UruchomSilnik();
//        }

//    }
//}

//ćwiczenie 3

//interface IDrukowalne
//{
//    void Drukuj();
//}

//class Dokument : IDrukowalne
//{
//    public void Drukuj()
//    {
//        Console.WriteLine("Rozpoczynam drukowanie dokumentu");
//    }
//}
//class Zdjecie : IDrukowalne
//{
//    public void Drukuj()
//    {
//        Console.WriteLine("Rozpoczynam drukowanie zdjęcia");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IDrukowalne[] IDruk = new IDrukowalne[]
//        {
//            new Dokument(),
//            new Zdjecie(),
//        };
//        foreach (IDrukowalne I in IDruk)
//        {
//            I.Drukuj();
//        }
//    }
// }
using System;

public enum dniTygodnia
{
    Poniedzialek = 1,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

public enum pranie
{
    WkladaniePralki = 1,
    DodawaniePlynuDoPrania,
    WyborProgramu,
    UruchamianiePralki,
    Plukanie,
    Wirowanie,
    Suszenie
}

public enum posilki
{
    Sniadanie = 1,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum bierkiSzachowe
{
    Hetman = 1,
    Wieza,
    Goniec,
    Skoczek,
    Pionek,
    Krol
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dni tygodnia:");
        foreach (dniTygodnia dzien in Enum.GetValues(typeof(dniTygodnia)))
        {
            Console.WriteLine((int)dzien + ". " + dzien);
        }

        Console.WriteLine("\nEtapy prania:");
        foreach (pranie etap in Enum.GetValues(typeof(pranie)))
        {
            Console.WriteLine((int)etap + ". " + etap);
        }

        Console.WriteLine("\nPosilki w ciagu dnia:");
        foreach (posilki posilek in Enum.GetValues(typeof(posilki)))
        {
            Console.WriteLine((int)posilek + ". " + posilek);
        }

        Console.WriteLine("\nBierki szachowe:");
        foreach (bierkiSzachowe bierka in Enum.GetValues(typeof(bierkiSzachowe)))
        {
            Console.WriteLine((int)bierka + ". " + bierka);
        }

        Console.ReadLine();
    }
}

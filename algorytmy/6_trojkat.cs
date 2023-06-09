using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj dlugosci bokow trojkata:");

        double bokA = WczytajBok("Bok A");
        double bokB = WczytajBok("Bok B");
        double bokC = WczytajBok("Bok C");

        if (bokA == bokB && bokB == bokC)
        {
            Console.WriteLine("Podane boki tworza trojkat rownoboczny");
        }
        else
        {
            Console.WriteLine("Podane boki nie moga utworzyc trojkata rownobocznego");
        }
    }
        static double WczytajBok(string nazwaBoku)
    {
        double bok;
        while (true)
        {
            Console.Write(nazwaBoku + ": ");
            if (double.TryParse(Console.ReadLine(), out bok) && bok > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartosc");
            }
        }
        return bok;
    }
}
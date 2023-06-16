using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj podstawe potegi:");
        int podstawa = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wykladnik potegi:");
        int wykladnik = int.Parse(Console.ReadLine());

        if (wykladnik < 0)
        {
            Console.WriteLine("blad");
            return;
        }

        int wynik = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }

        Console.WriteLine("{0} do potegi {1} wynosi: {2}", podstawa, wykladnik, wynik);
    }
}


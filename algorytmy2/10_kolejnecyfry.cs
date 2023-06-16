using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe 3-cyfrowa:");

        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 100 || liczba > 999)
        {
            Console.WriteLine("blad");
            return;
        }

        Console.WriteLine("Kolejne cyfry:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(liczba + i);
        }
    }
}

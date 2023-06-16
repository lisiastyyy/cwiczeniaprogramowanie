using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe x:");
        long x = long.Parse(Console.ReadLine());

        long n = 1;
        long silnia = 1;

        while (silnia <= x)
        {
            if (silnia == x)
            {
                Console.WriteLine("Liczba " + x + " jest silnia liczby " + n);
            }
            if (silnia > x)
            {
                Console.WriteLine("Liczba " + x + " nie jest silnia zadnej liczby");
            }
                n++;
            silnia *= n;
        }
    }
}

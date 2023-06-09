using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwsza liczbe:");
        double licz1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe:");
        double licz2 = double.Parse(Console.ReadLine());

        double wiekszaLiczba = Math.Max(licz1, licz2);

        Console.WriteLine("Wieksza liczba: " + wiekszaLiczba);
    }
}
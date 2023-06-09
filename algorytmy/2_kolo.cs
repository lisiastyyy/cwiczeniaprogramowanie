using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pole kola:");
        double pole = Convert.ToDouble(Console.ReadLine());

        double promien = Math.Sqrt(pole / Math.PI);
        double obwod = 2 * Math.PI * promien;

        Console.WriteLine("Obwod kola: " + obwod);
    }
}
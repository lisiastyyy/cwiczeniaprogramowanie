using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe:");

        int liczba = int.Parse(Console.ReadLine());
        int odwrocona = 0;

        while (liczba > 0)
        {
            int cyfra = liczba % 10;
            odwrocona = odwrocona * 10 + cyfra;
            liczba = liczba/10;
        }
        Console.WriteLine("Liczba po odwroceniu cyfr: " + odwrocona);
    }
}
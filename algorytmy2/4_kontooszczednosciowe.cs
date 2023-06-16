using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj kwote poczatkowa na koncie:");
        double kwotaPoczatkowa = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        double oprocentowanie = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbe miesiecy oszczedzania:");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100;

        double kwotaKoncowa = kwotaPoczatkowa * Math.Pow(1 + oprocentowanieMiesieczne, liczbaMiesiecy);

        double podatekBelki = kwotaKoncowa * 0.19;
        kwotaKoncowa -= podatekBelki;

        Console.WriteLine("Kwota koncowa: " + kwotaKoncowa);
    }
}
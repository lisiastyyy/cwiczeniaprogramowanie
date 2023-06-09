using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wspolrzedna x punktu P:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wspolrzedna y punktu P:");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj promien kola:");
        double r = double.Parse(Console.ReadLine());

        double odlegloscOdSrodka = Math.Sqrt(x * x + y * y);

        if (odlegloscOdSrodka <= r)
        {
            Console.WriteLine("Punkt P({0}, {1}) lezy w obrebie kola.", x, y);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie lezy w obrebie kola.", x, y);
        }
    }
}
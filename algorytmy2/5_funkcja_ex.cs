using System;
class Program
{
    static void Main()
    {
        int n, x;
        double e = 0;

        //obliczanie silni danej liczby
        long silnia(int number)
        {
            return number == 0 ? 1 : number * silnia(number - 1);
        }

        Console.Write("Podaj n: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj x: ");
        x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            double term = Math.Pow(x, i)/silnia(i);

            //dodawanie wyrazu do sumy
            e += term;
        }

        Console.WriteLine("Suma {0} pierwszych wyrazow funkcji e^x wynosi {1}", n, e);
    }
}
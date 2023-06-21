using System;
class Program
{
    static void Main()
    {
        int rozmiar;
        rozmiar = 10;
        int[] tab = new int[rozmiar];

        Random random = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tab[i] = random.Next(100);
        }

        int najmniejszy = tab[0];
        int najwiekszy = tab[0];

        for (int i = 0; i < rozmiar; i++)
        {
            Console.WriteLine(tab[i]);

            if (tab[i] < najmniejszy)
            {
                najmniejszy = tab[i];
            }

            if (tab[i] > najwiekszy)
            {
                najwiekszy = tab[i];
            }
        }
        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Najwiekszy element: " + najwiekszy);
    }
}
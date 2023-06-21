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

        for (int i = 0; i < rozmiar; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}

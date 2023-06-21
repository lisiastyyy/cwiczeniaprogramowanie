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

        //sortowanie bąbelkowe
        for (int i = 0; i < rozmiar - 1; i++)
        {
            for (int j = 0; j < rozmiar - i - 1; j++)
            {
                if (tab[j] > tab[j + 1])
                {
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sortowanie:");
        for (int i = 0; i < rozmiar; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}

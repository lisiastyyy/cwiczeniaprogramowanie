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

        InsertionSort(tab);

        Console.WriteLine("Sortowanie:");
        for (int i = 0; i < rozmiar; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}
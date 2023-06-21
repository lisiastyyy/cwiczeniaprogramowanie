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

        SelectionSort(tab);

        Console.WriteLine("Sortowanie:");
        for (int i = 0; i < rozmiar; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
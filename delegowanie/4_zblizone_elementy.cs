using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] array =
        {
            {1,2,3,4,5 },
            { 6,7,8,9,0 },
            {10, 11, 12, 13, 14 },
            { 1, 3,3,4,5 }
        };

        int row1, row2;
        podobneWiersze(array, out row1, out row2);

        Console.WriteLine($"Najbardziej podobne wiersze: {row1} i {row2}");
    }

    static void podobneWiersze(int[,] array, out int row1, out int row2)
    {
        row1 = 0;
        row2 = 0;
        long najmniejszaRoznica = long.MaxValue;

        int iloscWierszy = array.GetLength(0);

        for (int i = 0; i < iloscWierszy; i++)
        {
            for (int j = i + 1; j < iloscWierszy; j++)
            {
                long roznica = liczroznice(array, i, j);

                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    static long liczroznice(int[,] array, int i, int j)
    {
        int iloscKolumn = array.GetLength(1);
        long roznica = 0;

        for (int kol = 0; kol < iloscKolumn; kol++)
        {
            roznica += (long)Math.Pow(array[i, kol] - array[j, kol], 2);
        }

        return roznica;
    }
}
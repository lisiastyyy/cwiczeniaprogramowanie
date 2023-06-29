using System;
class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int dWiersz = 0;
        int uWiersz = 9;
        int dKolumna = 0;
        int uKolumna = 9;

        //wypelnianie tablicy kolejnymi liczbami naturalnymi
        while (liczba <= 100)
        {
            for (int i = uWiersz; i >= dWiersz; i--)
            {
                tablica[i, uKolumna] = liczba++;
            }
            uKolumna--;

            for (int j = dKolumna; j <= uKolumna; j++)
            {
                tablica[dWiersz, j] = liczba++;
            }
            dWiersz++;

            for (int i = dWiersz; i <= uWiersz; i++)
            {
                tablica[i, dKolumna] = liczba++;
            }
            dKolumna++;

            for (int j = uKolumna; j >= dKolumna; j--)
            {
                tablica[uWiersz, j] = liczba++;
            }
            uWiersz--;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
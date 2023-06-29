using System;
class Program
{
    static void Main()
    {
        int rozmiar;
        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
        } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar < 1);

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;
        int dWiersz = 0;
        int uWiersz = rozmiar - 1;
        int dKolumna = 0;
        int uKolumna = rozmiar - 1;

        //wypelnianie tablicy kolejnymi liczbami naturalnymi
        while (liczba <= rozmiar * rozmiar)
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

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
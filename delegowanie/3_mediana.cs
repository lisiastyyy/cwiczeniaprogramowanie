using System;
class Program
{
    static void Main()
    {
        int[] liczby = {2, 2, 8, 1, 5, 3, 4, 6, 4, 6, 8};

        int mediana = ObliczMediane(liczby);

        Console.WriteLine("Mediana: " + mediana);
    }

    static int ObliczMediane(int[] tablica)
    {
        int rozmiar = tablica.Length;
        int[] sortTablica = new int[rozmiar];
        Array.Copy(tablica, sortTablica, rozmiar);
        Array.Sort(sortTablica);

        int indeksSrodkowy = rozmiar / 2;
        if (rozmiar % 2 == 0)
        {
            int lewySrodek = sortTablica[indeksSrodkowy - 1];
            int prawySrodek = sortTablica[indeksSrodkowy];
            return (lewySrodek + prawySrodek) / 2;
        }
        else
        {
            return sortTablica[indeksSrodkowy];
        }
    }
}
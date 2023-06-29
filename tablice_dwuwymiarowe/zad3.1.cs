using System;
class Program
{
    static void Main()
    {
        int liczbaWierszy;
        do
        {
            Console.Write("Podaj liczbe wierszy: ");
            if (int.TryParse(Console.ReadLine(), out liczbaWierszy) && liczbaWierszy >= 1)
            {
                break;
            }
            Console.WriteLine("Nieprawidlowa liczba wierszy. Podaj liczbe wieksza od 0.");
        } while (true);

        int liczbaKolumn = liczbaWierszy;

        int[,] tablica = new int[liczbaWierszy, liczbaKolumn];

        //wypelnianie tablicy kolejnymi liczbami naturalnymi
        int liczba = 1;
        for (int i = 0; i < liczbaWierszy; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    tablica[i, j] = liczba++;
                }
            }
            else
            {
                for (int j = liczbaKolumn - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba++;
                }
            }
        }

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = 0; j < liczbaKolumn; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
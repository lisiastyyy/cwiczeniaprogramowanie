using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int parzyste = 10;
        int liczlos = 0;
        int[] wylosowane = new int[parzyste];

        //losowanie liczb parzystych
        for (int i = 0; i < parzyste; i++)
        {
            int wylosowanaLiczba;

            do
            {
                //losowanie przedziału
                wylosowanaLiczba = random.Next(-8, 9);
                liczlos++;
            } while (wylosowanaLiczba % 2 != 0);

            wylosowane[i] = wylosowanaLiczba;
        }

        //wynik
        Console.Write("Wylosowane liczby parzyste: ");
        for (int i = 0; i < parzyste; i++)
        {
            Console.Write(wylosowane[i]);

            if (i < parzyste - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba losowan: " + liczlos);
    }
}

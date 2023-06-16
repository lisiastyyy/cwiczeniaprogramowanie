using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe wyrazow ciagu Fibonacciego do wygenerowania:");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Liczba wyrazow musi byc wieksza od zera");
            return;
        }

        int pwyraz = 0;
        int dwyraz = 1;
        Console.Write("Ciag Fibonacciego: " + pwyraz + " " + dwyraz);

        for (int i = 2; i < n; i++)
        {
            int aktualnyWyraz = pwyraz + dwyraz;
            Console.Write(" " + aktualnyWyraz);

            pwyraz = dwyraz;
            dwyraz = aktualnyWyraz;
        }
        Console.WriteLine();
    }
}

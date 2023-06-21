using System;
class Program
{
    static bool czypierw(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Podaj n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int liczba = 2;
        int licznik = 0;

        while (licznik < n)
        {
            if (czypierw(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }
            liczba++;
        }
    }
}

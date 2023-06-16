using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pomysl liczbę z przedzialu 1-20.");

        int min = 1;
        int max = 20;
        int guess;
        string response;

        do
        {
            guess = (min + max)/2;

            Console.WriteLine("Czy pomyslana liczba to " + guess + "?");
            Console.WriteLine("Odpowiedz ujemna, jesli liczba jest mniejsza,");
            Console.WriteLine("dodatnia, jesli liczba jest wieksza,");
            Console.WriteLine("lub wpisz 0, jeśli zgadlem:");

            response = Console.ReadLine();

            if (response == "0")
            {
                Console.WriteLine("Liczba odgadnieta");
                break;
            }
            else if (response.StartsWith("-"))
            {
                max = guess - 1;
            }
            else
            {
                min = guess + 1;
            }
        } while (min <= max);

        if (min > max)
        {
            Console.WriteLine("Liczba nie odgadnieta");
        }
    }
}
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwsza liczbe:");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe:");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz numer dzialania:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnozenie");
        Console.WriteLine("4. Dzielenie");
        int numerDzialania = int.Parse(Console.ReadLine());

        double wynik = 0;

        if (numerDzialania == 1)
        {
            wynik = liczba1 + liczba2;
        }
        else if (numerDzialania == 2)
        {
            wynik = liczba1 - liczba2;
        }
        else if (numerDzialania == 3)
        {
            wynik = liczba1 * liczba2;
        }
        else if (numerDzialania == 4)
        {
            if (liczba2 != 0)
            {
                wynik = liczba1 / liczba2;
            }
            else
            {
                Console.WriteLine("Dzielenie przez zero", liczba1);
                return;
            }
        }
        else
        {
            Console.WriteLine("Nieprawidlowy numer dzialania");
            return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczby calkowite a, b, c, d:");
        int a = GetIntegerInput("a");
        int b = GetIntegerInput("b");
        int c = GetIntegerInput("c");
        int d = GetIntegerInput("d");

        int x, y;

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiazania");
        }
        else
        {
            x = a * d + b * c;
            y = b * d;

            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }
    }
        static int GetIntegerInput(string variableName)
    {
        Console.Write(variableName + ": ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
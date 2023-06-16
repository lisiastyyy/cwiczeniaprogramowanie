using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe n (wieksza lub rowna 5):");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbe k (wieksza lub rowna 5):");
        int k = int.Parse(Console.ReadLine());

        if (n < 5 || k < 5)
        {
            Console.WriteLine("Podane liczby sa za male");
            return;
        }

        //licz m=(n!-k!)/k!:
        long m = Factorial(n) - Factorial(k);
        m /= Factorial(k);

        Console.WriteLine("Wynik: " + m);
    }
    //obliczannie silni danej liczby
    static long Factorial(int number)
    {
        long result = 1;

        //obliczanie silni:
        for (int i = 2; i <= number; i++)
            result *= i;
        return result;
    }
}
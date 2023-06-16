using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych o sumie " + n + ":");

        for (int i = 1; i <= n/2; i++)
        {
            int j = n - i;
            Console.WriteLine(i + " + " + j + " = " + n);
        }
    }
}
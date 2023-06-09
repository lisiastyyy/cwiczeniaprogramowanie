using System;
using System.Collections.Specialized;
public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwsza liczbe:");
        a = inputValue();
        Console.WriteLine("Podaj druga liczbe:");
        b = inputValue();
        Console.WriteLine("Podaj trzecia liczbe:");
        c = inputValue();
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Wynik:");
        Console.WriteLine(sredniaArytmetyczna);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

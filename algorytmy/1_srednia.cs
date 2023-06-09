using System;
using System.Collections.Specialized;
public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine(sredniaArytmetyczna);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

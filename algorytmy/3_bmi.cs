using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wage [kg]:");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wzrost [m]:");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = Math.Round(waga / (wzrost * wzrost), 5);

        Console.WriteLine("Wspolczynnik BMI: " + bmi);
    }
}
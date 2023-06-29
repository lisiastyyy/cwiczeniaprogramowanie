using System;
class Program
{
    static void Main()
    {
        int czas = 332;
        string sformatowanyCzas = FormatCzas(czas);
        Console.WriteLine(sformatowanyCzas);
    }

    static string FormatCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("00");
        string sMinuty = minuty.ToString("00");
        string sSekundy = sekundy.ToString("00");

        return $"{sGodziny}:{sMinuty}:{sSekundy}";
    }
}
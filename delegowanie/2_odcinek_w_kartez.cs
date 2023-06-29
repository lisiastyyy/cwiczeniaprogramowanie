using System;
class Program
{
    static void Main()
    {
        //pkt poczatkowy
        double x1 = 2.5;
        double y1 = 3.7;

        //pkt koncowy
        double x2 = -1.8;
        double y2 = 0.9;

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);

        Console.WriteLine("Dlugosc odcinka: " + dlugoscOdcinka);
    }

    //obliczanie
    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return dlugosc;
    }
}
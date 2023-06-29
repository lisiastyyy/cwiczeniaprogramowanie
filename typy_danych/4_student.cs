using System;

enum plec
{
    Mezczyzna,
    Kobieta
}

struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public plec Plec;

    public void Wypelnij(string nazwisko, int nrAlbumu, double ocena, plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;
        Ocena = Math.Max(2.0, Math.Min(5.0, ocena));
        Plec = plec;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Student: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Plec: {Plec}");
    }
}

class Program
{
    static double Srednia(Student[] grupa)
    {
        double suma = 0;
        foreach (var student in grupa)
        {
            suma += student.Ocena;
        }
        return suma / grupa.Length;
    }

    static void Main(string[] args)
    {
        Student[] grupa = new Student[5];

        grupa[0].Wypelnij("Kowalski", 12345, 5.0, plec.Mezczyzna);
        grupa[1].Wypelnij("Nowak", 23456, 4.5, plec.Kobieta);
        grupa[2].Wypelnij("Mikulski", 34567, 5.0, plec.Mezczyzna);
        grupa[3].Wypelnij("Ziomek", 45678, 2.5, plec.Kobieta);
        grupa[4].Wypelnij("Karmazyn", 56789, 3.0, plec.Mezczyzna);

        foreach (var student in grupa)
        {
            student.Wyswietl();
        }

        double sredniaOcen = Srednia(grupa);
        Console.WriteLine($"Srednia ocen: {sredniaOcen}");
    }
}
using System;

struct Student
{
    public string imie;
    public string nazwisko;
    public int nrIndeksu;
    public int rokStudiow;
}

struct Przedmiot
{
    public string nazwa;
    public string kod;
    public int ects;
    public string wykladowca;
}

struct NauczycielAkademicki
{
    public string imie;
    public string nazwisko;
    public string tytulNaukowy;
    public string specjalizacja;
}

class Program
{
    static void Main(string[] args)
    {
        Student student1;
        student1.imie = "Szymon";
        student1.nazwisko = "Mucha";
        student1.nrIndeksu = 145752;
        student1.rokStudiow = 1;

        Przedmiot przedmiot1;
        przedmiot1.nazwa = "Cwiczenia Programowanie";
        przedmiot1.kod = "CWPROG";
        przedmiot1.ects = 5;
        przedmiot1.wykladowca = "mgr inż. Blazej Nycz";

        NauczycielAkademicki nauczyciel1;
        nauczyciel1.imie = "Blazej";
        nauczyciel1.nazwisko = "Nycz";
        nauczyciel1.tytulNaukowy = "mgr inż.";
        nauczyciel1.specjalizacja = "Informatyka";

        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine("Imie: " + student1.imie);
        Console.WriteLine("Nazwisko: " + student1.nazwisko);
        Console.WriteLine("Numer indeksu: " + student1.nrIndeksu);
        Console.WriteLine("Rok studiów: " + student1.rokStudiow);

        Console.WriteLine("\nInformacje o przedmiocie:");
        Console.WriteLine("Nazwa: " + przedmiot1.nazwa);
        Console.WriteLine("Kod: " + przedmiot1.kod);
        Console.WriteLine("ECTS: " + przedmiot1.ects);
        Console.WriteLine("Wykladowca: " + przedmiot1.wykladowca);

        Console.WriteLine("\nInformacje o nauczycielu akademickim:");
        Console.WriteLine("Imie: " + nauczyciel1.imie);
        Console.WriteLine("Nazwisko: " + nauczyciel1.nazwisko);
        Console.WriteLine("Tytul naukowy: " + nauczyciel1.tytulNaukowy);
        Console.WriteLine("Specjalizacja: " + nauczyciel1.specjalizacja);

        Console.ReadLine();
    }
}
using System;
namespace zad3
{
    enum klasaRzadkosci
    {
        Powszechny = 1,
        Rzadki,
        Unikalny,
        Epicki
    }

    enum typPrzedmiotu
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }

    struct przedmiot
    {
        public float Waga;
        public int Wartosc;
        public string Nazwa;
        public klasaRzadkosci Rzadkosc;
        public typPrzedmiotu Typ;

        public void Wypelnij(float waga, int wartosc, string nazwa, klasaRzadkosci rzadkosc, typPrzedmiotu typ)
        {
            Waga = waga >= 0 ? waga : 0;
            Wartosc = wartosc >= 0 ? wartosc : 0;
            Nazwa = nazwa;
            Rzadkosc = rzadkosc;
            Typ = typ;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Przedmiot: {Nazwa}");
            Console.WriteLine($"Waga: {Waga}");
            Console.WriteLine($"Wartosc: {Wartosc}");
            Console.WriteLine($"Rzadkosc: {Rzadkosc}");
            Console.WriteLine($"Typ: {Typ}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static przedmiot LosujPrzedmiot(przedmiot[] skrzynka)
        {
            Random random = new Random();

            Array.Sort(skrzynka, PorownajPrzedmioty);

            int sumaRzadkosci = 0;
            foreach (przedmiot przedmiot in skrzynka)
            {
                sumaRzadkosci += (int)przedmiot.Rzadkosc;
            }

            int losowanaRzadkosc = random.Next(1, sumaRzadkosci + 1);
            int aktualnaSuma = 0;

            foreach (var przedmiot in skrzynka)
            {
                aktualnaSuma += (int)przedmiot.Rzadkosc;
                if (aktualnaSuma >= losowanaRzadkosc)
                {
                    return przedmiot;
                }
            }

            return skrzynka[0];
        }

        static int PorownajPrzedmioty(przedmiot p1, przedmiot p2)
        {
            if (p1.Rzadkosc < p2.Rzadkosc)
                return -1;
            else if (p1.Rzadkosc == p2.Rzadkosc)
                return 0;
            else
                return 1;
        }

        static void Main(string[] args)
        {
            przedmiot[] skrzynka = new przedmiot[3];

            skrzynka[0].Wypelnij(1.5f, 10, "Miecz", klasaRzadkosci.Powszechny, typPrzedmiotu.Bron);
            skrzynka[1].Wypelnij(2.5f, 1000, "Naszyjnik ochrony", klasaRzadkosci.Unikalny, typPrzedmiotu.Amulet);
            skrzynka[2].Wypelnij(3.5f, 100000, "Zbroja smoka", klasaRzadkosci.Epicki, typPrzedmiotu.Zbroja);

            przedmiot wylosowany = LosujPrzedmiot(skrzynka);

            wylosowany.Wyswietl();
        }
    }
}
using System;
class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokosc trojkata: ");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscznakow = 2 * i + 1;
            int spacja = wysokosc - i - 1;

            for (int j = 0; j < spacja; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < iloscznakow; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}

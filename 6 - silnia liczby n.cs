using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 0;
        int faktorial = 1;

        while (faktorial <= x)
        {
            n++;

            if (faktorial == x)
            {
                Console.WriteLine("Liczba " + x + " jest silnią liczby " + n);
                return;
            }

            faktorial *= n;
        }

        Console.WriteLine("Liczba " + x + " nie jest silnią żadnej liczby");

        Console.ReadLine();
    }
}
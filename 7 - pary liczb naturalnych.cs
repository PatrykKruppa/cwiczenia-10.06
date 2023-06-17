using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych, których suma wynosi " + n + " to:");

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("(" + i + ", " + j + ")");
        }

        Console.ReadLine();
    }
}
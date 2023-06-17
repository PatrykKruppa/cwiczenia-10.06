using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Jest to program do obliczania m=(n!-k!)/k!");
        int k, n, m, nsilnia, ksilnia, i, j;

        Console.WriteLine("Podaj liczbe n, nie mniejszą niż 5");
        n = (int)inputValue();
        if (n > 4)
        {
        }
        else
        {
            Console.WriteLine("Podana liczba jest mniejsza od 5, podaj liczbę jeszcze raz");
        }
        Console.WriteLine("Podaj liczbe k, nie mniejszą niż 5");
        k = (int)inputValue();
        if (k > 4)
        {
        }
        else
        {
            Console.WriteLine("Podana liczba jest mniejsza od 5, podaj liczbę jeszcze raz");
        }
        nsilnia = 1;
        ksilnia = 1;
        i = 1;
        j = 1;
        for (i = 1; i <= n; i++)
        {
            nsilnia = nsilnia * i;
        }
        for (j = 1; j <= k; j++)
        {
            ksilnia = ksilnia * j;
        }
        m = (int)((double)(nsilnia - ksilnia) / ksilnia);
        Console.WriteLine("Wartość m wynosi: " + m);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int i, silnia, n, x;
        double wartoscPrzyblizenia;

        Console.WriteLine("Podaj wartość x");
        x = (int)inputValue();
        Console.WriteLine("Podaj liczbę wyrazów n");
        n = (int)inputValue();
        silnia = 1;
        i = 1;
        for (i = 1; i <= n; i++)
        {
            silnia = silnia * i;
        }
        wartoscPrzyblizenia = 0;
        for (i = 0; i <= n; i++)
        {
            wartoscPrzyblizenia = Math.Pow(x, i) / silnia;
        }
        Console.WriteLine(wartoscPrzyblizenia);
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








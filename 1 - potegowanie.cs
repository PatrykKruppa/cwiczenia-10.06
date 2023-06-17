using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("To jest kalkulator do potęgowania liczb");
        int podstawa, wykladnik;

        Console.WriteLine("Podaj podstawe");
        podstawa = (int)inputValue();
        Console.WriteLine("Podaj wykładnik");
        wykladnik = (int)inputValue();
        int wynik, i;

        wynik = 1;
        i = 1;
        while (i <= wykladnik)
        {
            wynik = wynik * podstawa;
            i = i + 1;
        }
        Console.WriteLine("Wynik potegowania to " + wynik);
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

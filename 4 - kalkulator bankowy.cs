using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witaj w kalkulatorze, który obliczy kwotę jaką zarobisz na koncie oszczędnościowym");
        Console.WriteLine("Podaj kwotę jaką chcesz wpłacić na konto oszczędnościowe");
        int miesiąc;
        double oprocentowanie, podatek, kwota, oprocentowaniemiesieczne, oszczednosci, zarobek;

        kwota = inputValue();
        Console.WriteLine("Podaj liczbę miesęcy przez którą chcesz oszczędzać");
        miesiąc = (int)inputValue();
        Console.WriteLine("Podaj oprocentowanie");
        oprocentowanie = inputValue();
        oprocentowaniemiesieczne = oprocentowanie / 12 / 100;
        oszczednosci = kwota * Math.Pow(1 + oprocentowaniemiesieczne, miesiąc);
        podatek = (oszczednosci - kwota) * 0.19;
        zarobek = oszczednosci - podatek;
        Console.WriteLine("Po " + miesiąc + " miesiącach będziesz miał na koncie oszczędnościowym " + zarobek);
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

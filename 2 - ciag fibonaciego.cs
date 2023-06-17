using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ten program wypisuje kolejne wyrazy ciągu Fibonacciego " + "Podaj liczbę, która określi ile wyrazów ciągu Fibonnaciego program ma wygenerować");
        int n, petla, liczba1, liczba2, suma;

        n = (int)inputValue();
        liczba1 = 1;
        liczba2 = 0;
        for (petla = 0; petla <= n; petla++)
        {
            suma = liczba1 + liczba2;
            liczba1 = liczba2;
            liczba2 = suma;
            Console.WriteLine(suma);
        }
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

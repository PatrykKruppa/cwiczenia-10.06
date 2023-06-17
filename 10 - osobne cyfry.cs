using System;

class Program
{
    static void Main()
    {
        Console.Write("Jest to program, który wypisuje osobno liczby naturalne dowolnej liczby która posiada przynajmniej 3 cyfry");
        Console.Write("Podaj liczbę naturalną: ");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 100)
        {
            Console.WriteLine("Podana liczba posiada mniej niż 3 cyfry.");
        }
        else
        {
            Console.WriteLine("Cyfry liczby " + liczba + ":");

            while (liczba > 0)
            {
                int cyfra = liczba % 10;
                Console.WriteLine(cyfra);
                liczba /= 10;
            }
        }

        Console.ReadLine();
    }
}
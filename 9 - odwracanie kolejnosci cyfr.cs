using System;

class Program
{
    static void Main()
    {
        Console.Write("Jest to program, który odwraca kolejność podanej liczby: ");
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());

        int odwroconaLiczba = OdwrocKolejnoscCyfr(liczba);

        Console.WriteLine("Liczba po odwróceniu: " + odwroconaLiczba);

        Console.ReadLine();
    }

    static int OdwrocKolejnoscCyfr(int liczba)
    {
        int odwroconaLiczba = 0;

        while (liczba > 0)
        {
            int cyfra = liczba % 10;
            odwroconaLiczba = (odwroconaLiczba * 10) + cyfra;
            liczba /= 10;
        }

        return odwroconaLiczba;
    }
}
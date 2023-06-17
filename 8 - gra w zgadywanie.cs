using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zgadnę liczbę jaką myślisz.");
        Console.WriteLine("Wybierz liczbę z przedziału od 1 do 20.");
        Console.WriteLine("Jeśli zgadłem liczbę, wpisz 0.");
        Console.WriteLine("Jeśli moja propozycja jest mniejsza od zaproponowanej liczby, wpisz liczbę ujemną (np.: -1).");
        Console.WriteLine("Jeśli moja propozycja jest większa od zapropnowanej liczby, wpisz liczbę dodatnią (np.: 1).");

        int dolnaGranica = 1;
        int gornaGranica = 20;
        int propozycja = (dolnaGranica + gornaGranica) / 2;

        while (true)
        {
            Console.WriteLine("Czy Twoja liczba to " + propozycja + "?");
            int odpowiedz = int.Parse(Console.ReadLine());

            if (odpowiedz == 0)
            {
                Console.WriteLine("Udało mi się!");
                break;
            }
            else if (odpowiedz < 0)
            {
                gornaGranica = propozycja - 1;
            }
            else if (odpowiedz > 0)
            {
                dolnaGranica = propozycja + 1;
            }

            propozycja = (dolnaGranica + gornaGranica) / 2;
        }

        Console.ReadLine();
    }
}
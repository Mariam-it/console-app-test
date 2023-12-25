using System;

class Program
{
    static void Main()
    {
        // Be användaren mata in sitt förnamn
        Console.Write("Ange ditt förnamn: ");
        string fornamn = Console.ReadLine();

        // Skriv ut hälsningsmeddelande
        Console.WriteLine($"Hej {fornamn}!");

        // Be om ytterligare information
        Console.Write("Ange ditt efternamn: ");
        string efternamn = Console.ReadLine();

        Console.Write("Ange din ålder: ");
        int alder;
        while (!int.TryParse(Console.ReadLine(), out alder))
        {
            Console.Write("Felaktig inmatning. Ange din ålder som ett nummer: ");
        }

        Console.Write("Ange din stad: ");
        string stad = Console.ReadLine();

        // Beräkna födelseår
        int aktuelltAr = DateTime.Now.Year;
        int fodelsear = aktuelltAr - alder;

        // Skriv ut information med staden i stor bokstav
        stad = char.ToUpper(stad[0]) + stad.Substring(1).ToLower();
        Console.WriteLine($"Ditt namn är {fornamn} {efternamn}, du är född år {fodelsear} och bor i {stad}.");
    }
}

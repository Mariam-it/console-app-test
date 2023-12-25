using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> shoppingLista = new List<string>();

        Console.WriteLine("Skriv in varor till din shoppinglista. Skriv 'klar' när du är färdig.");

        while (true)
        {
            Console.Write("Lägg till en vara: ");
            string vara = Console.ReadLine();

            if (vara.ToLower() == "klar")
            {
                break;
            }

            shoppingLista.Add(vara);
        }

        Console.WriteLine("\nDin shoppinglista:");
        foreach (string vara in shoppingLista)
        {
            Console.WriteLine($"- {vara}");
        }
    }
}

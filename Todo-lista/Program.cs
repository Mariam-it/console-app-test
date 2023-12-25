using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var todoLista = new List<Tuple<string, bool>>();

        Console.WriteLine("Skriv in uppgifter till din todo-lista. Skriv 'klar' för att sluta.");

        while (true)
        {
            Console.Write("Lägg till en uppgift: ");
            string uppgift = Console.ReadLine();

            if (uppgift.ToLower() == "klar")
            {
                break;
            }

            todoLista.Add(new Tuple<string, bool>(uppgift, false));
        }

        while (true)
        {
            Console.WriteLine("\nDin todo-lista:");
            for (int i = 0; i < todoLista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. [{(todoLista[i].Item2 ? "X" : " ")}] {todoLista[i].Item1}");
            }

            Console.Write("\nAnge numret på den uppgift du vill markera som avklarad (0 för att avsluta): ");
            if (!int.TryParse(Console.ReadLine(), out int val) || val == 0)
            {
                break;
            }

            if (val > 0 && val <= todoLista.Count)
            {
                todoLista[val - 1] = new Tuple<string, bool>(todoLista[val - 1].Item1, true);
            }
        }

        Console.WriteLine("\nDin slutgiltiga todo-lista:");
        foreach (var uppgift in todoLista)
        {
            Console.WriteLine($"- [{(uppgift.Item2 ? "X" : " ")}] {uppgift.Item1}");
        }
    }
}


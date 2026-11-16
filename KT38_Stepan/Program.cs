using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Вызов метода без перебора:");
        var evens = NumberGenerator.EvenNumbersUpTo(6);
        Console.WriteLine("Метод вызван, переменная создана. Но в консоли тихо\n");

        Console.WriteLine("2. Перебор через foreach:");
        foreach (var n in evens)
        {
            Console.WriteLine($"[Получено] {n}\n");
        }

        Console.WriteLine("3. Ограничение через Take(2):");
        foreach (var n in NumberGenerator.EvenNumbersUpTo(6).Take(2))
        {
            Console.WriteLine($"[Получено через Take] {n}\n");
        }
    }
}

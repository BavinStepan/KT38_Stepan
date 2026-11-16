using System;
using System.Collections.Generic;

public static class NumberGenerator
{
    public static IEnumerable<int> EvenNumbersUpTo(int max)
    {
        Console.WriteLine(" Итератор начал работу");

        for (int i = 0; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"[Трассировка] Готовлю значение {i}");
                yield return i;
            }
        }
    }
}
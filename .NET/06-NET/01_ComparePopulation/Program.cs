using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var capitals = new Capital[3];

        for (int i = 0; i < capitals.Length; i++)
        {
            Console.WriteLine($"Введите данные для {i + 1}-й столицы:");
            capitals[i] = SetCapitalData();
        }

        Capital SetCapitalData()
        {
            var capital = new Capital();
            Console.WriteLine("Введите название столицы:");
            capital.Name = Console.ReadLine();

            Console.WriteLine("Введите население столицы:");
            int population;
            if (int.TryParse(Console.ReadLine(), out population))
            {
                capital.Population = population;
            }
            else
            {
                Console.WriteLine("Некорректное значение населения. Используется значение по умолчанию.");
                capital.Population = 0;
            }

            return capital;
        }

        var sortedCapitals = capitals.OrderBy(c => c.Population).ToList();
        var largestCapital = sortedCapitals.Last();
        var smallestCapital = sortedCapitals.First();
        var middleIndex = sortedCapitals.Count / 2;
        var middleCapital = sortedCapitals[middleIndex];

        Console.WriteLine($"Столица с наибольшим населением: {largestCapital.Name} - {largestCapital.Population} чел.");
        Console.WriteLine($"Столица с наименьшим населением: {smallestCapital.Name} - {smallestCapital.Population} чел.");
        Console.WriteLine($"Столица с населением, находящимся посередине: {middleCapital.Name} - {middleCapital.Population} чел.");
    }

    class Capital
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }
}

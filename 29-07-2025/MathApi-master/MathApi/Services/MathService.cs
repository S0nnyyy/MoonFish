using MathApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Services
{
    public class MathService : IMathService
    {
        private readonly Random _random = new();

        public int Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"Bylo zavoláno sečtení s čísly x={x}, y={y}, výsledek={result}");
            return result;
        }

        public int Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"Bylo zavoláno násobení s čísly x={x}, y={y}, výsledek={result}");
            return result;
        }

        public int GenerateRandom()
        {
            int number = _random.Next(1, 101); // 1 až 100
            Console.WriteLine($"Bylo vygenerováno náhodné číslo: {number}");
            return number;
        }
    }
}

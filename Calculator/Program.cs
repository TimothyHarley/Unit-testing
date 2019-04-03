using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me some Numbers with some +'s between them.");
            var input = Console.ReadLine();
            var calculate = new CalculationEngine().DoMath(input);
            Console.WriteLine($"Your answer is {calculate}.  Press Enter to close.");
            Console.ReadLine();
        }
    }
}

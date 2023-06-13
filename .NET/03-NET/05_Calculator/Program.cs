using System;

namespace Calculator
{
    class Work
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");
            string expression = Console.ReadLine();

            try
            {
                double result = ExpressionProcessing.CalculateExpression(expression);
                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid expression: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

using System;

namespace LineEquation
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Choose the type of equation to solve:\n" +
                "1. A*X + B*Y = 0\n" +
                "2. A1*X + B1*Y = 0; A2*X + B2*Y = 0");

            int choiceEquationType = Convert.ToInt32(Console.ReadLine());

            switch (choiceEquationType)
            {
                case 1:
                    Console.WriteLine("Enter coefficients A and B separated by commas or spaces:");
                    string input = Console.ReadLine();

                    try
                    {
                        string[] separators = new[] { ",", " ", ", " };
                        string[] values = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        if (values.Length != 2)
                        {
                            throw new FormatException("Invalid input format. Two coefficients were expected, separated by a comma or a space.");
                        }

                        int a, b;
                        if (!int.TryParse(values[0], out a) || !int.TryParse(values[1], out b))
                        {
                            throw new FormatException("Wrong format. Integer values expected.");
                        }

                        LinearEquation equation = new LinearEquation(a, b);
                        double x, y;
                        LinearEquationSolver.SolveEquation(equation, out x, out y);
                        Console.WriteLine("Result: X = {0}, Y = {1}", x, y);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Format error: " + e.Message);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter coefficients A1, B1, A2 and B2 separated by commas or spaces:");
                    string input2 = Console.ReadLine();

                    try
                    {
                        string[] separators = new[] { ",", " ", ", " };
                        string[] values = input2.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        if (values.Length != 4)
                        {
                            throw new FormatException("Invalid input format. Four coefficients were expected, separated by a comma or space.");
                        }

                        int a1, b1, a2, b2;
                        if (!int.TryParse(values[0], out a1) || !int.TryParse(values[1], out b1) ||
                            !int.TryParse(values[2], out a2) || !int.TryParse(values[3], out b2))
                        {
                            throw new FormatException("Wrong format. Integer values expected.");
                        }

                        LinearEquation equation1 = new LinearEquation(a1, b1);
                        LinearEquation equation2 = new LinearEquation(a2, b2);
                        double x, y;
                        LinearEquationSolver.SolveSystemOfEquations(equation1, equation2, out x, out y);
                        Console.WriteLine("Result: X = {0}, Y = {1}", x, y);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Format error: " + e.Message);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Wrong choice.Please select 1 or 2");
                    break;
            }
        }
    }
}

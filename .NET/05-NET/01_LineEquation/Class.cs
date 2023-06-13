using System;

namespace LineEquation
{
    public class LinearEquation
    {
        public int A { get; set; }
        public int B { get; set; }

        public LinearEquation(int a, int b)
        {
            A = a;
            B = b;
        }

        public static LinearEquation Parse(string input)
        {
            string[] separators = new[] { ",", " ", ", " };
            string[] values = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (values.Length != 2)
            {
                throw new FormatException("Invalid input format. Expected two coefficients separated by a comma or space.");
            }

            int a, b;
            if (!int.TryParse(values[0], out a) || !int.TryParse(values[1], out b))
            {
                throw new FormatException("Invalid coefficient format. Expected integer values.");
            }

            return new LinearEquation(a, b);
        }
    }

    public class LinearEquationSolver
    {
        public static void SolveEquation(LinearEquation equation, out double x, out double y)
        {
            if (equation.A == 0 && equation.B == 0)
            {
                throw new ArgumentOutOfRangeException("No unique solution exists.");
            }

            if (equation.A == 0)
            {
                x = 0;
                y = 1;
            }
            else if (equation.B == 0)
            {
                x = 1;
                y = 0;
            }
            else
            {
                x = -equation.B / (double)equation.A;
                y = 1;
            }
        }

        public static void SolveSystemOfEquations(LinearEquation equation1, LinearEquation equation2, out double x, out double y)
        {
            int det = equation1.A * equation2.B - equation2.A * equation1.B;

            if (det == 0)
            {
                throw new ArgumentOutOfRangeException("No solution exists.");
            }

            x = -(equation1.B * equation2.B) / (double)det;
            y = (equation1.A * equation2.B) / (double)det;
        }
    }
}

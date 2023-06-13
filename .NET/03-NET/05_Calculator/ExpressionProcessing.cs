using System;
using System.Collections.Generic;

namespace Calculator
{
    class ExpressionProcessing
    {
        public static double CalculateExpression(string expression)
        {
            Stack<double> numberStack = new Stack<double>();
            Stack<char> operatorStack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == ' ')
                {
                    continue;
                }
                else if (Char.IsDigit(ch) || ch == '.')
                {
                    string numberString = ch.ToString();

                    while (i + 1 < expression.Length && (Char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                    {
                        numberString += expression[i + 1];
                        i++;
                    }

                    double number = double.Parse(numberString);
                    numberStack.Push(number);
                }
                else if (ch == '(')
                {
                    operatorStack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                    {
                        char op = operatorStack.Pop();
                        double operand2 = numberStack.Pop();
                        double operand1 = numberStack.Pop();
                        double result = ApplyOperator(op, operand1, operand2);
                        numberStack.Push(result);
                    }

                    if (operatorStack.Count == 0)
                    {
                        throw new ArgumentException("Mismatched parentheses");
                    }

                    operatorStack.Pop();
                }
                else if (IsOperator(ch))
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != '(' && HasHigherPrecedence(operatorStack.Peek(), ch))
                    {
                        char op = operatorStack.Pop();
                        double operand2 = numberStack.Pop();
                        double operand1 = numberStack.Pop();
                        double result = ApplyOperator(op, operand1, operand2);
                        numberStack.Push(result);
                    }

                    operatorStack.Push(ch);
                }
                else
                {
                    throw new ArgumentException($"Invalid character: {ch}", nameof(expression));
                }
            }

            while (operatorStack.Count > 0)
            {
                if (operatorStack.Peek() == '(')
                {
                    throw new ArgumentException("Mismatched parentheses");
                }

                char op = operatorStack.Pop();
                double operand2 = numberStack.Pop();
                double operand1 = numberStack.Pop();
                double result = ApplyOperator(op, operand1, operand2);
                numberStack.Push(result);
            }

            if (numberStack.Count != 1 || operatorStack.Count != 0)
            {
                throw new ArgumentException("Invalid expression");
            }

            return numberStack.Pop();
        }

        public static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '%' || ch == '^';
        }

        public static bool HasHigherPrecedence(char op1, char op2)
        {
            int precedence1 = GetOperatorPrecedence(op1);
            int precedence2 = GetOperatorPrecedence(op2);

            return precedence1 >= precedence2;
        }

        public static int GetOperatorPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        public static double ApplyOperator(char op, double operand1, double operand2)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                case '%':
                    return operand1 % operand2;
                case '^':
                    return Math.Pow(operand1, operand2);
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}
